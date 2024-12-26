using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;
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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms
{
    public partial class MealAddForm : Form
    {
        const string cachePath = "Recipes\\recipes";

        private List<Recipe> recipes = new List<Recipe>();
        private IEnumerable<Recipe> filteredRecipes = new List<Recipe>();


        private Point recipeStartPoint = new Point(47, 107);
        private Point plusStartPoint = new Point(440, 130);
        private int step = 110;

        List<RecipeAddition> recipeButtons = new List<RecipeAddition>();
        List<MyPanel> myPanels = new List<MyPanel>();

        private SearchPanelFilterButtonList searchPanelFilterButtonList = new SearchPanelFilterButtonList(new Recipe());

        public Recipe? recipe { get; private set; }

        User user;

        public MealAddForm(User user)
        {
            InitializeComponent();
            createButton.Text = "Создать блюдо";
            
            this.user = user;
            fillForm();

            searchPanel1.SearchTextChanged += delegate (object? sender, EventArgs e)
            {
                updateList();
            };
            searchPanel1.FilterClick += delegate (object? sender, EventArgs e)
            {
                List<Button> buttons = searchPanelFilterButtonList.recipeFilterButtons;
                searchPanel1.flowLayoutPanel.Size = new Size(300, buttons.Count * buttons[0].Height);
                for (int i = 0; i < buttons.Count; i++)
                {
                    searchPanel1.flowLayoutPanel.Controls.Add(buttons[i]);
                    buttons[i].Click += delegate (object? sender, EventArgs e)
                    {
                        if (sender == null)
                            return;
                        int index = searchPanelFilterButtonList.recipeFilterButtons.IndexOf((Button)sender);
                        if (index < 0) return;
                        recipes.Sort(searchPanelFilterButtonList.recipeComparisons[index]);
                        searchPanel1.SearhText = "";
                        updateList();
                        searchPanel1.flowLayoutPanel.Height = 0;
                        searchPanel1.Height = 60;
                    };
                }

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
            filteredRecipes = recipes;

            for (int i = 0; i < recipes.Count; i++)
            {
                createRecipeButton(recipes[i], new Point(recipeStartPoint.X, recipeStartPoint.Y + i * step), new Point(plusStartPoint.X, plusStartPoint.Y + i * step));                
            }

            createButton.Enabled = true;
        }

        private void createRecipeButton(Recipe recipe, Point recipeLocation, Point plusLocation)
        {
            RecipeAddition recipeButton = new RecipeAddition(recipe);
            recipeButton.Location = recipeLocation;
            recipeButton.InfoButtonClick += delegate (object? sender, EventArgs e)
            {
                RecipeDescriptionForm recipeDescriptionForm = new RecipeDescriptionForm(recipe, user);
                recipeDescriptionForm.deleteButton.Dispose();
                recipeDescriptionForm.ShowDialog();
            };
            recipeButtons.Add(recipeButton);

            MyPanel myPanel = new MyPanel();
            myPanel.BackColor = Color.Gainsboro;
            myPanel.BorderColor = Color.Transparent;
            myPanel.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myPanel.ForeColor = Color.DarkViolet;
            myPanel.Text = "+";
            myPanel.Location = plusLocation;
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
            recipe = filteredRecipes.ElementAt(i);
            //recipeButtons[i].BackColor = Color.YellowGreen;
            this.Close();
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

            for (int i = 0; i < recipeButtons.Count; i++)
            {
                Controls.Remove(recipeButtons[i]);
                Controls.Remove(myPanels[i]);
            }
            recipeButtons.Clear();
            myPanels.Clear();

            for (int i = 0; i < filteredRecipes.Count(); i++)
            {
                createRecipeButton(filteredRecipes.ElementAt(i), new Point(recipeStartPoint.X, recipeStartPoint.Y + i * step), new Point(plusStartPoint.X, plusStartPoint.Y + i * step));
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            RecipeCreationForm recipeCreationForm = new RecipeCreationForm(user);
            recipeCreationForm.Show();
            recipeCreationForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                this.Show();
                if (sender == null)
                    return;
                
                Recipe recipe = ((RecipeCreationForm)sender).recipe;
                if (recipe.name == null)
                    return;

                this.recipes.Add(recipe);

                Point rec = recipeButtons.Last().Location;
                Point plus = myPanels.Last().Location;
                createRecipeButton(recipes.Last(), new Point(rec.X, rec.Y + step), new Point(plus.X, plus.Y + step));
            };

            this.Hide();
        }

        private async void MealAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (recipes.Count == 0) return;

            string json = JsonSerializer.Serialize(recipes, new JsonSerializerOptions { WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve });

            await CacheWorker.writeData(cachePath, json);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.LightGray;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.Gainsboro;
        }
    }
}
