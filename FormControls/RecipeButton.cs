using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2;
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

namespace HealthyLife_Pt2.FormControls
{
    public partial class RecipeButton : UserControl
    {
        public Recipe recipe { get; private set; }
        public RecipeButton(Recipe recipe)
        {
            InitializeComponent();

            this.recipe = recipe;
            string name = recipe.name;
            if (name.Length > 17)
                LabelText = name.Substring(0, 15) + "...";

            else
                LabelText = name;

            string str = recipe.element.ToString();
            string[] s = str.Split(", ");

            DescriptionText = s[0] + ", " + s[1] + ",\n" + s[2] + ", " + s[3];
            if (recipe.photo == null || recipe.photo == "")
                return;
            recipePicture.Image = MyImageConverter.converFromStringBytes(recipe.photo);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MyMessageBox msg = new MyMessageBox();
            if (recipe.description != "")
                msg.LabelText = recipe.description;
            else
                msg.LabelText = "Для этого рецепта не нашлось описания (";
            msg.ShowDialog();
        }
    }
}
