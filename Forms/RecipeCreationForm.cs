using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLIfe_Pt2.Forms
{
    public partial class RecipeCreationForm : Form
    {
        Recipe recipe = new Recipe();

        List<Product> products = new List<Product>();
        IEnumerable<Product> filteredProducts = new List<Product>();
        List<IngredientAddition> ingredientAdditions = new List<IngredientAddition>();

        List<Ingredient> ingredients = new List<Ingredient>();

        private const int pointX = 470;
        Point ingredientStartPoint = new Point(pointX, 40);
        int step = 110;

        public RecipeCreationForm()
        {
            InitializeComponent();

            fillProducts();

            addIngredientPanel.Text = "Добавить ингредиент";
        }

        private async void fillProducts()
        {
            ProductController productController = new ProductController();
            products = await productController.select("SELECT * FROM products");
            filteredProducts = products;
            anotherProgBar1.Dispose();
            createIngredAdd(ingredientStartPoint);
        }

        private void createIngredAdd(Point point)
        {
            IngredientAddition ingredientAddition = new IngredientAddition();
            ingredientAddition.Location = point;
            ingredientAddition.products = products;
            ingredientAddition.Disposed += ingredAdd_Dispose;
            ingredientAddition.SendToBack();
            ingredientAdditions.Add(ingredientAddition);
            Controls.Add(ingredientAddition);

            addIngredientPanel.SendToBack();
        }

        private void ingredAdd_Dispose(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                MessageBox.Show("Oops! Somothing went wrong(");
                return;
            }

            IngredientAddition disposed = (IngredientAddition)sender;
            int index = ingredientAdditions.IndexOf(disposed);

            ingredientAdditions.RemoveAt(index);
            Controls.Remove(disposed);

            for (; index < ingredientAdditions.Count; index++)
            {
                ingredientAdditions[index].Location = new Point(pointX, ingredientAdditions[index].Location.Y - step);
            }

            addIngredientPanel.Location = new Point(pointX, addIngredientPanel.Location.Y - step);

        }

        private void addIngredientPanel_MouseEnter(object sender, EventArgs e)
        {
            addIngredientPanel.PanelColor = Color.Aqua;
        }

        private void addIngredientPanel_MouseLeave(object sender, EventArgs e)
        {
            addIngredientPanel.PanelColor = Color.Gainsboro;
        }

        private void addIngredientPanel_Click(object sender, EventArgs e)
        {
            addIngredientPanel.Location = new Point(pointX, addIngredientPanel.Location.Y + step);
            if (ingredientAdditions.Count == 0)
                createIngredAdd(ingredientStartPoint);
            else
                createIngredAdd(new Point(pointX, ingredientAdditions.Last().Location.Y + step));

            addIngredientPanel.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image? image;
            recipe.photo = MyImageConverter.chooseImage(out image);

            if (image == null)
                return;

            pictureBox1.Image = image;
        }

        private async Task<bool> updateElements()
        {
            
            recipe.ingredients.Clear();
            foreach (IngredientAddition ingr in ingredientAdditions)
            {
                try
                {
                    Ingredient ingredient = ingr.getIngredient();                    
                    recipe.ingredients.Add(ingredient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Для обновления заполните все поля игредиетов");
                    return false;
                }
            }

            RecipeController recipeController = new RecipeController();
            await recipeController.updateElement(recipe);

            caloriesCounter.Text = recipe.element.calories.ToString();
            proteinCounter.Text = recipe.element.proteins.ToString();
            fatsCounter.Text = recipe.element.fats.ToString();
            carboCounter.Text = recipe.element.carbohydrates.ToString();
            
            return true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await updateElements();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            recipe.name = nameTextBox.Text;
            recipe.description = descriptionTextBox.Text;

            if (!await updateElements())
                return;

            RecipeController recipeController = new RecipeController();            
            try
            {
                await recipeController.insertRecipe(recipe);
                MessageBox.Show("Рецепт добавлен");
            } catch(Exception ex)
            {
                MessageBox.Show("Возникли ошибки добавления");
            }

            this.Close();
        }
    }
}
