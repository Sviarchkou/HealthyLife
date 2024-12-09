using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Forms;
using HealthyLife_Pt2.Forms.MealForms.AddFroms;
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

namespace HealthyLife_Pt2.FormControls.MealControls
{
    public partial class MealAddition : UserControl
    {
        public Meal meal { get; private set; } = new Meal();

        public string DayLabel
        {
            get => dayLabel.Text;
            set => dayLabel.Text = value == null ? "" : value;
        }

        User user;

        public MealAddition(User user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void meal_MouseEnter(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.White;
        }

        private void meal_MouseLeave(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.LavenderBlush;
        }

        private void breakfastAddButton_Click(object sender, EventArgs e)
        {
            MealAddForm mealAddition = new MealAddForm(user);
            mealAddition.Show();
            mealAddition.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                meal.breakfast = ((MealAddForm)sender).recipe;
                if (meal.breakfast != null)
                    breakfastsDiscription.Text = meal.breakfast.name;
                else
                    breakfastsDiscription.Text = "Название блюда";
                updateElement();
            };
        }

        private void lunchAddButton_Click(object sender, EventArgs e)
        {

            MealAddForm mealAddForm = new MealAddForm(user);
            mealAddForm.Show();
            mealAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                meal.lunch = ((MealAddForm)sender).recipe;
                if (meal.lunch != null)
                    lunchDescription.Text = meal.lunch.name;
                else
                    lunchDescription.Text = "Название блюда";
                updateElement();
            };
        }

        private void dinnerAddButton_Click(object sender, EventArgs e)
        {
            MealAddForm mealAddForm = new MealAddForm(user);
            mealAddForm.Show();
            mealAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                meal.dinner = ((MealAddForm)sender).recipe;
                if (meal.dinner != null)
                    dinnerDescription.Text = meal.dinner.name;
                else
                    dinnerDescription.Text = "Название блюда";
                updateElement();
            };
        }

        private void updateElement()
        {
            MealController mealController = new MealController();
            mealController.updateElement(meal);
            element.Text = meal.element.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.Tomato;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.IndianRed;
        }

        private void extraFoodAddButton_Click(object sender, EventArgs e)
        {
            ExtraFoodAddForm extraFoodAddForm = new ExtraFoodAddForm(meal.extraFood, user);
            extraFoodAddForm.Show();
            extraFoodAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                meal.extraFood = ((ExtraFoodAddForm)sender).getSelectedExtraFoods();
                foreach (ExtraFood extraFood in meal.extraFood)
                {
                    extraFood.meal = meal;
                }
            };
            updateElement();
        }
    }
}
