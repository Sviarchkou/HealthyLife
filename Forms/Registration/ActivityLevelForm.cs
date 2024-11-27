using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Forms.Registrarion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Controllers
{
    public partial class ActivityLevelForm : Form
    {
        private const string cacheFileName = "activityLevelReg.txt";
        public ActivityLevelForm()
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
                switch (str[0])
                {
                    case '1':
                        radioButton1.Checked = true;
                        break;
                    case '2':
                        radioButton2.Checked = true;
                        break;
                    case '3':
                        radioButton3.Checked = true;
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void back_Click(object sender, EventArgs e)
        {
            wirteCache();
            UserDataForm userData = new UserDataForm();
            ;
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            wirteCache();
            GoalForm goal = new GoalForm();
            goal.Show();
            this.Close();
        }

        private async void wirteCache()
        {
            StringBuilder sb = new StringBuilder();

            if (radioButton1.Checked == true)
                sb.Append("1");
            else if (radioButton2.Checked == true)
                sb.Append("2");
            else if (radioButton3.Checked == true)
                sb.Append("3");

            await Task.Run(() => CacheWorker.writeData(cacheFileName, sb.ToString()));
        }

    }
}
