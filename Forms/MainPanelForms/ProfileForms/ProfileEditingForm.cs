using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Models;
using HealthyLife_Pt2.Properties;
using HealthyLIfe_Pt2;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HealthyLife_Pt2.Forms.MainPanelForms.Profile
{
    public partial class ProfileEditingForm : Form
    {
        User user;
        Image defaultImage = Resources.user;

        public ProfileEditingForm(User user)
        {
            InitializeComponent();
            this.user = user;

            dateTimePicker.MaxDate = DateTime.Now.Date;
            dateTimePicker.MinDate = DateTime.Now.Date.AddYears(-80);            
        }

        private void ProfileEditingForm_Load(object sender, EventArgs e)
        {
            
            loginTextBox.Text = user.username;
            weightTextBox.Text = (Double.Round(user.weight * 10) / 10).ToString();
            heightTextBox.Text = user.height.ToString();
            sexComboBox.SelectedItem = sexComboBox.Items[(int)user.sex];
            activityComboBox.SelectedItem = activityComboBox.Items[(int)user.activity];
            goalComboBox.SelectedItem = goalComboBox.Items[(int)user.goal];
            dateTimePicker.Value = user.dateOfBirth;

            if (user.photo == null || user.photo == "")
                return;
            try
            {
                pictureBox.Image = MyImageConverter.converFromStringBytes(user.photo);
            }
            catch (Exception ex) { pictureBox.Image = defaultImage; }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Image? image;
            try
            {
                user.photo = MyImageConverter.chooseImage(out image);

                if (image == null)
                {
                    image = defaultImage;
                    return;
                }                    

                pictureBox.Image = image;
            }
            catch (Exception ex) { MessageBox.Show("Не получилось добавить фото("); }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            bool loginChanged = false;
            if (user.username != loginTextBox.Text)
            {
                if (await userController.findByUsername(loginTextBox.Text) != null)
                {
                    MessageBox.Show("Такой логин уже существует");
                    return;
                }
                if (loginTextBox.Text.Length == 0)
                {
                    MessageBox.Show("логин не может быть путсым");
                    return;
                }
                if (loginTextBox.Text.Length > 20)
                {
                    MessageBox.Show("Слишком длинный логин");
                    return;
                }
                user.username = loginTextBox.Text;
                loginChanged = true;
            }
                        
            if (!Double.TryParse(weightTextBox.Text, out double weight) || weight <= 0 || weight > 300){
                MessageBox.Show("Неверный вес");
            }
            if (!Int32.TryParse(heightTextBox.Text, out int height) || height <= 50 || height > 260)
            {
                MessageBox.Show("Неверный вес");
            }
            user.weight = weight;
            user.height = height;

            switch (sexComboBox.SelectedIndex)
            {
                case 0:
                    user.sex = Sex.male;
                    break;
                case 1:
                    user.sex = Sex.female;
                    break;
                case 2:
                    user.sex = Sex.other;
                    break;
                default:
                    break;
            }

            switch (activityComboBox.SelectedIndex)
            {
                case 0:
                    user.activity = Activity.low;
                    break;
                case 1:
                    user.activity = Activity.medium;
                    break;
                case 2:
                    user.activity = Activity.high;
                    break;
                default:
                    break;
            }

            switch (goalComboBox.SelectedIndex)
            {
                case 0:
                    user.goal = Goal.loss;
                    break;
                case 1:
                    user.goal = Goal.maintenance;
                    break;
                case 2:
                    user.goal = Goal.gain;
                    break;
                default:
                    break;
            }

            user.dateOfBirth = dateTimePicker.Value;
            
            try
            {
                await userController.updateUser(user, loginChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования");
                return;
            }

            MessageBox.Show("Успешно отредактировано");
            this.Close();

        }
    }
}
