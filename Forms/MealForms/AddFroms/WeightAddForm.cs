using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms.MealForms.AddFroms
{
    public partial class WeightAddForm : Form
    {

        public UserWeight userWeight { get; private set; } = new UserWeight();
        public bool updated { get; private set; } = false;
        public bool setted { get; private set; } = false;
        public WeightAddForm(User user)
        {
            InitializeComponent();            
            addButton.Text = "Добавить";

            userWeight.user = user;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(weightTextBox.Text, out double weight) || weight <= 30 || weight >= 300)
            {
                MessageBox.Show("Неверное значение вес");
                return;
            }
            if (dateTimePicker.Checked != true)
            {
                MessageBox.Show("Дата не выбрана либо выбрана некорректно");
                return;
            }

            userWeight.updated_at = dateTimePicker.Value;
            userWeight.weight = weight;

            UserWeightController userWeightController = new UserWeightController();
            if (await userWeightController.alreadyExist(userWeight))
            {
                await userWeightController.updateUserWeight(userWeight);
                updated = true;
            }
            else
            {
                await userWeightController.insertUserWeight(userWeight);
            }

            setted = true;
            MessageBox.Show("Запись добавлена");

            this.Close();
        }
    }
}
