using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2;
using Npgsql;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthyLife_Pt2.Controllers
{
    public class UserController : DefaultController
    {

        public async Task<List<User>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);
           
            List<User> users = new List<User>();
            
            foreach(DataRow row in dataTable.Rows)
            {
                users.Add(createUser(row));
            }

            db.Close();
            return users;
        }

        public async Task<User> findById(string? user_id)
        {
            if (user_id == null) throw new ArgumentNullException();
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM users WHERE id = '{user_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("User not found");
            }

            return createUser(dataTable.Rows[0]);
        }

        public async Task<User> findByUsername(string username)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM users WHERE username = '{username}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            return createUser(dataTable.Rows[0]);
        }

        private User createUser(DataRow row)
        {
            User user = new User();
            user.id = (Guid)row[0];
            user.username = (string)row[1];
            user.password = (string)row[2];
            user.role = (bool)row[3];
            user.setSexAsString((string)row[4]);
            user.weight = (float)row[5];
            user.height = (int)row[6];
            user.setActivityAsString((string)row[7]);
            user.setGoalAsString((string)row[8]);
            if (!row[9].Equals(System.DBNull.Value))
            {
                user.dateOfBirth = (DateTime)row[9];
            }

            if (!row[10].Equals(System.DBNull.Value))
                user.photo = (string)row[10];

            return user;
        }

        public async Task<Guid> insertUser(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();

            string weight = doubleToDbString(user.weight); ;

            string dateOfbirth = "";
            
            StringBuilder commandHeader = new StringBuilder("INSERT INTO users (username, password, role, sex, weight, height, activity, goal");
            StringBuilder values = new StringBuilder($"VALUES ('{user.username}', '{user.password}', {user.role}, '{user.getSexAsString()}', {weight}, {user.height}," +
                $"'{user.getActivityAsString()}', '{user.getGoalAsString()}'");

            dateOfbirth = user.dateOfBirth.Year + "-" + user.dateOfBirth.Month + "-" + user.dateOfBirth.Day;
            commandHeader.Append(", date_of_birth");
            values.Append($", '{dateOfbirth}'");
            
            if (user.photo != null && user.photo != "")
            {
                commandHeader.Append(", photo");
                values.Append($", '{user.photo}'");
            }

            commandHeader.Append(") ");
            values.Append(") RETURNING id;");

            Guid user_id = await insert(commandHeader.Append(values).ToString());
            user.id = user_id;

            commandHeader.Clear();
            values.Clear();

            ElementCalculator calculator = new ElementCalculator(user);
            int calories = calculator.caloriesCalc(user.weight, user.height, user.getAge());
            double proteins = calculator.proteinsCalc(user.weight, user.height, user.getAge());
            double fats = calculator.fatsCalc(user.weight, user.height, user.getAge());
            double carbohydrates = calculator.carohydratesCalc(user.weight, user.height, user.getAge());
            
            commandHeader.Append("INSERT INTO elements (calories, proteins, fats, carbohydrates) ");
            values.Append($"VALUES ({calories}, {proteins}, {fats}, {carbohydrates}) RETURNING ID;");
            
            int element_id = await db.insert(commandHeader.Append(values).ToString());

            commandHeader.Clear();
            values.Clear();

            commandHeader.Append("INSERT INTO user_require_elements (user_id, element_id)");
            values.Append($"VALUES ('{user_id}', {element_id});");
            await db.insert(commandHeader.Append(values).ToString());

            db.Close();
            return user_id;
        }
        
        public async new Task<Guid> insert(string str)
        {
            NpgsqlCommand command = new NpgsqlCommand(str, DBConnector.connection);

            Guid user_id;
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                await Task.Run(() => adapter.Fill(dt));

                if (dt.Rows.Count == 0)
                    throw new Exception("User not found");

                user_id = Guid.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Wrong command");
            }

            command.Dispose();
            return user_id;
        }
        
        public async Task<Element> selectRequiredElement(User user)
        {

            DBConnector db = new DBConnector();
            db.Open();
            
            DataTable elementTable = await db.select($"SELECT * FROM user_require_elements WHERE user_id = '{user.id}'");

            ElementController elementController = new ElementController();
            Element? element = await elementController.findById(elementTable.Rows[0][1].ToString());

            if (element != null)
            {
                user.element = element;
            }
            else
            {
                db.Close();
                throw new Exception("The Element was null");
            }
            db.Close();

            return element;
        }       

        public async Task updateUser(User user, bool loginChanged)
        {

            StringBuilder commandHeader = new StringBuilder("UPDATE users " +
                $"SET " +
                $"sex = '{user.getSexAsString()}', " +
                $"weight = {doubleToDbString(user.weight)}, " +
                $"height = {user.height}, " +
                $"activity = '{user.getActivityAsString()}', " +
                $"goal = '{user.getGoalAsString()}', " +
                $"date_of_birth = '{user.dateOfBirth.Year + "-" + user.dateOfBirth.Month + "-" + user.dateOfBirth.Day}'");
            if (user.photo != null && user.photo != "")
            {
                commandHeader.Append($", photo = '{user.photo}'");
            }
            if (loginChanged)
                commandHeader.Append($", username = '{user.username}'");
            commandHeader.Append($" WHERE id = '{user.id}'");

            DBConnector db = new DBConnector();
            db.Open();
            await db.update(commandHeader.ToString());
            db.Close();

            UserWeight userWeight = new UserWeight();
            userWeight.weight = user.weight;
            userWeight.user = user;
            userWeight.updated_at = DateTime.Now.Date;
            userWeight.goal = user.weight;

            UserWeightController userWeightController = new UserWeightController();

            if (await userWeightController.alreadyExist(userWeight))
                await userWeightController.updateUserWeight(userWeight);
            else
                await userWeightController.insertUserWeight(userWeight);

            Element element = new Element();

            ElementCalculator calculator = new ElementCalculator(user);
            element.calories = calculator.caloriesCalc(user.weight, user.height, user.getAge());
            element.proteins = calculator.proteinsCalc(user.weight, user.height, user.getAge());
            element.fats = calculator.fatsCalc(user.weight, user.height, user.getAge());
            element.carbohydrates = calculator.carohydratesCalc(user.weight, user.height, user.getAge());

            Element requiredElement = await selectRequiredElement(user);

            ElementController elementController = new ElementController();
            if (requiredElement == null)
            {
                await elementController.insertElement(element);
            }
            else
            {
                element.id = requiredElement.id;
                await elementController.updateElement(element);
            }

        }

        public async Task<List<Diet>> selectDiets(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();

            DataTable dietsTable = await db.select($"SELECT * FROM diets WHERE user_id = '{user.id}'");

            List<Diet> diets = new List<Diet>();

            foreach (DataRow row in dietsTable.Rows)
            {
                Diet diet = new Diet();
                diet.id = (int)row[0];
                diet.name = (string)row[1];
                diet.description = (string)row[2];

                if (!row[4].Equals(System.DBNull.Value))
                    diet.photo = (string)row[4];

                diet.setGoalAsString((string)row[5]);

                MealController mealController = new MealController();
                diet.meals = await mealController.selectFromDietHasMeals(diet.id.ToString());

                diets.Add(diet);
            }

            db.Close();
            return diets;
        }

        public async Task insertUserRecipes(User user)
        {
            if (user.recipes.Count == 0)
                throw new Exception("No recipes was added");

            DBConnector db = new DBConnector();
            db.Open();


            StringBuilder commandHeader = new StringBuilder();
            StringBuilder values = new StringBuilder();

            commandHeader.Append("INSERT INTO user_has_recipes (user_id, recipe_id) VALUES ");

            bool b = false;
            foreach (Recipe recipe in user.recipes)
            {
                if (b)
                    values.Append($", ");
                b = true;
                values.Append($"('{user.id}', {recipe.id})");
            }
            values.Append(";");

            await db.insert(commandHeader.Append(values).ToString());
            db.Close();
        }

        public async Task insertUserSelectedDiets(User user)
        {
            if (user.selectedDiets.Count == 0)
                throw new Exception("No recipes was added");

            DBConnector db = new DBConnector();
            db.Open();


            StringBuilder commandHeader = new StringBuilder();
            StringBuilder values = new StringBuilder();

            commandHeader.Append("INSERT INTO user_has_diet (user_id, diet_id) VALUES ");

            bool b = false;
            foreach (Diet diet in user.selectedDiets)
            {
                if (b)
                    values.Append($", ");
                b = true;
                values.Append($"('{user.id}', {diet.id})");
            }
            values.Append(";");

            await db.insert(commandHeader.Append(values).ToString());
            db.Close();
        }

        public async Task deleteUserRecipes(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();
            await db.remove($"DELETE FROM user_has_recipes WHERE user_id = '{user.id}'");
            db.Close();
        }

        public async Task deleteUserSelectedDiets(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();
            await db.remove($"DELETE FROM user_has_diet WHERE user_id = '{user.id}'");
            db.Close();
        }

        public async Task updateUserRecipes(User user)
        {
            await deleteUserRecipes(user);
            await insertUserRecipes(user);
        }

        public async Task updateUserSelectedDiets(User user)
        {
            await deleteUserSelectedDiets(user);
            await insertUserSelectedDiets(user);
        }
        /*
        public async Task<List<Meal>> selectALLUserDailyMeals(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();

            DataTable mealsTable = await db.select($"SELECT * FROM user_daily_meal WHERE user_id = '{user.id}'");


        }
        */
    }
}
