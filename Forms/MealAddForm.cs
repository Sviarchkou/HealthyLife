using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms
{
    public partial class MealAddForm : Form
    {
        private List<Recipe> recipes = new List<Recipe>();
        private Point recipeStartPoint = new Point(47, 107);
        private Point plusStartPoint = new Point(440, 130);
        private int step = 110;

        List<RecipeButton> recipeButtons = new List<RecipeButton>();
        List<MyPanel> myPanels = new List<MyPanel>();

        public Recipe? recipe { get; private set; }

        public MealAddForm()
        {
            InitializeComponent();
            createButton.Text = "Создать блюдо";

            fillForm();
        }


        private async void fillForm()
        {

            RecipeController recipeController = new RecipeController();
            recipes = await recipeController.select("SELECT * FROM recipes");

            for (int i = 0; i < recipes.Count; i++)
            {
                RecipeButton recipeButton = new RecipeButton(recipes[i]);
                recipeButton.Location = new Point(recipeStartPoint.X, recipeStartPoint.Y + i * step);
                recipeButtons.Add(recipeButton);

                MyPanel myPanel = new MyPanel();
                myPanel.BackColor = Color.Gainsboro;
                myPanel.BorderColor = Color.Transparent;
                myPanel.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
                myPanel.ForeColor = Color.DarkViolet;
                myPanel.Text = "+";
                myPanel.Location = new Point(plusStartPoint.X, plusStartPoint.Y + i * step);
                myPanel.PanelColor = Color.LavenderBlush;
                myPanel.Rad = 60;
                myPanel.Size = new Size(60, 60);
                myPanels.Add(myPanel);
                myPanel.MouseEnter += myPanel_MouseEnter;
                myPanel.MouseLeave += myPanel_MouseLeave;
                myPanel.Click += myPanel_Click;

                Controls.Add(recipeButton);
                Controls.Add(myPanel);
                myPanel.BringToFront();
            }
        }

        private void myPanel_MouseEnter(object? sender, EventArgs e)
        {
            if (sender == null)
                return;
            ((MyPanel)sender).PanelColor = Color.White;
        }
        private void myPanel_MouseLeave(object? sender, EventArgs e)
        {
            if (sender == null)
                return;
            ((MyPanel)sender).PanelColor = Color.LavenderBlush;
        }

        private void myPanel_Click(object? sender, EventArgs e)
        {
            if (sender == null)
                return;
            int i = myPanels.IndexOf((MyPanel)sender);
            recipe = recipes[i];
            recipeButtons[i].BackColor = Color.YellowGreen;
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            RecipeCreationForm recipeCreationForm = new RecipeCreationForm();
            recipeCreationForm.Show();

        }
    }
}
