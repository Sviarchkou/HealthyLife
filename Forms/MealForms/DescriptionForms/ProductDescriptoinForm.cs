using HealthyLife_Pt2.Controllers;
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
    public partial class ProductDescriptoinForm : Form
    {
        Product product;

        public ProductDescriptoinForm(Product product)
        {
            InitializeComponent();
            this.product = product;

            fillForm();
            if (product.verified)
            {
                approvedMark.Visible = true;
                toolTip.SetToolTip(this.approvedMark, "Данный продукт одобрен профессионалом");
            }

            toolTip.SetToolTip(this.vitaminsInfo, vitaminsInfo.Text);
            toolTip.SetToolTip(this.mineralsInfo, mineralsInfo.Text);


            this.DialogResult = DialogResult.No;

        }

        private void fillForm()
        {
            if (product.photo != null && product.photo != "")
                pictureBox1.Image = MyImageConverter.converFromStringBytes(product.photo);

            category.Text = product.category;
            nameLabel.Text = product.name;
            if (product.description != "")
                description.Text = product.description;
            else
                description.Text = "Для этого продукта не нашлось описания (";

            caloriesCounter.Text = product.element.calories.ToString();
            proteinCounter.Text = product.element.proteins.ToString();
            fatsCounter.Text = product.element.fats.ToString();
            carboCounter.Text = product.element.carbohydrates.ToString();
            if (product.element.minerals == null || product.element.minerals == "")
                mineralsInfo.Text = "* Нет *";
            else
                mineralsInfo.Text = product.element.minerals.ToString();

            if (product.element.vitamins == null || product.element.vitamins == "")
                vitaminsInfo.Text = "* Нет *";
            else
                vitaminsInfo.Text = product.element.vitamins.ToString();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этот продукт?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            ProductController productController = new ProductController();
            if (!await productController.isUnreleted(product))
            {
                MessageBox.Show("Невозможно удалить продукт, т.к. он используется другими пользователя");
            }
            else
            {
                try
                {
                    await productController.deleteProduct(product);
                    this.DialogResult = DialogResult.Yes;
                    MessageBox.Show("Продукт удалён");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Не получилось удалить этот продукт(");
                }
            }
        }
    }
}
