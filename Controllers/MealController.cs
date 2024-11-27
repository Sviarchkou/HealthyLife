using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Controllers
{
    public class MealController : DefaultController
    {
        public async Task<List<Meal>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);
            db.Close();
            List<Meal> meals = new List<Meal>();

            foreach (DataRow row in dataTable.Rows)
            {
                meals.Add(await createMeal(row));
            }

            return meals;
        }

        public async Task<Meal> findById(string? meal_id)
        {
            if (meal_id == null)
                throw new ArgumentNullException();

            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM meals WHERE id = '{meal_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Ingredient not found");
            }
            return await createMeal(dataTable.Rows[0]);
        }

        private async Task<Meal> createMeal(DataRow row)
        {
            Meal meal = new Meal();
            meal.id = (int)row[0];

            RecipeController recipeController = new RecipeController();
            if (!row[1].Equals(System.DBNull.Value))
                meal.breakfast = await recipeController.findById(row[1].ToString());
            if (!row[2].Equals(System.DBNull.Value))
                meal.lunch = await recipeController.findById(row[2].ToString());
            if (!row[3].Equals(System.DBNull.Value))
                meal.dinner = await recipeController.findById(row[3].ToString());

            ElementController elementController = new ElementController();
            meal.element = await elementController.findById(row[4].ToString());

            ProductController productController = new ProductController();
            meal.extraFood = await productController.selectFromExtraFood(meal.id.ToString());

            return meal;
        }

        public async Task<int> insertMeal(Meal meal)
        {
            if (meal == null)
                throw new ArgumentNullException();
            if (meal.element == null)
                throw new ArgumentNullException("Elements is not added");

            ElementController elementController = new ElementController();
            int element_id = await elementController.insertElement(meal.element);

            StringBuilder header = new StringBuilder("INSERT INTO meals (element_id");
            StringBuilder values = new StringBuilder($"VALUES ({element_id}");

            if (meal.breakfast != null)
            {
                header.Append(", breakfast_id");
                values.Append($", {meal.breakfast.id}");

            }
            if (meal.lunch != null)
            {
                header.Append(", lunch_id");
                values.Append($", {meal.lunch.id}");
            }
            if (meal.dinner != null)
            {
                header.Append(", dinner_id");
                values.Append($", {meal.dinner.id}");
            }


            header.Append(") ");
            values.Append(") RETURNING id;");

            DBConnector db = new DBConnector();
            db.Open();
            int meal_id = await db.insert(header.Append(values).ToString());
            db.Close();

            meal.id = meal_id;

            if (meal.extraFood.Count == 0)
                return meal_id;

            header.Clear();
            values.Clear();

            header.Append("INSERT INTO extra_food (product_id, meal_id) VALUES ");

            bool b = false;
            foreach (Product product in meal.extraFood)
            {
                if (b)
                    values.Append(", ");
                b = true;
                values.Append($"({product.id}, {meal_id})");
            }
            values.Append(";");

            db.Open();
            await db.insert(header.Append(values).ToString());
            db.Close();

            return meal_id;
        }

        public void updateElement(Meal meal)
        {
            if (meal.element == null) return;

            ElementController elementController = new ElementController();
            elementController.clearElement(meal.element);

            if (meal.breakfast != null)
                meal.element = elementController.sumElements(meal.element, meal.breakfast.element);
            if (meal.lunch != null)
                meal.element = elementController.sumElements(meal.element, meal.lunch.element);
            if (meal.dinner != null)
                meal.element = elementController.sumElements(meal.element, meal.dinner.element);

            foreach (Product product in meal.extraFood)
            {
                meal.element = elementController.sumElements(product.element, meal.element);
            }
        }

        public async Task<List<Meal>> selectFromDietHasMeals(string diet_id)
        {

            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM diet_has_meals WHERE diet_id = '{diet_id}'");
            db.Close();

            List<Meal> meals = new List<Meal>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                List<Meal> mls = await select($"SELECT * FROM meals WHERE id = '{dataRow[0]}'");
                foreach (Meal m in mls)
                    meals.Add(m);
            }

            return meals;
        }
    }
}
