using HealthyLife_Pt2.Controllers;
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

namespace HealthyLIfe_Pt2.Forms
{
    public partial class ProductCreationForm : Form
    {
        public List<Product> existedProducts;
        
        private Product product = new Product();

        public ProductCreationForm()
        {
            InitializeComponent();
            addButton.Text = "Дабавить";
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            product.name = nameTextBox.Text;
            product.category = categoryTextBox.Text;
            product.description = descriptionTextBox.Text;

            Element element = new Element();

            try
            {
                element.calories = Int32.Parse(caloriesTextBox.Text);
                element.proteins = Double.Parse(proteinsTextBox.Text);
                element.fats = Double.Parse(fatsTextBox.Text);
                element.carbohydrates = Double.Parse(carboTextBox.Text);
                element.minerals = mineralsTextBox.Text;
                element.vitamins = vitaminsTextBox.Text;
            }catch(Exception ex)
            {
                MessageBox.Show("Неверные параметры");
                return;
            }

            product.element = element;

            ProductController productController = new ProductController();
            await productController.insertProduct(product);


            existedProducts.Add(product);
            MessageBox.Show("Продукт добавлен");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image? image;
            product.photo = MyImageConverter.chooseImage(out image);

            if (image == null)
                return;

            pictureBox1.Image = image;

        }
    }
}
