using HealthyLife_Pt2.Controllers;
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
        User user;
        Diet diet;

        Point startPoint = new Point(60, 130);

        List<Panel> panels = new List<Panel>();

        public DietDescriptionForm(Diet diet, User user)
        {
            InitializeComponent();
            this.diet = diet;
            this.user = user;
            fillForm();


            if (user.role)
                deleteButton.Visible = true;
            else
                deleteButton.Visible = false;


        }

        private void fillForm()
        {
            switch (diet.goal)
            {
                case Goal.loss:
                    goalLabel.Text = $"Цель - похудение";
                    break;
                case Goal.maintenance:
                    goalLabel.Text = $"Цель - поддержание веса";
                    break;
                case Goal.gain:
                    goalLabel.Text = $"Цель - набор массы";
                    break;
            }
            nameLabel.Text = diet.name;
            description.Text = diet.description;
            startPoint = new Point(startPoint.X, startPoint.Y + description.Height);

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

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этот рецепт?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            if (diet.creator.id != user.id)
            {
                MessageBox.Show("Невожможно удалить этот рацион, так как вы не являетесь его создателем");
                return;
            }

            DietController dietController = new DietController();

            if (!await dietController.isUnreleted(diet))
            {
                dialogResult = MessageBox.Show("Реционом ещё пользуются другие пользователи, удалить этот рецепт?", "", MessageBoxButtons.YesNo);
            }
            if (dialogResult == DialogResult.No)
                return;

            try
            {
                await dietController.deleteDiet(diet);
                this.DialogResult = DialogResult.Yes;
                MessageBox.Show("Рацион удалён");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось удалить этот рацион(");
            }

        }

    }
}
