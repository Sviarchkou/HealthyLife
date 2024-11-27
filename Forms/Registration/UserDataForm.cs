using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms.Registrarion
{
    public partial class UserDataForm : Form
    {
        private const string cacheFileName = "userDataRegistrarion.txt";

        bool weightChanged = false;
        bool heightChanged = false;
        bool dateChanged = false;
        public UserDataForm()
        {

            InitializeComponent();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            loadData();
        }

        private async void loadData()
        {
            try
            {
                string str = await CacheWorker.readData(cacheFileName);
                string[] data = str.Split("\n");
                switch (data[0])
                {
                    case "1":
                        radioButton1.Checked = true;
                        break;
                    case "2":
                        radioButton2.Checked = true;
                        break;
                    case "3":
                        radioButton3.Checked = true;
                        break;
                }
                if (data[1] != "")
                {
                    weight.Text = data[1];
                    weight.ForeColor = Color.Black;
                    weightChanged = true;
                }
                if (data[2] != "")
                {
                    height.Text = data[2];
                    height.ForeColor = Color.Black;
                    heightChanged = true;
                }
                if (data[3] != "")
                {
                    dateOfBirth.Text = data[3];
                    dateOfBirth.ForeColor = Color.Black;
                    dateChanged = true;
                }

            }
            catch (Exception ex) { }
        }

        private void back_Click(object sender, EventArgs e)
        {
            wirteCache();
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void weight_Click(object sender, EventArgs e)
        {
            weight.Text = "";
            weight.ForeColor = Color.Black;
            weight.Click -= weight_Click;
            weightChanged = true;
        }

        private void height_Click(object sender, EventArgs e)
        {
            height.Text = "";
            height.ForeColor = Color.Black;
            height.Click -= height_Click;
            heightChanged = true;
        }
        private void dateOfBirth_Click(object sender, EventArgs e)
        {
            dateOfBirth.Text = "";
            dateOfBirth.ForeColor = Color.Black;
            dateOfBirth.Click -= dateOfBirth_Click;
            dateChanged = true;
        }

        private void next_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (!Double.TryParse(weight.Text, out double result) || result < 20 || result > 300)
            {
                MessageBox.Show("Недопустимые значения веса");
                b = true;
            }
            if (!Int32.TryParse(height.Text, out int result2) || result2 < 50 || result2 > 260)
            {
                MessageBox.Show("Недопустимые значения роста");
                b = true;
            }
            if (!DateOnly.TryParse(dateOfBirth.Text, out DateOnly result3) || result3.Year < 1925 || result3.Year > 2025)
            {
                MessageBox.Show("Недопустимые значения даты рождения");
                b = true;
            }
            if (b) return;

            ActivityLevelForm activityLevel = new ActivityLevelForm();
            activityLevel.Show();

            wirteCache();
            this.Close();
            //////////////////////

        }

        private async void wirteCache()
        {
            StringBuilder sb = new StringBuilder();

            if (radioButton1.Checked == true)
                sb.Append("1\n");
            else if (radioButton2.Checked == true)
                sb.Append("2\n");
            else if (radioButton3.Checked == true)
                sb.Append("3\n");

            if (weightChanged)
                sb.Append(weight.Text);
        
            sb.Append("\n");

            if (heightChanged)
               sb.Append(height.Text);
            
            sb.Append("\n");

            if (dateChanged)
                sb.Append(dateOfBirth.Text);
            sb.Append("\n");
            await Task.Run(() => CacheWorker.writeData(cacheFileName, sb.ToString()));
        }


    }
}
