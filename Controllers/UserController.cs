using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using Npgsql;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
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
                DateTime dateTime = (DateTime)row[9];
                user.dateOfBirth = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
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

            commandHeader.Append(") ");
            values.Append(") RETURNING id;");

            Guid user_id = await insert(commandHeader.Append(values).ToString());

            commandHeader.Clear();
            values.Clear();

            ElementCalculator calculator = new ElementCalculator(user);
            int calories = calculator.calcDCR(user.weight, user.height, user.getAge());
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
    
        public async Task<List<Recipe>> selectRecipes(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();

            DataTable recipesTable = await db.select($"SELECT * FROM user_has_recipes WHERE user_id = '{user.id}'");

            List<Recipe> recipes = new List<Recipe>();

            foreach (DataRow row in recipesTable.Rows) {
                RecipeController recipeController = new RecipeController();
                recipes.Add(await recipeController.findById(row[1].ToString()));
            }

            return recipes;
        }

        public async Task<Guid> insertUserRecipes(User user)
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

            return user.id;
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
