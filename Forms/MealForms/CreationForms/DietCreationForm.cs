using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2;
using HealthyLIfe_Pt2.FormControls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms.MealForms
{
    public partial class DietCreationForm : Form
    {
        Point startPoint = new Point(460, 50);
        int stepX = 440;
        int stepY = 360;
        List<MealAddition> mealAdditions = new List<MealAddition>();

        User user;
        public Diet diet { get; private set; } = new Diet();

        public DietCreationForm(User user)
        {
            InitializeComponent();
            this.user = user;

            createMealAddition(startPoint);
            addMealButton.Text = "Добавить программу на день";
        }

        private MealAddition createMealAddition(Point location)
        {
            MealAddition mealAddition = new MealAddition();
            mealAddition.Location = location;
            this.Controls.Add(mealAddition);
            mealAdditions.Add(mealAddition);
            mealAddition.DayLabel = "День №" + mealAdditions.Count;

            mealAddition.Disposed += delegate (object? sender, EventArgs e)
            {
                if (sender == null)
                    return;
                MealAddition mealSender = ((MealAddition)sender);
                Point prevLocation = mealSender.Location;

                int index = mealAdditions.IndexOf(mealSender);
                mealAdditions.RemoveAt(index);
                Controls.Remove(mealAddition);

                for (; index < mealAdditions.Count; index++)
                {
                    /*
                    Point temp = mealAdditions[index].Location;
                    mealAdditions[index].Location = location;
                    location = temp;
                    */

                    if (index % 2 != 0)
                        mealAdditions[index].Location = new Point(startPoint.X + stepX, mealAdditions[index].Location.Y - stepY);
                    else
                        mealAdditions[index].Location = new Point(startPoint.X, mealAdditions[index].Location.Y);


                    mealAdditions[index].DayLabel = "День №" + (index + 1);
                }
                if (mealAdditions.Count == 0)
                    addMealButton.Location = startPoint;
                else if (mealAdditions.Count % 2 == 0)
                    addMealButton.Location = new Point(startPoint.X, addMealButton.Location.Y - stepY);

            };

            return mealAddition;
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {

            if (mealAdditions.Count == 0)
            {
                createMealAddition(startPoint);
                addMealButton.Location = new Point(460, 410);
                return;
            }

            if (mealAdditions.Count % 2 == 0)
            {
                createMealAddition(new Point(startPoint.X, mealAdditions.Last().Location.Y + stepY));
                addMealButton.Location = new Point(startPoint.X, addMealButton.Location.Y + stepY);
            }
            else
                createMealAddition(new Point(startPoint.X + stepX, mealAdditions.Last().Location.Y));

        }

        private void addMealButton_MouseEnter(object sender, EventArgs e)
        {
            addMealButton.PanelColor = Color.Aqua;
        }

        private void addMealButton_MouseLeave(object sender, EventArgs e)
        {
            addMealButton.PanelColor = Color.Gainsboro;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            List<Meal> meals = new List<Meal>();

            MealController mealController = new MealController();
            foreach (MealAddition mealAddition in mealAdditions)
            {
                mealAddition.meal.id = await mealController.insertMeal(mealAddition.meal);
                meals.Add(mealAddition.meal);
            }


            diet.name = nameTextBox.Text;
            diet.description = descriptionTextBox.Text;
            diet.meals = meals;
            diet.creator = user;

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    diet.goal = Goal.loss;
                    break;
                case 1:
                    diet.goal = Goal.maintenance;
                    break;
                case 2:
                    diet.goal = Goal.gain;
                    break;
                default:
                    diet.goal = Goal.maintenance;
                    break;
            }

            DietController dietController = new DietController();
            diet.id = await dietController.insertDiet(diet);

            MessageBox.Show("Рацион успешно добавлен!");

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image? image;
            diet.photo = MyImageConverter.chooseImage(out image);

            if (image == null)
                return;

            pictureBox1.Image = image;
        }
    }
}
