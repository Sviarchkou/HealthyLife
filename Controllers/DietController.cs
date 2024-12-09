using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthyLife_Pt2.Controllers
{
    public class DietController : DefaultController
    {

        public async Task<List<Diet>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);
            db.Close();

            List<Diet> diets = new List<Diet>();

            foreach (DataRow row in dataTable.Rows)
            {
                diets.Add(await createDiet(row));
            }
            return diets;
        }

        public async Task<List<Diet>> selectUserDiets(string user_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_has_diet WHERE user_id = '{user_id}'");
            db.Close();

            List<Diet> diets = new List<Diet>();

            foreach (DataRow row in dataTable.Rows)
            {
                try
                {
                    diets.Add(await findById(row[1].ToString()));
                }
                catch (Exception) { }
            }
            return diets;
        }

        public async Task<Diet> findById(string diet_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM diets WHERE id = '{diet_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Diet not found"); ;
            }
            return await createDiet(dataTable.Rows[0]);
        }

        private async Task<Diet> createDiet(DataRow row)
        {
            Diet diet = new Diet();
            diet.id = (int)row[0];
            diet.name = (string)row[1];
            diet.description = (string)row[2];

            UserController userController = new UserController();
            diet.creator = await userController.findById(row[3].ToString());
            
            if (!row[4].Equals(System.DBNull.Value))
                diet.photo = (string)row[4];

            diet.setGoalAsString((string)row[5]);

            MealController mealController = new MealController();
            diet.meals = await mealController.selectFromDietHasMeals(diet.id.ToString());            

            return diet;
        }

        public async Task<int> insertDiet(Diet diet)
        {
            
            StringBuilder commandHeader = new StringBuilder("INSERT INTO diets (name, description, user_id, goal");
            StringBuilder values = new StringBuilder($"VALUES ('{diet.name}', '{diet.description}', '{diet.creator.id}', '{diet.getGoalAsString()}'");
            
            if (diet.photo != null || diet.photo == "")
            {
                commandHeader.Append(", photo");
                values.Append($", '{diet.photo}'");
            }
            commandHeader.Append(") ");
            values.Append(") RETURNING id");

            DBConnector db = new DBConnector();
            db.Open();
            
            diet.id = await db.insert(commandHeader.Append(values).ToString());
            
            foreach(Meal meal in diet.meals)
            {
                await db.insert($"INSERT INTO diet_has_meals (meal_id, diet_id) VALUES ({meal.id}, {diet.id});");
            }
            
            db.Close();

            return diet.id;
        }

        public async Task<bool> isUnreleted(Diet diet)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_has_diets WHERE diet_id = '{diet.id}'");
            db.Close();
            if (dataTable.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        public async Task deleteDiet(Diet diet)
        {
            DBConnector db = new DBConnector();
            db.Open();

            await db.remove($"DELETE FROM user_has_diet WHERE diet_id = '{diet.id}'");

            MealController mealController = new MealController();
            List<Meal> meals = await mealController.selectFromDietHasMeals(diet.id.ToString());
            await db.remove($"DELETE FROM diet_has_meals WHERE diet_id = '{diet.id}'");
            foreach (Meal meal in meals)
            {
                await mealController.deleteMeal(meal);
            }

            await db.remove($"DELETE FROM diets WHERE id = '{diet.id}'");

            db.Close();
        }

    }
}
