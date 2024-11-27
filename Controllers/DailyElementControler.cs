using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using User = HealthyLife_Pt2.Models.User;

namespace HealthyLife_Pt2.Controllers
{
    public class DailyElementControler : DefaultController
    {

        public async Task<List<DailyElement>> select(User user)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_daily_elements WHERE user_id = {user.id}");

            List<DailyElement> dailyElements = new List<DailyElement>();

            foreach (DataRow row in dataTable.Rows)
            {
                DailyElement dailyElement = new DailyElement();

                dailyElement.id = (int)row[0];
                dailyElement.user = user;

                ElementController elementController = new ElementController();
                dailyElement.element = await elementController.findById((string)row[2]);
                
                dailyElement.date = DateOnly.Parse((string)row[3]);

                dailyElements.Add(dailyElement);
            }

            db.Close();
            return dailyElements;
        }

        public async Task<DailyElement> findToday(string user_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            DataTable dataTable = await db.select($"SELECT * FROM user_daily_elements WHERE user_id = '{user_id}' and updated_at = '{date}'");
            db.Close();

            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Daily Element not found"); ;
            }
            return await createDailyElement(dataTable.Rows[0]);
        }

        public async Task<DailyElement> findById(string daily_elements_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_daily_elements WHERE id = '{daily_elements_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Daily Element not found"); ;
            }
            return await createDailyElement(dataTable.Rows[0]);
        }
        private async Task<DailyElement> createDailyElement(DataRow row)
        {

            DailyElement dailyElement = new DailyElement();
            
            dailyElement.id = (int)row[0];
           
            UserController userController = new UserController();
            dailyElement.user = await userController.findById(row[1].ToString());

            ElementController elementController = new ElementController();
            dailyElement.element = await elementController.findById(row[2].ToString());

            DateTime dateTime = (DateTime)row[3];
            dailyElement.date = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);

            return dailyElement;
        }
        
        
        public async Task<DailyElement> insertDailyElement(User user, Element element)
        {
            
            DailyElement dailyElement = new DailyElement();
            dailyElement.user = user;
            dailyElement.element = element;
            dailyElement.date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            
            StringBuilder commandHeader = new StringBuilder("INSERT INTO user_daily_elements (user_id, element_id, updated_at) ");
            StringBuilder values = new StringBuilder($"VALUES ('{user.id.ToString()}', {element.id}, '{date}') RETURNING id;");

            DBConnector db = new DBConnector();
            db.Open();
            dailyElement.id = await db.insert(commandHeader.Append(values).ToString());
            db.Close();
            return dailyElement;
        }

        
    }
}
