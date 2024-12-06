using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;
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
using System.Xml;

namespace HealthyLife_Pt2.FormControls.MealControls
{
    public partial class ProductButton : UserControl
    {
        Product product;

        public ProductButton(Product product)
        {
            InitializeComponent();
            this.product = product;
            fillControl();
        }

        public void changeCategoryLabel(string str)
        {
            category.Text = str;
        }

        private void fillControl()
        {
            if (product.photo != null && product.photo != "")
                productPicture.Image = MyImageConverter.converFromStringBytes(product.photo);

            name.Text = product.name;
            category.Text = product.category;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (sender == null)
                return;
            ProductDescriptoinForm productDescriptoinForm = new ProductDescriptoinForm(product);
            productDescriptoinForm.ShowDialog();
        }

    }
}
