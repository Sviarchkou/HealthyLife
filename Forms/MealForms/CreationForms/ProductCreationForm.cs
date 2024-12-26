using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls;
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

        public Product? product { get; private set; }

        User user;
        string? productImage;

        public ProductCreationForm(User user)
        {
            InitializeComponent();
            this.user = user;
            addButton.Text = "Дабавить";
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("После добавления продукт уже нельзя будет изменить. \nВы увеврены, что хотите добавить этот продукт?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            product = new Product();
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Невозможно создать продукт без названия");
                return;
            }
            product.name = nameTextBox.Text;
            if (categoryTextBox.Text == "")
            {
                MessageBox.Show("Невозможно создать продукт без категории");
                return;
            }
            product.category = categoryTextBox.Text;
            product.description = descriptionTextBox.Text;
            if (productImage != null && productImage != "")
                product.photo = productImage;

            if (!Int32.TryParse(caloriesTextBox.Text, out int cal) || cal < 0)
            {
                MessageBox.Show("Неверное количество калорий");
                return;
            }
            if (!Double.TryParse(proteinsTextBox.Text, out double prot) || prot < 0)
            {
                MessageBox.Show("Неверное количество белка");
                return;
            }
            if (!Double.TryParse(fatsTextBox.Text, out double fats) || fats < 0)
            {
                MessageBox.Show("Неверное количество жиров");
                return;
            }
            if (!Double.TryParse(carboTextBox.Text, out double carbo) || carbo < 0)
            {
                MessageBox.Show("Неверное количество углеводов");
                return;
            }

            Element element = new Element();
            element.calories = cal;
            element.proteins = prot;
            element.fats = fats;
            element.carbohydrates = carbo;
            element.minerals = mineralsTextBox.Text;
            element.vitamins = vitaminsTextBox.Text;    

            product.element = element;
            
            if (user.role == true)
                product.verified = true; 

            ProductController productController = new ProductController();
            await productController.insertProduct(product);

            MessageBox.Show("Продукт добавлен");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Image? image;
                productImage = MyImageConverter.chooseImage(out image);

                if (image == null)
                    return;

                pictureBox1.Image = image;
            } catch (Exception ex) { MessageBox.Show("Не получилось добавить фото("); }
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
