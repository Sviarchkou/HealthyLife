using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Models;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;


namespace HealthyLife_Pt2.Forms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            WellcomeScrin scrin = new WellcomeScrin();
            scrin.Show();
        }

        private async void authorize_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            User? user = await userController.findByUsername(login.Text);

            if (user == null)
            {
                MessageBox.Show("Неверный логин");
                return;
            }

            string pass = Convert.ToHexString(SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password.Text)));
            
            if (user.password.Contains(pass))
            {
                MessageBox.Show("Вы вошли");
            }
            else
            {
                MessageBox.Show("Неверный пороль");
                return;
            }

            MainForm f = new MainForm(user);
            f.Show();
            /*
            MainMenu mainMenu = new MainMenu(user);
            mainMenu.Show();
            */
            this.Close();
        }
    }
}
