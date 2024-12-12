using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.Forms.MainPanelForms;
using HealthyLife_Pt2.Forms.MainPanelForms.ProfileForms;
using HealthyLife_Pt2.Forms.MealForms;
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

namespace HealthyLife_Pt2.Forms
{
    public partial class MainForm : Form
    {
        User user;

        DailyCounter dailyCounter;        

        Button currentButton = new Button();
        Color activeColor = Color.DarkViolet;
        Color defautltColor = Color.FromArgb(43, 31, 46);
        Color tempColor = Color.FromArgb(43, 31, 46);

        public MainForm(User user)
        {
            InitializeComponent();

            this.user = user;
            //dailyCounter = new DailyCounter(user);            
            //

            /*
            Form childForm = new DailyCounter(user);
            childForm.TopLevel = false;
            panel2.Controls.Add(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            */
        }
        private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dailyCounter != null)
                await dailyCounter.loadData();
            Application.Exit();
        }

        private void setForm(Form childForm)
        {
            childForm.TopLevel = false;
            formPanel.Controls.Add(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            tempColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = Color.Coral;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = tempColor;
        }

        private void setCurrentButton(Button button)
        {
            currentButton.BackColor = defautltColor;
            currentButton = button;
            currentButton.BackColor = activeColor;
            tempColor = activeColor;
        }

        private void counterButton_Click(object sender, EventArgs e)
        {
            setCurrentButton((Button)sender);
            dailyCounter = new DailyCounter(user);
            setForm(dailyCounter);

        }

        private void dietMenuButton_Click(object sender, EventArgs e)
        {
            setCurrentButton((Button)sender);
            DietForm dietForm = new DietForm(user);
            setForm(dietForm);
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            setCurrentButton((Button)sender);
            RecipeForm recipeForm = new RecipeForm(user);
            setForm(recipeForm);
        }

        private void userWeightButton_Click(object sender, EventArgs e)
        {
            setCurrentButton((Button)sender);
            UserWeightForm userWeightForm = new UserWeightForm(user);
            setForm(userWeightForm);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            setCurrentButton((Button)sender);
            Profile profile = new Profile(user);
            setForm(profile);
        }
    }
}
