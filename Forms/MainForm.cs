using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.Forms.MainPanelForms;
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
        DietForm dietForm;
        RecipeForm recipeForm;

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
            ((Button)sender).BackColor = Color.Coral;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DarkViolet;
        }

        private void counterButton_Click(object sender, EventArgs e)
        {
            if (dailyCounter == null)
                dailyCounter = new DailyCounter(user);
            setForm(dailyCounter);
            //((Button)sender).MouseLeave -= button_MouseLeave;

        }

        private void dietMenuButton_Click(object sender, EventArgs e)
        {
            if (dietForm == null)
                dietForm = new DietForm(user);
            setForm(dietForm);
            //((Button)sender).MouseLeave -= button_MouseLeave;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (recipeForm == null)
                recipeForm = new RecipeForm(user);
            setForm(recipeForm);
        }
    }
}
