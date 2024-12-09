using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.Forms.MealForms;
using HealthyLife_Pt2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms.MainPanelForms
{
    public partial class DietForm : Form
    {
        User user;

        List<Diet> diets = new List<Diet>();
        List<DietButton> dietButtons = new List<DietButton>();
        Point startPoint = new Point(45, 110);
        int stepX = 260;
        int stepY = 320;

        public DietForm(User user)
        {
            this.user = user;

            InitializeComponent();
            fillForm();
            
            dietCreationButton.Text = "Создать рацион";
            
        }

        public async void fillForm()
        {
            DietController dietController = new DietController();
            diets = await dietController.select("SELECT * FROM diets");
            dietCreationButton.Enabled = true;

            int n = diets.Count / 3 ;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    if (index >= diets.Count)
                        return;
                    createDietButton(diets[i * 3 + j], new Point(startPoint.X + j * stepX, startPoint.Y + i * stepY));
                    //;
                }
            }


        }

        private void createDietButton(Diet diet, Point location)
        {
            DietButton dietButton = new DietButton(diet);
            dietButton.Location = location;
            dietButton.DietButtonMouseEnter += delegate (object? sender, EventArgs e)
            {
                if (sender != null)
                    ((DietButton)sender).PanelColor = Color.GreenYellow;
            };
            dietButton.DietButtonMouseLeave += delegate (object? sender, EventArgs e)
            {
                if (sender != null)
                    ((DietButton)sender).PanelColor = Color.Gainsboro;
            };
            dietButton.DietButtonClicked += delegate (object? sender, EventArgs e)
            {
                if (sender == null)
                {
                    MessageBox.Show("Что-то пошло не так(");
                    return;
                }
                DietDescriptionForm descriptionForm = new DietDescriptionForm(((DietButton)sender).diet);
                descriptionForm.ShowDialog();
            };

            dietButtons.Add(dietButton);
            dietButton.BringToFront();
            Controls.Add(dietButton);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.Coral;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.DarkViolet;
        }

        private void dietCreationButton_Click(object sender, EventArgs e)
        {
            DietCreationForm dietCreationForm = new DietCreationForm(user);
            dietCreationForm.Show();
            dietCreationForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                diets.Add(((DietCreationForm)sender).diet);
            };

        }
    }
}
