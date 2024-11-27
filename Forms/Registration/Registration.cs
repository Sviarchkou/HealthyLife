using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Forms.Registrarion;
using HealthyLife_Pt2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HealthyLife_Pt2.Forms
{
    public partial class Registration : Form
    {

        private const string cacheFileName = "userInfo.txt";
        public Registration()
        {
            InitializeComponent();
            
            loadData();
        }

        private async void loadData()
        {
            try
            {
                string str = await CacheWorker.readData(cacheFileName);
                string[] data = str.Split("\n");

                if (data[0] != "")
                {
                    login.Text = data[0];
                    login.ForeColor = Color.Black;
                }

            }
            catch (Exception ex) { }
        }

        private void login_Click(object sender, EventArgs e)
        {
            login.Text = "";
            login.ForeColor = Color.Black;
            login.Click -= login_Click;
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Text = "";
            password.PasswordChar = '*';
            password.ForeColor = Color.Black;
            password.Click -= password_Click;
        }

        private void passwordReplicaioin_Click(object sender, EventArgs e)
        {
            passwordReplication.Text = "";
            passwordReplication.PasswordChar = '*';
            passwordReplication.ForeColor = Color.Black;
            passwordReplication.Click -= passwordReplicaioin_Click;

        }

        private async void register_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            if (await userController.findByUsername(login.Text) != null)
            {
                MessageBox.Show("Такой логин уже существует");
                return;
            }
            if (password.Text != passwordReplication.Text)
            {
                MessageBox.Show("Пороли не соответствуют друг другу");
                return;
            }
            if (password.Text.Length < 4)
            {
                MessageBox.Show("Слишком короткий пороль, его будет слишко легко подобрать");
                return;
            }

            writeCache();
            UserDataForm userData = new UserDataForm();
            userData.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            WellcomeScrin scrin = new WellcomeScrin();
            
            CacheWorker.dropCache();
            scrin.Show();
        }

        private async void writeCache()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(login.Text);
            sb.Append("\n");
            sb.Append(Convert.ToHexString(SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password.Text))));

            await Task.Run(() => CacheWorker.writeData(cacheFileName, sb.ToString()));
        }
    }

}
