using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.Forms.MealForms.AddFroms;
using HealthyLife_Pt2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms
{
    public partial class DailyCounter : Form
    {
        private User user;
        private Element requiredElements;
        private Element currentElement;
        private DailyElement dailyElement;
        private DailyMeal dailyMeal;
        public DailyCounter(User user)
        {
            InitializeComponent();

            this.user = user;
            initForm();

            caloriesValueLabel.Text = "";
            proteinValueLabel.Text = "";
            fatValueLabel.Text = "";
            carboValueLabel.Text = "";
            breakfastAddButton.Text = "+";
            lunchAddButton.Text = "+";
            dinnerAddButton.Text = "+";
            extrafoodAddButton.Text = "+";

        }

        private async void initForm()
        {
            UserController userController = new UserController();
            try
            {
                requiredElements = await userController.selectRequiredElement(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникли проблемы при обработке данных");
            }

            DailyElementController dailyElementControler = new DailyElementController();
            try
            {
                dailyElement = await dailyElementControler.findToday(user.id.ToString());
                currentElement = dailyElement.element;

            }
            catch (Exception ex)
            {
                currentElement = new Element();
                ElementController elementController = new ElementController();
                currentElement.id = await elementController.insertElement(currentElement);

                dailyElement = await dailyElementControler.insertDailyElement(user, currentElement);
            }

            DailyMealController dailyMealController = new DailyMealController();
            try
            {
                dailyMeal = await dailyMealController.findToday(user.id.ToString());
            }
            catch (Exception ex)
            {
                Meal meal = new Meal();
                ElementController elementController = new ElementController();
                meal.element.id = await elementController.insertElement(meal.element);

                MealController mealController = new MealController();
                meal.id = await mealController.insertMeal(meal);

                dailyMeal = await dailyMealController.insertTodayDailyMeal(user, meal);

            }


            fillForm();
        }

        private void fillForm()
        {
            caloriesValueLabel.Text = $"Цель - {requiredElements.calories} ккал";
            proteinValueLabel.Text = $"{(int)currentElement.proteins} / {(int)requiredElements.proteins} г";
            fatValueLabel.Text = $"{(int)currentElement.fats} / {(int)requiredElements.fats} г";
            carboValueLabel.Text = $"{(int)currentElement.carbohydrates} / {(int)requiredElements.carbohydrates} г";

            caloriesBar.Text = currentElement.calories.ToString();
            caloriesBar.ValueSize = currentElement.calories * 100 / requiredElements.calories;
            proteinBar.Value = (int)(currentElement.proteins * 100 / requiredElements.proteins);
            fatBar.Value = (int)(currentElement.fats * 100 / requiredElements.fats);
            carbohydratesBar.Value = (int)(currentElement.carbohydrates * 100 / requiredElements.carbohydrates);

            if (dailyMeal.meal.breakfast != null)
            {
                if (dailyMeal.meal.breakfast.name.Length > 21)
                    breakfastsDiscription.Text = dailyMeal.meal.breakfast.name.Substring(0, 21) + "...";
                else
                    breakfastsDiscription.Text = dailyMeal.meal.breakfast.name;
                breakfastAddButton.PanelColor = Color.GreenYellow;
            }
            else
            {
                breakfastAddButton.PanelColor = Color.LavenderBlush;
                breakfastsDiscription.Text = "Завтрак пока не добавлен";
            }

            if (dailyMeal.meal.lunch != null)
            {
                if (dailyMeal.meal.lunch.name.Length > 21)
                    lunchDiscription.Text = dailyMeal.meal.lunch.name.Substring(0, 21) + "...";
                else
                    lunchDiscription.Text = dailyMeal.meal.lunch.name;
                lunchAddButton.PanelColor = Color.GreenYellow;
            }
            else
            {
                lunchAddButton.PanelColor = Color.LavenderBlush;
                lunchDiscription.Text = "Обед пока не добавлен";
            }


            if (dailyMeal.meal.dinner != null)
            {
                if (dailyMeal.meal.dinner.name.Length > 21)
                    dinnerDiscription.Text = dailyMeal.meal.dinner.name.Substring(0, 21) + "...";
                else
                    dinnerDiscription.Text = dailyMeal.meal.dinner.name;
                dinnerAddButton.PanelColor = Color.GreenYellow;
            }
            else
            {
                dinnerAddButton.PanelColor = Color.LavenderBlush;
                dinnerDiscription.Text = "Ужин пока не добавлен";
            }

            if (dailyMeal.meal.extraFood != null && dailyMeal.meal.extraFood.Count != 0)
                extrafoodDiscription.Text = dailyMeal.meal.extraFood.ToString();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            MealAddForm mealAddition = new MealAddForm();
            mealAddition.Show();
            mealAddition.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                dailyMeal.meal.breakfast = ((MealAddForm)sender).recipe;
                updateCurrentElements();
                fillForm();
            };
        }

        private void lunchAddButton_Click(object sender, EventArgs e)
        {
            MealAddForm mealAddForm = new MealAddForm();
            mealAddForm.Show();
            mealAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                dailyMeal.meal.lunch = ((MealAddForm)sender).recipe;
                updateCurrentElements();
                fillForm();
            };
        }

        private void dinnerAddButton_Click(object sender, EventArgs e)
        {
            MealAddForm mealAddForm = new MealAddForm();
            mealAddForm.Show();
            mealAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                dailyMeal.meal.dinner = ((MealAddForm)sender).recipe;
                updateCurrentElements();
                fillForm();
            };
        }

        private void extrafoodAddButton_Click(object sender, EventArgs e)
        {
            ExtraFoodAddForm extraFoodAddForm = new ExtraFoodAddForm(dailyMeal.meal.extraFood);
            extraFoodAddForm.Show();
            extraFoodAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                dailyMeal.meal.extraFood = ((ExtraFoodAddForm)sender).getSelectedExtraFoods();
                foreach (ExtraFood extraFood in dailyMeal.meal.extraFood)
                {
                    extraFood.meal = dailyMeal.meal;
                }
                updateCurrentElements();
                fillForm();
            };
        }


        private void updateCurrentElements()
        {
            ElementController elementController = new ElementController();
            elementController.clearElement(currentElement);
            int id = currentElement.id;
            if (dailyMeal.meal.breakfast != null)
                currentElement = elementController.sumElements(currentElement, dailyMeal.meal.breakfast.element);

            if (dailyMeal.meal.lunch != null)
                currentElement = elementController.sumElements(currentElement, dailyMeal.meal.lunch.element);

            if (dailyMeal.meal.dinner != null)
                currentElement = elementController.sumElements(currentElement, dailyMeal.meal.dinner.element);

            if (dailyMeal.meal.extraFood != null && dailyMeal.meal.extraFood.Count != 0)
            {
                foreach (ExtraFood extraFood in dailyMeal.meal.extraFood)
                {
                    currentElement = elementController.sumElements(currentElement, extraFood.calculateElement());
                }
            }

            currentElement.id = id;
            dailyElement.element = currentElement;
        }


        public async Task loadData()
        {
            UserController userController = new UserController();

            ElementController elementControler = new ElementController();
            try
            {
                await elementControler.updateElement(currentElement);
            }
            catch (Exception ex) { }

            MealController mealController = new MealController();
            try
            {
                await mealController.updateMeal(dailyMeal.meal);
            }
            catch (Exception ex) { }


        }

        
    }
}
