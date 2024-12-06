using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms.MealForms.DescriptionForms
{
    public partial class RecipeDescriptionForm : Form
    {
        Recipe recipe;

        Point startPoint = new Point(30, 370);
        int stepX = 360;
        int stepY = 100;
        
        public RecipeDescriptionForm(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            fillControl();

            toolTip.SetToolTip(this.vitaminsInfo, vitaminsInfo.Text);
            toolTip.SetToolTip(this.mineralsInfo, mineralsInfo.Text);
        }

        private void fillControl()
        {
            if (recipe.photo != null && recipe.photo != "")
                pictureBox1.Image = MyImageConverter.converFromStringBytes(recipe.photo);

            nameLabel.Text = recipe.name;
            
            caloriesCounter.Text = recipe.element.calories.ToString();
            proteinCounter.Text = recipe.element.proteins.ToString();
            fatsCounter.Text = recipe.element.fats.ToString();
            carboCounter.Text = recipe.element.carbohydrates.ToString();
            if (recipe.element.minerals == null || recipe.element.minerals == "")
                mineralsInfo.Text = "* Нет *";
            else
                mineralsInfo.Text = recipe.element.minerals.ToString();

            if (recipe.element.vitamins == null || recipe.element.vitamins == "")
                vitaminsInfo.Text = "* Нет *";
            else
                vitaminsInfo.Text = recipe.element.vitamins.ToString();

            int i = 0;
            for (; i < recipe.ingredients.Count; i++)
            {
                if (i % 2 == 0)
                    createProductButton(recipe.ingredients[i], new Point(startPoint.X , startPoint.Y + stepY * (i / 2)));
                else
                    createProductButton(recipe.ingredients[i], new Point(startPoint.X + stepX, startPoint.Y + stepY * (i / 2)));
            }

            description.Location = new Point(description.Location.X, startPoint.Y + stepY * i / 2 + 30);

            if (recipe.description != "")
                description.Text = recipe.description;
            else
                description.Text = "Для этого рецепта не нашлось описания (";


        }

        private void createProductButton(Ingredient ingredient, Point location)
        {
            ProductButton productButton = new ProductButton(ingredient.product);
            productButton.Location = location;
            productButton.changeCategoryLabel(ingredient.weight.ToString() + "г.");
            Controls.Add(productButton);

        }

    }
}
