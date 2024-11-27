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
    public class DailyMealController : DefaultController
    {

        public async Task<List<DailyMeal>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);
            db.Close();

            List<DailyMeal> dailyMeal = new List<DailyMeal>();

            foreach (DataRow row in dataTable.Rows)
            {
                dailyMeal.Add(await createDailyMeal(row));
            }

            return dailyMeal;
        }

        public async Task<DailyMeal> findToday(string user_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            DataTable dataTable = await db.select($"SELECT * FROM user_daily_meal WHERE user_id = '{user_id}' and updated_at = '{date}'");
            db.Close();

            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Daily Element not found"); ;
            }
            return await createDailyMeal(dataTable.Rows[0]);
        }

        public async Task<DailyMeal> findById(string? user_id)
        {
            if (user_id == null)
                throw new ArgumentNullException();
            
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_daily_meal WHERE id = '{user_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Product not found");
            }
            return await createDailyMeal(dataTable.Rows[0]);
        }

        private async Task<DailyMeal> createDailyMeal(DataRow row)
        {
            DailyMeal dailyMeal = new DailyMeal();

            dailyMeal.id = (int)row[0];
            
            UserController userController = new UserController();
            dailyMeal.user = await userController.findById(row[1].ToString());

            MealController mealController = new MealController();
            dailyMeal.meal = await mealController.findById(row[2].ToString());


            DateTime dateTime = (DateTime)row[3];
            dailyMeal.update_at = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);

            return dailyMeal;
        }

        public async Task<int> insertDailyMeal(DailyMeal dailyMeal)
        {
            string date = dailyMeal.update_at.Year + "-" + dailyMeal.update_at.Month + "-" + dailyMeal.update_at.Day;

            DBConnector db = new DBConnector();
            db.Open();
            dailyMeal.id = await db.insert($"INSERT INTO user_daily_meal (user_id, meal_id, updated_at) " +
                $"VALUES ('{dailyMeal.user.id}', {dailyMeal.meal.id}, '{date}')");
            db.Close();

            return dailyMeal.id;
        }
        public async Task<DailyMeal> insertTodayDailyMeal(User user, Meal meal)
        {
            DailyMeal dailyMeal = new DailyMeal();
            dailyMeal.user = user;
            dailyMeal.meal = meal;
            dailyMeal.update_at = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";

            DBConnector db = new DBConnector();
            db.Open();
            dailyMeal.id = await db.insert($"INSERT INTO user_daily_meal (user_id, meal_id, updated_at) " +
                $"VALUES ('{dailyMeal.user.id}', {dailyMeal.meal.id}, '{date}')");
            db.Close();

            return dailyMeal;
        }
    }
}
