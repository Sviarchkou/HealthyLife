using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.FormControls.MealControls.AdditionContols;
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

namespace HealthyLife_Pt2.Forms.MealForms.DescriptionForms
{
    public partial class DietDailyMealDescriptionForm : Form
    {
        User user;
        Meal meal;
        Recipe emptyRecipe = new Recipe();        

        Point startPoint = new Point(20,70);
        int stepRecipeX = 330;
        int stepY = 370;
        int stepExtraFoodX = 496;
        int stepExtraFoodY = 100;

        public string dayText
        {
            get => this.dayLabel.Text;
            set => this.dayLabel.Text = value;
        }

        public DietDailyMealDescriptionForm(Meal meal, User user)
        {
            InitializeComponent();

            this.user = user;
            this.meal = meal;

            emptyRecipe.name = "Нет рецепта для этого приёма пищи";
            
            fillForm();
        }

        private void fillForm()
        {

            createRecipeFormButton(meal.breakfast, startPoint);
            createRecipeFormButton(meal.lunch, new Point(startPoint.X + stepRecipeX, startPoint.Y));
            createRecipeFormButton(meal.dinner, new Point(startPoint.X + 2 * stepRecipeX, startPoint.Y));

            if (meal.extraFood.Count == 0)
            {
                extraFoodLabel.Text = "Перекусов нет";
                return;
            }

            for (int i = 0; i < meal.extraFood.Count;  i++)
            {
                if (i % 2 == 0)
                {
                    createExtraFoodButton(meal.extraFood[i], new Point(startPoint.X, startPoint.Y + stepY + stepExtraFoodY * (i / 2)));
                }
                else
                {
                    createExtraFoodButton(meal.extraFood[i], new Point(startPoint.X + stepExtraFoodX, startPoint.Y + stepY + stepExtraFoodY * (i / 2)));                    
                }
                
            }
        }

        private RecipeFormButton createRecipeFormButton(Recipe? recipe, Point location)
        {
            RecipeFormButton recipeFormButton;
            if (recipe == null)
            {
                recipeFormButton = new RecipeFormButton(emptyRecipe);

            }
            else
            {
                recipeFormButton = new RecipeFormButton(recipe);
                recipeFormButton.RecipeFormButtonClicked += delegate (object? sender, EventArgs e)
                {
                    if (sender == null) return;
                    RecipeDescriptionForm recipeDescriptionForm = new RecipeDescriptionForm(((RecipeFormButton)sender).recipe, user);
                    recipeDescriptionForm.deleteButton.Dispose();
                    recipeDescriptionForm.ShowDialog();
                };
            }                
            
            recipeFormButton.Location = location;
            
            Controls.Add(recipeFormButton);
            recipeFormButton.BringToFront();
            recipeFormButton.RecipeFormButtonMouseEnter += delegate (object? sender, EventArgs e)
            {
                if (sender == null) return;
                ((RecipeFormButton)sender).PanelColor = Color.YellowGreen;
            };
            recipeFormButton.RecipeFormButtonMouseLeave += delegate (object? sender, EventArgs e)
            {
                if (sender == null) return;
                ((RecipeFormButton)sender).PanelColor = Color.Gainsboro;
            };

            return recipeFormButton;
        }

        private void createExtraFoodButton(ExtraFood extraFood, Point location)
        {
            ExtraFoodAddition extraFoodAddition = new ExtraFoodAddition(extraFood.product, user);
            extraFoodAddition.onlyInfo = true;
            extraFoodAddition.weight = extraFood.weight;
            extraFoodAddition.Location = location;
            Controls.Add(extraFoodAddition);
        }

    }
}
