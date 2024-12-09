using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls.MealControls.AdditionContols;
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

namespace HealthyLife_Pt2.Forms.MealForms.DescriptionForms
{
    public partial class ExtraFoodDescriptionForm : Form
    {

        
        List<ExtraFood> extraFoods;

        List<ExtraFoodAddition> extraFoodAdditions = new List<ExtraFoodAddition>();

        private Point startPoint = new Point(20, 30);
        private int step = 80;


        public ExtraFoodDescriptionForm(List<ExtraFood> extraFoods)
        {
            this.extraFoods = extraFoods;
            InitializeComponent();
            fillForm();
        }


        private void fillForm()
        {
            for (int i = 0; i < extraFoods.Count; i++)
            {
                createProductAddition(extraFoods[i].product, new Point(startPoint.X, startPoint.Y + step * i));
            }

        }

        private ExtraFoodAddition createProductAddition(Product product, Point location)
        {
            ExtraFoodAddition extraFoodAddition = new ExtraFoodAddition(product);
            extraFoodAddition.onlyInfo = true;
            extraFoodAddition.Location = location;
            foreach (ExtraFood extraFood in extraFoods)
            {
                if (extraFood.product.Equals(product))
                {
                    extraFoodAddition.weight = extraFood.weight;
                    break;
                }
            }
            
            Controls.Add(extraFoodAddition);
            extraFoodAdditions.Add(extraFoodAddition);
            return extraFoodAddition;
        }

        private void ExtraFoodDescriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            extraFoods.Clear();
            foreach (ExtraFoodAddition extraFoodAddition in extraFoodAdditions)
            {
                if (!extraFoodAddition.selected)
                    continue;
                try
                {
                    extraFoods.Add(extraFoodAddition.getExtraFood());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
            */
        }
    }
}
