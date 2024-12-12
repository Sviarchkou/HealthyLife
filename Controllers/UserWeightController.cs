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
    internal class UserWeightController : DefaultController
    {

        public async Task<List<UserWeight>> select(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_weight WHERE user_id = '{user.id}'");

            List<UserWeight> userWeights = new List<UserWeight>();

            foreach (DataRow row in dataTable.Rows)
            {
                userWeights.Add(await createUserWeight(row));                
            }

            db.Close();
            return userWeights;
        }

        public async Task<bool> alreadyExist(UserWeight userWeight)
        {
            DBConnector db = new DBConnector();
            db.Open();
            string date = $"{userWeight.updated_at.Year}-{userWeight.updated_at.Month}-{userWeight.updated_at.Day}";
            DataTable dataTable = await db.select($"SELECT * FROM user_weight WHERE user_id = '{userWeight.user.id}' and updated_at = '{date}'");
            db.Close();

            if (dataTable.Rows.Count == 0)
                return false;
            userWeight.id = (int)dataTable.Rows[0][0];
            return true;
        }

        public async Task<UserWeight> findToday(string user_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            DataTable dataTable = await db.select($"SELECT * FROM user_weight WHERE user_id = '{user_id}' and updated_at = '{date}'");
            db.Close();

            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("User Weight not found"); ;
            }
            return await createUserWeight(dataTable.Rows[0]);
        }

        public async Task<UserWeight> findById(string user_weight_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_weight WHERE id = '{user_weight_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("User Weight not found"); ;
            }
            return await createUserWeight(dataTable.Rows[0]);
        }

        private async Task<UserWeight> createUserWeight(DataRow row)
        {

            UserWeight userWeights = new UserWeight();

            userWeights.id = (int)row[0];

            UserController userController = new UserController();
            userWeights.user = await userController.findById(row[1].ToString());

            userWeights.updated_at = (DateTime)row[2];            
            
            userWeights.weight = (float)row[3];
            userWeights.goal = (float)row[4];
            
            return userWeights;
        }


        public async Task<UserWeight> insertUserWeight(UserWeight userWeight)
        {
            string date = $"{userWeight.updated_at.Year}-{userWeight.updated_at.Month}-{userWeight.updated_at.Day}";

            StringBuilder commandHeader = new StringBuilder("INSERT INTO user_weight (user_id, updated_at, weight, goal) ");
            StringBuilder values = new StringBuilder($"VALUES (" +
                $"'{userWeight.user.id.ToString()}', " +
                $"'{date}', " +
                $"{doubleToDbString(userWeight.weight)}," +
                $"{doubleToDbString(userWeight.goal)}) RETURNING id;");

            DBConnector db = new DBConnector();
            db.Open();
            userWeight.id = await db.insert(commandHeader.Append(values).ToString());
            db.Close();
            return userWeight;
        }

        public async Task<UserWeight> insertTodayUserWeight(UserWeight userWeight)
        {
            userWeight.updated_at = DateTime.Now;
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";

            StringBuilder commandHeader = new StringBuilder("INSERT INTO user_weight (user_id, updated_at, weight, goal) ");
            StringBuilder values = new StringBuilder($"VALUES (" +
                $"'{userWeight.user.id.ToString()}', " +
                $"'{date}', " +
                $"{doubleToDbString(userWeight.weight)}," +
                $"{doubleToDbString(userWeight.goal)}) RETURNING id;");

            DBConnector db = new DBConnector();
            db.Open();
            userWeight.id = await db.insert(commandHeader.Append(values).ToString());
            db.Close();
            return userWeight;
        }

        public async Task updateUserWeight(UserWeight userWeight)
        { 
            string date = $"{userWeight.updated_at.Year}-{userWeight.updated_at.Month}-{userWeight.updated_at.Day}";

            StringBuilder command = new StringBuilder("UPDATE user_weight " +
                $"SET goal = {doubleToDbString(userWeight.goal)}, " +
                $"weight = {doubleToDbString(userWeight.weight)} " +
                $"WHERE id = {userWeight.id}");

            DBConnector db = new DBConnector();
            db.Open();
            await db.update(command.ToString());
            db.Close();
        }


    }
}
