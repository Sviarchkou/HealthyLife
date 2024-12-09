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
    public class ExtraFoodController
    {
        public async Task<List<ExtraFood>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);

            List<ExtraFood> extraFoods = new List<ExtraFood>();

            foreach (DataRow row in dataTable.Rows)
            {
                extraFoods.Add(await createExtraFood(row));
            }

            db.Close();
            return extraFoods;
        }

        public async Task<List<ExtraFood>> selectByMealId(string meal_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM extra_food WHERE meal_id = '{meal_id}'");

            List<ExtraFood> extraFoods = new List<ExtraFood>();

            foreach (DataRow row in dataTable.Rows)
            {
                extraFoods.Add(await createExtraFood(row));
            }

            db.Close();
            return extraFoods;
        }

        public async Task updateByMeal(Meal meal)
        {
            DBConnector db = new DBConnector();
            db.Open();
            await db.remove($"DELETE FROM extra_food WHERE meal_id = '{meal.id}'");
            db.Close();

            ExtraFoodController extraFoodController = new ExtraFoodController();
            foreach (ExtraFood extraFood in meal.extraFood)
            {
                await extraFoodController.insertExtraFood(extraFood);
            }            
        }

        public async Task<ExtraFood> findByProductMealId(string product_id, string meal_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM extra_food WHERE product_id = '{product_id}' and mael_id = '{meal_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("ExtraFood not found");
            }
            return await createExtraFood(dataTable.Rows[0]);
        }

        private async Task<ExtraFood> createExtraFood(DataRow row)
        {
            ExtraFood extraFood = new ExtraFood();


            ProductController productController = new ProductController();
            extraFood.product = await productController.findById(row[0].ToString());

            //MealController mealController = new MealController();
            //extraFood.meal = await mealController.findById(row[1].ToString());

            extraFood.weight = (int)row[2];

            return extraFood;
        }

        public async Task<int> insertExtraFood(ExtraFood extraFood)
        {
            if (extraFood == null)
                throw new ArgumentNullException();
            if (extraFood.product == null)
                throw new ArgumentException("Product in not added");
            if (extraFood.meal == null)
                throw new ArgumentException("Meal in not added");

            string str = $"INSERT INTO extra_food (weight, product_id, meal_id) " +
                $"VALUES ({extraFood.weight}, {extraFood.product.id}, {extraFood.meal.id})";

            DBConnector db = new DBConnector();
            db.Open();
            await db.insert(str);
            db.Close();

            return 0;
        }

    }
}
