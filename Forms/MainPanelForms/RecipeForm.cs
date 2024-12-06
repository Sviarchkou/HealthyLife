using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;

namespace HealthyLife_Pt2.Forms.MainPanelForms
{
    public partial class RecipeForm : Form
    {
        const string cachePath = "Recipes\\recipes";

        User user;
        List<Recipe> recipes = new List<Recipe>();
        IEnumerable<Recipe> filteredRecipes = new List<Recipe>();

        List<RecipeFormButton> recipeFormButtons = new List<RecipeFormButton>();
        Point startPoint = new Point(65, 110);
        int stepX = 360;
        int stepY = 360;


        public RecipeForm(User user)
        {
            InitializeComponent();

            this.user = user;

            recipeCreationButton.Text = "Создать рецепт";
            fillForm();

            searchPanel1.SearchTextChanged += delegate (object? sender, EventArgs e)
            {
                updateList();
            };

        }

        private async void fillForm()
        {
            string data = "";
            try
            {
                data = await CacheWorker.readData(cachePath);
            }
            catch (Exception ex) { }

            if (data == "")
            {
                RecipeController recipeController = new RecipeController();
                recipes = await recipeController.select("SELECT * FROM recipes");
            }
            else
            {
                List<Recipe>? temp = JsonSerializer.Deserialize<List<Recipe>>(data, new JsonSerializerOptions { WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve });
                if (temp == null)
                {
                    RecipeController recipeController = new RecipeController();
                    recipes = await recipeController.select("SELECT * FROM recipes");
                }
                else
                    recipes = temp;
            }

            
            for (int i = 0; i < recipes.Count; i++)
            {
                if (i % 2 == 0)
                {
                    createRecipeButton(recipes[i], new Point(startPoint.X, startPoint.Y + stepY * (i/2)));
                }
                else
                {
                    createRecipeButton(recipes[i], new Point(startPoint.X + stepX, startPoint.Y + stepY * (i / 2)));
                }
            }
        }

        private void filterRecipes()
        {
            string str = searchPanel1.SearhText;
            filteredRecipes = from r in recipes where r.name.ToLower().Contains(str.ToLower()) select r;
        }

        private async void updateList()
        {
            if (searchPanel1.SearhText == "")
                filteredRecipes = recipes;
            else
                await Task.Run(() => filterRecipes());

            for (int i = 0; i < recipeFormButtons.Count; i++)
            {
                Controls.Remove(recipeFormButtons[i]);
            }
            recipeFormButtons.Clear();

            for (int i = 0; i < filteredRecipes.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    createRecipeButton(filteredRecipes.ElementAt(i), new Point(startPoint.X, startPoint.Y + stepY * (i / 2)));
                }
                else
                {
                    createRecipeButton(filteredRecipes.ElementAt(i), new Point(startPoint.X + stepX, startPoint.Y + stepY * (i / 2)));
                }
            }
        }

        private void createRecipeButton(Recipe recipe, Point point)
        {
            RecipeFormButton recipeFormButton = new RecipeFormButton(recipe);
            recipeFormButton.Location = point;
            recipeFormButtons.Add(recipeFormButton);
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
            recipeFormButton.RecipeFormButtonClicked += delegate (object? sender, EventArgs e)
            {
                if (sender == null) return;
                RecipeDescriptionForm recipeDescriptionForm = new RecipeDescriptionForm(((RecipeFormButton)sender).recipe);
                recipeDescriptionForm.ShowDialog();
            };

            Controls.Add(recipeFormButton);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.Coral;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.DarkViolet;
        }

        private void recipeCreationButton_Click(object sender, EventArgs e)
        {
            RecipeCreationForm recipeCreationForm = new RecipeCreationForm();
            recipeCreationForm.Show();
            recipeCreationForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                recipes.Add(((RecipeCreationForm)sender).recipe);
            };
            
        }
    }
}
