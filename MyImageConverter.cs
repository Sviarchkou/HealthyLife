using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLIfe_Pt2
{
    public class MyImageConverter
    {
        public static string chooseImage(out Image? image)
        {
            
            StringBuilder sb = new StringBuilder();
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image files (*.jpeg, *.png, *.jpg) | *.jpeg; *.png; *.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image = Image.FromFile(dialog.FileName);
                    byte[] image_bytes = File.ReadAllBytes(dialog.FileName);

                    foreach (byte b in image_bytes)
                    {
                        sb.Append(b + ",");
                    }
                }
                else
                    image = null;
            }
    
            return sb.ToString();
        }

        public static Image? converFromStringBytes(string str)
        {
            string[] str_bytes = str.Split(","); ;
            byte[] ba = new byte[str_bytes.Length - 1];
            for (int i = 0; i < str_bytes.Length - 1; i++)
            {
                Byte.TryParse(str_bytes[i], out ba[i]);
            }
            MemoryStream memoryStream = new MemoryStream(ba);
            Image image;
            try
            {
                image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {
                image = null;
            }
            return image;
        }
    }
}
