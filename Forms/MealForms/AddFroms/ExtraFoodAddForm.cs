using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls.MealControls.AdditionContols;
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

namespace HealthyLife_Pt2.Forms.MealForms.AddFroms
{
    public partial class ExtraFoodAddForm : Form
    {
        //Dictionary<Product, int> selected;
        List<ExtraFood> selectedExtraFood = new List<ExtraFood>();        

        List<Product> products = new List<Product>();
        IEnumerable<Product> filteredProducts = new List<Product>();

        List<ExtraFoodAddition> extraFoodAdditions = new List<ExtraFoodAddition>();

        private Point startPoint = new Point(47, 107);
        private int step = 90;

        public ExtraFoodAddForm(List<ExtraFood> selectedExtraFood)
        {
            InitializeComponent();
            this.selectedExtraFood = selectedExtraFood;
            fillForm();
        }

        private async void fillForm()
        {
            ProductController productController = new ProductController();
            products = await productController.select("SELECT * FROM products");
            for (int i = 0; i < products.Count; i++)
            {
                createProductAddition(products[i], new Point(startPoint.X, startPoint.Y + step * i));
            }

        }

        private ExtraFoodAddition createProductAddition(Product product, Point location)
        {
            
            ExtraFoodAddition extraFoodAddition = new ExtraFoodAddition(product);
            extraFoodAddition.Location = location;
            foreach (ExtraFood extraFood in selectedExtraFood)
            {
                if (extraFood.product.Equals(product)){
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
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                };
            }
            return selectedExtraFood;
        }
    }
}
