using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Controllers
{
    public class ElementController : DefaultController
    {
        public async Task<List<Element>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);

            List<Element> elements = new List<Element>();

            foreach (DataRow row in dataTable.Rows)
            {
                elements.Add(createElement(row));
            }

            db.Close();
            return elements;
        }
        public async Task<Element> findById(string? meal_id)
        {
            if (meal_id == null) throw new ArgumentNullException();
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM elements WHERE id = '{meal_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
                throw new Exception("Element not found");

            return createElement(dataTable.Rows[0]);
        }
        private Element createElement(DataRow row)
        {
            Element element = new Element();
            element.id = (int)row[0];
            element.calories = (int)row[1];
            element.proteins = (float)row[2];
            element.fats = (float)row[3];
            element.carbohydrates = (float)row[4];
            if (!row[5].Equals(System.DBNull.Value))
                element.minerals = (string)row[5];
            
            if (!row[6].Equals(System.DBNull.Value))
                element.vitamins = (string)row[6];

            return element;
        }
        public async Task<int> insertElement(Element element)
        {
            
            StringBuilder commandHeader = new StringBuilder("INSERT INTO elements (calories, proteins, fats, carbohydrates");
            StringBuilder values = new StringBuilder($"VALUES ({element.calories}, {doubleToDbString(element.proteins)}, {doubleToDbString(element.fats)}, {doubleToDbString(element.carbohydrates)}");

            if (element.minerals != null && element.minerals != "")
            {
                commandHeader.Append(", minerals");
                values.Append($", '{element.minerals}'");
            }

            if (element.vitamins != null && element.vitamins != "")
            {
                commandHeader.Append(", vitamins");
                values.Append($", '{element.vitamins}'");
            }

            commandHeader.Append(")");
            values.Append($") RETURNING id;");
            
            DBConnector db = new DBConnector();
            db.Open();
            int n = await db.insert(commandHeader.Append(values).ToString());
            db.Close();
            return n;
        }

        public void clearElement(Element element)
        {
            if (element == null)
                throw new ArgumentNullException();
                
            element.calories = 0;
            element.proteins = 0;
            element.fats = 0;
            element.carbohydrates = 0;
            element.minerals = "";
            element.vitamins = "";
        }

        public Element sumElements(Element e1, Element e2)
        {
            Element element = new Element();
            element.calories = e1.calories + e2.calories;
            element.proteins = e1.proteins + e2.proteins;
            element.fats = e1.fats + e2.fats;
            element.carbohydrates = e1.carbohydrates + e2.carbohydrates;

            element.minerals = e1.minerals + ", " + e2.minerals;
            element.vitamins = e1.vitamins + ", " + e2.vitamins;
            return element;
        }
    }
}
