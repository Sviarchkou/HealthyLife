using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Database
{
    public class CacheWorker
    {
        private static string folderPath = "HealthyLifeCache"; 

        public static async Task writeData(string filename, string data)
        {
            using (StreamWriter st = File.CreateText(folderPath +"/"+ filename))
            {
                await Task.Run(() => st.WriteLine(data));
            }
        }

        public static async Task<string> readData(string filename)
        {
            bool b = false;            
            foreach (FileInfo fi in (new DirectoryInfo(folderPath)).GetFiles())
            {
                if (fi.Name == filename)
                {
                    b = true;
                    break;
                }
            }
            if (!b)
                throw new Exception("No derictory");

            return await Task.Run(() => File.ReadAllText(folderPath + "/" + filename));
            
        }

        public static async Task dropCache()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                await Task.Run(() => file.Delete());
            }
        }
    }
}
