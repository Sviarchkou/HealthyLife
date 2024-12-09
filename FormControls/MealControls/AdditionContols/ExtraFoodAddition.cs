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
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthyLife_Pt2.FormControls.MealControls.AdditionContols
{
    public partial class ExtraFoodAddition : UserControl
    {
        public int Count { get; set; }
        public bool onlyInfo { get; set; } = false;

        public Color PanelColor
        {
            get => productPanel.PanelColor;
            set
            {
                productPanel.PanelColor = value;
                name.BackColor = value;
                elements.BackColor = value;
                productPicture.BackColor = value;
                incrementButton.BackColor = value;
                decrimentButton.BackColor = value;
                label1.BackColor = value;
            }
        }
        public bool selected { get; set; } = false;
        public int weight
        {
            get
            {
                Int32.TryParse(weightTextBox.Text, out int weight);
                return weight;
            }
            set
            {
                if (onlyInfo)
                {
                    weightTextBox.Visible = false;
                    weightLabel.Visible = true;
                    weightLabel.Text = value.ToString();
                }
                else
                {
                    weightTextBox.Text = value.ToString();
                    PanelColor = Color.LightGreen;
                    selected = true;
                    weightTextBox.ForeColor = Color.Black;
                    isDefaultWeight = false;
                }
            }
        }

        public Product product { get; private set; }
        private bool isDefaultWeight = true;
        
        public ExtraFoodAddition(Product product)
        {
            InitializeComponent();
            this.product = product;
            fillControl();
        }

        private void fillControl()
        {
            name.Text = product.name;
            elements.Text = product.element.ToString();

            if (product.photo != null && product.photo != "")
                productPicture.Image = MyImageConverter.converFromStringBytes(product.photo);
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            if (Count < 99)
                Count++;
            updateLabel();
        }

        private void decrimentButton_Click(object sender, EventArgs e)
        {
            if (Count > 0)
                Count--;
            updateLabel();
        }

        private void updateLabel()
        {
            counterLabel.Text = Count.ToString();
            if (Count > 0)
                PanelColor = Color.LightGreen;
            else
                PanelColor = Color.Gainsboro;
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultWeight || weightTextBox.Text == "" || !Int32.TryParse(weightTextBox.Text, out int weight) || weight <= 0)
            {
                PanelColor = Color.Gainsboro;
                selected = false;
            }
            else
            {
                PanelColor = Color.LightGreen;
                selected = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            ProductDescriptoinForm productDescriptoinForm = new ProductDescriptoinForm(product);
            productDescriptoinForm.ShowDialog();
        }


        private void weightTextBox_Click(object sender, EventArgs e)
        {
            weightTextBox.Text = "";
            weightTextBox.ForeColor = Color.Black;
            isDefaultWeight = false;
        }

        public ExtraFood getExtraFood()
        {
            if (isDefaultWeight || weightTextBox.Text == "" || !Int32.TryParse(weightTextBox.Text, out int weight) || weight <= 0)
                throw new Exception($"Weight of product {product.name} is not set or set not correctly");
            ExtraFood extraFood = new ExtraFood();
            extraFood.product = product;
            extraFood.weight = weight;
            return extraFood;
        }

    }
}
