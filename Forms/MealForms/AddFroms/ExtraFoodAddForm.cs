using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.FormControls.MealControls.AdditionContols;
using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2.Forms;
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
    public partial class ExtraFoodAddForm : Form
    {

        List<ExtraFood> selectedExtraFood = new List<ExtraFood>();

        List<Product> products = new List<Product>();
        IEnumerable<Product> filteredProducts = new List<Product>();

        List<ExtraFoodAddition> extraFoodAdditions = new List<ExtraFoodAddition>();
        List<ExtraFoodAddition> currentExtraFoodAdditions = new List<ExtraFoodAddition>();


        private Point startPoint = new Point(25, 105);
        private int step = 90;

        User user;

        public ExtraFoodAddForm(List<ExtraFood> selectedExtraFood, User user)
        {
            InitializeComponent();
            this.selectedExtraFood = selectedExtraFood;
            this.user = user;

            fillForm();
            searchPanel1.SearchTextChanged += delegate (object? sender, EventArgs e)
            {
                updateList();
            };

            createButton.Text = "Добавить продукт";
            infoButton.Text = "Просмотр добавленных продуктов";
        }

        private async void fillForm()
        {
            ProductController productController = new ProductController();
            products = await productController.select("SELECT * FROM products");
            for (int i = 0; i < products.Count; i++)
            {
                currentExtraFoodAdditions.Add(createProductAddition(products[i], new Point(startPoint.X, startPoint.Y + step * i)));
            }

        }

        private void filterProducts()
        {
            string str = searchPanel1.SearhText;
            filteredProducts = from p in products where p.name.ToLower().Contains(str.ToLower()) select p;
        }

        private async void updateList()
        {
            if (searchPanel1.SearhText == "")
                filteredProducts = products;
            else
                await Task.Run(() => filterProducts());

            currentExtraFoodAdditions.Clear();

            foreach (ExtraFoodAddition extraFoodAddition in extraFoodAdditions)
            {
                if (filteredProducts.Contains(extraFoodAddition.product))
                {
                    currentExtraFoodAdditions.Add(extraFoodAddition);
                    extraFoodAddition.Visible = true;
                }
                else
                {
                    extraFoodAddition.Visible = false;
                }
            }

            for (int i = 0; i < currentExtraFoodAdditions.Count; i++)
            {
                currentExtraFoodAdditions[i].Location = new Point(startPoint.X, startPoint.Y + i * step);
            }

        }

        private ExtraFoodAddition createProductAddition(Product product, Point location)
        {
            ExtraFoodAddition extraFoodAddition = new ExtraFoodAddition(product);
            extraFoodAddition.Location = location;
            foreach (ExtraFood extraFood in selectedExtraFood)
            {
                if (extraFood.product.Equals(product))
                {
                    extraFoodAddition.weight = extraFood.weight;
                }
            }
            Controls.Add(extraFoodAddition);
            extraFoodAdditions.Add(extraFoodAddition);
            return extraFoodAddition;
        }

        public List<ExtraFood> getSelectedExtraFoods()
        {
            selectedExtraFood.Clear();
            foreach (ExtraFoodAddition extraFoodAddition in extraFoodAdditions)
            {
                if (!extraFoodAddition.selected)
                    continue;
                try
                {
                    selectedExtraFood.Add(extraFoodAddition.getExtraFood());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
            return selectedExtraFood;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ProductCreationForm productCreationForm = new ProductCreationForm(user);
            productCreationForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                Product? p = ((ProductCreationForm)sender).product;

                if (p == null)
                    return;

                products.Add(p);
            };
            productCreationForm.Show();
            
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            ExtraFoodDescriptionForm extraFoodDescriptionForm = new ExtraFoodDescriptionForm(getSelectedExtraFoods());            
            extraFoodDescriptionForm.ShowDialog();
        }
    }
}
