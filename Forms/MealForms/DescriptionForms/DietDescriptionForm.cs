using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;
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

namespace HealthyLife_Pt2.Forms.MealForms
{
    public partial class DietDescriptionForm : Form
    {
        Diet diet;

        Point startPoint = new Point(60, 25);

        List<Panel> panels = new List<Panel>();

        public DietDescriptionForm(Diet diet)
        {
            InitializeComponent();
            this.diet = diet;

            fillForm();
        }

        private void fillForm()
        {
            for (int i = 0; i < diet.meals.Count; i++)            
            {
                Panel panel = new Panel();
                panel.BackColor = Color.White;
                panel.AutoSize = true;

                if (panels.Count == 0)
                    panel.Location = startPoint;
                else
                    panel.Location = new Point(startPoint.X, panels.Last().Location.Y + panels.Last().Height + 50);

                DietDailyMealDescriptionForm form = new DietDailyMealDescriptionForm(diet.meals[i]); 
                
                form.TopLevel = false;
                panel.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.dayText = $"День №{i + 1}";
                form.BringToFront();
                form.Show();
                panel.Size = form.Size;

                panels.Add(panel);

                Controls.Add(panel);
            }

        }

        private void DietDescriptionForm_Load(object sender, EventArgs e)
        {
            


        }
    }
}
