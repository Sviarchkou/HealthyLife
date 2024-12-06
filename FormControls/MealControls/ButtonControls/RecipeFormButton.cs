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

namespace HealthyLife_Pt2.FormControls.MealControls
{
    public partial class RecipeFormButton : UserControl
    {
        public Recipe recipe { get; private set; }

        public event EventHandler? RecipeFormButtonClicked;
        public event EventHandler? RecipeFormButtonMouseEnter;
        public event EventHandler? RecipeFormButtonMouseLeave;
        

    public Color PanelColor { 
            get => recipePanel.PanelColor;
            set { 
                recipePanel.PanelColor = value;
                elements.BackColor = value;
                name.BackColor = value;
            }
        }

        public RecipeFormButton(Recipe recipe)
        {
            InitializeComponent();

            this.recipe = recipe;

            string[] str = recipe.element.ToString().Split(", ");
            elements.Text = str[0] + ", " + str[1] + ",\n" + str[2] + ", " + str[3];
            name.Text = recipe.name;

            if (recipe.photo == null || recipe.photo == "")
                return;
            pictureBox.Image = MyImageConverter.converFromStringBytes(recipe.photo);

        }

        private void recipeFormButtonClicked(object sender, EventArgs e)
        {
            RecipeFormButtonClicked?.Invoke(this, e);
        }

        private void recipeFormButtonMouseEnter(object sender, EventArgs e)
        {
            RecipeFormButtonMouseEnter?.Invoke(this, e);
        }
        private void recipeFormButtonMouseLeave(object sender, EventArgs e)
        {
            RecipeFormButtonMouseLeave?.Invoke(this, e);
        }


    }
}
