using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Database
{
    public class CacheWorker
    {
        private static string folderPath = "HealthyLifeCache"; 

        public static async Task writeData(string filename, string data)
        {
            string[] strings = filename.Split("\\");
            StringBuilder directoryPath = new StringBuilder(folderPath);
            for (int i = 0; i < strings.Length - 1; i++)
            {
                directoryPath.Append("\\");
                directoryPath.Append(strings[i]);
            }

            if (!Directory.Exists(directoryPath.ToString()))
                Directory.CreateDirectory(directoryPath.ToString());
            
            using (StreamWriter st = File.CreateText(folderPath +"\\"+ filename))
            {
                await Task.Run(() => st.WriteLine(data));
            }
        }

        public static async Task<string> readData(string path)
        {
            string[] strings = path.Split("\\");
            string filename = strings[strings.Length - 1];

            StringBuilder directoryPath = new StringBuilder(folderPath);
            for (int i = 0; i < strings.Length -1; i++)
            {
                directoryPath.Append("\\");
                directoryPath.Append(strings[i]);
            }

            if (!Directory.Exists(directoryPath.ToString())) { }
                Directory.CreateDirectory(directoryPath.ToString());

            bool b = false;            
            
            foreach (FileInfo fi in (new DirectoryInfo(directoryPath.ToString())).GetFiles())
            {
                if (fi.Name == filename)
                {
                    b = true;
                    break;
                }
            }
            if (!b)
                throw new Exception("No file");

            return await Task.Run(() => File.ReadAllText(folderPath + "\\" + path));
            
        }

        public static async void dropCache()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);

            await Task.Run(() =>
            {
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    dir.Delete(true);
                }
            });
        }
    }
}
