using HealthyLife_Pt2.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Controllers
{
    public abstract class DefaultController
    {
        public static string doubleToDbString(double x)
        {
            string str = x.ToString();
            string[] data = str.Split(",");
            return data.Length > 1 ? data[0] + "." + data[1] : data[0];
        }

        public async Task update(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            await db.update(str);
            db.Close();
        }
        public async Task remove(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            await db.remove(str);
            db.Close();
        }
        public async Task<int> insert(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            int n = await db.insert(str);
            db.Close();
            return n;
        }
    }
}
