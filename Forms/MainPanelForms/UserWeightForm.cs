using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Forms.MealForms.AddFroms;
using HealthyLife_Pt2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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

namespace HealthyLife_Pt2.Forms.MealForms
{
    public partial class UserWeightForm : Form
    {
        private struct UserWeightChartData
        {
            public DateTime date { get; set; }
            public double weight { get; set; }

            public UserWeightChartData(DateTime date, double weight)
            {
                this.date = date;
                this.weight = (Math.Round(weight * 10) / 10);
            }
        }
        private struct DailyElementChartData
        {
            public DateTime date { get; set; }
            public int calories { get; set; }

            public DailyElementChartData(DateTime date, int calories)
            {
                this.date = date;
                this.calories = calories;
            }
        }

        User user;

        List<UserWeight> userWeights = new List<UserWeight>();
        List<UserWeightChartData> userWeightsForChart = new List<UserWeightChartData>();

        List<DailyElement> dailyElements = new List<DailyElement>();
        List<DailyElementChartData> dailyElementsForChart = new List<DailyElementChartData>();

        DateTime startDate = DateTime.Now.AddDays(-7);

        Button selectedButton;

        public UserWeightForm(User user)
        {
            this.user = user;
            InitializeComponent();
            load_data();

            addWeightButton.Text = "Добавить запись веса";
        }

        private async void load_data()
        {
            UserWeightController userWeightController = new UserWeightController();
            userWeights = await userWeightController.select(user);
            userWeights.Sort(delegate (UserWeight userWeight1, UserWeight userWeight2)
            {
                if (userWeight1.updated_at == userWeight2.updated_at)
                    return 0;
                if (userWeight1.updated_at > userWeight2.updated_at)
                    return -1;
                return 1;
            });

            DailyElementController dailyElementController = new DailyElementController();
            dailyElements = await dailyElementController.select(user);
            dailyElements.Sort(delegate (DailyElement dailyElement1, DailyElement dailyElement2)
            {
                if (dailyElement1.date == dailyElement2.date)
                    return 0;
                if (dailyElement1.date > dailyElement2.date)
                    return -1;
                return 1;
            });

            weightChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            weightChart.DataSource = userWeightsForChart;
            weightChart.Series[0].XValueMember = "date";
            weightChart.Series[0].YValueMembers = "weight";
            //weightChart.Series[0].YValuesPerPoint
            //weightChart.Series[0].ToolTip

            elementChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            elementChart.DataSource = dailyElementsForChart;
            elementChart.Series[0].XValueMember = "date";
            elementChart.Series[0].YValueMembers = "calories";

            weightChart.ChartAreas[0].AxisX.Interval = 2;
            elementChart.ChartAreas[0].AxisX.Interval = 2;

            selectedButton = sevenDaysButton;
            selectedButton.BackColor = Color.GreenYellow;
            updateDate();

        }

        private void updateDate()
        {
            updateWeightChart();
            updateElementChart();
        }

        private void updateWeightChart()
        {
            userWeightsForChart.Clear();
            int max = 0;
            int min = 200;
            foreach (UserWeight userWeight in userWeights)
            {
                if (userWeight.updated_at < startDate && userWeightsForChart.Count > 0)
                {
                    if (userWeightsForChart.Last().date != startDate)
                        userWeightsForChart.Add(new UserWeightChartData(startDate, userWeightsForChart.Last().weight));
                    break;
                }
                userWeightsForChart.Add(new UserWeightChartData(userWeight.updated_at, userWeight.weight));
                if (userWeight.weight > max)
                    max = (int)userWeight.weight;
                if (userWeight.weight < min)
                    min = (int)userWeight.weight;
            }
            if (userWeightsForChart.Count > 0 && userWeightsForChart.Last().date != startDate)
            {
                userWeightsForChart.Add(new UserWeightChartData(userWeightsForChart.Last().date.AddDays(-1), 0));
                userWeightsForChart.Add(new UserWeightChartData(startDate, 0));
            }
            weightChart.ChartAreas[0].AxisY.Minimum = min - 7;
            weightChart.ChartAreas[0].AxisY.Maximum = max + 7;

            weightChart.DataBind();
        }

        private void updateElementChart()
        {
            dailyElementsForChart.Clear();
            int max = 0;
            int min = 5000;
            foreach (DailyElement dailyElement in dailyElements)
            {
                if (dailyElement.date < startDate && dailyElementsForChart.Count > 0)
                {
                    if (dailyElementsForChart.Last().date != startDate)
                        dailyElementsForChart.Add(new DailyElementChartData(startDate, dailyElementsForChart.Last().calories));
                    break;
                }
                dailyElementsForChart.Add(new DailyElementChartData(dailyElement.date, dailyElement.element.calories));
                if (dailyElement.element.calories > max)
                    max = (int)dailyElement.element.calories;
                if (dailyElement.element.calories < min)
                    min = (int)dailyElement.element.calories;
            }
            if (dailyElementsForChart.Count > 0 && dailyElementsForChart.Last().date != startDate)
            {
                dailyElementsForChart.Add(new DailyElementChartData(dailyElementsForChart.Last().date.AddDays(-1), 0));
                dailyElementsForChart.Add(new DailyElementChartData(startDate, 0));
            }

            elementChart.ChartAreas[0].AxisY.Minimum = min - 500 < 0 ? 0 : min - 500;
            elementChart.ChartAreas[0].AxisY.Maximum = max + 500;

            elementChart.DataBind();
        }

        private void sevenDaysButton_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = Color.FromArgb(220, 255, 192);
            selectedButton = sevenDaysButton;
            selectedButton.BackColor = Color.GreenYellow;

            startDate = DateTime.Now.AddDays(-7);
            weightChart.ChartAreas[0].AxisX.Interval = 2;
            elementChart.ChartAreas[0].AxisX.Interval = 2;
            updateDate();
        }

        private void thirtyDaysButton_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = Color.FromArgb(220, 255, 192);
            selectedButton = thirtyDaysButton;
            selectedButton.BackColor = Color.GreenYellow;

            startDate = DateTime.Now.AddDays(-30);
            weightChart.ChartAreas[0].AxisX.Interval = 6;
            elementChart.ChartAreas[0].AxisX.Interval = 6;
            updateDate();
        }

        private void ninetyDaysButton_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = Color.FromArgb(220, 255, 192);
            selectedButton = ninetyDaysButton;
            selectedButton.BackColor = Color.GreenYellow;

            startDate = DateTime.Now.AddDays(-90);
            weightChart.ChartAreas[0].AxisX.Interval = 16;
            elementChart.ChartAreas[0].AxisX.Interval = 16;
            updateDate();
        }

        private void oneYearButton_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = Color.FromArgb(220, 255, 192);
            selectedButton = oneYearButton; 
            selectedButton.BackColor = Color.GreenYellow;

            startDate = DateTime.Now.AddDays(-365);
            weightChart.ChartAreas[0].AxisX.Interval = 30;
            elementChart.ChartAreas[0].AxisX.Interval = 30;
            updateDate();
        }

        private void AllTimeButton_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = Color.FromArgb(220, 255, 192);
            selectedButton = AllTimeButton;
            selectedButton.BackColor = Color.GreenYellow;
            int max = 0;
            int min = 200;

            /// WeightChart ///
            if (userWeights.Count != 0)
            {
                userWeightsForChart.Clear();
                
                foreach (UserWeight userWeight in userWeights)
                {
                    userWeightsForChart.Add(new UserWeightChartData(userWeight.updated_at, userWeight.weight));
                    if (userWeight.weight > max)
                        max = (int)userWeight.weight;
                    if (userWeight.weight < min)
                        min = (int)userWeight.weight;
                }
                weightChart.ChartAreas[0].AxisY.Minimum = min - 20;
                weightChart.ChartAreas[0].AxisY.Maximum = max + 20;
                weightChart.ChartAreas[0].AxisX.Interval = (userWeightsForChart.First().date - userWeightsForChart.Last().date).Days / 5 + 1;
                weightChart.DataBind();
            }

            /// ElemetChart ///
            if (dailyElements.Count == 0)
                return;
            dailyElementsForChart.Clear();
            max = 0;
            min = 5000;
            foreach (DailyElement dailyElement in dailyElements)
            {
                dailyElementsForChart.Add(new DailyElementChartData(dailyElement.date, dailyElement.element.calories));
                if (dailyElement.element.calories > max)
                    max = (int)dailyElement.element.calories;
                if (dailyElement.element.calories < min)
                    min = (int)dailyElement.element.calories;
            }
            elementChart.ChartAreas[0].AxisY.Minimum = min - 500 < 0 ? 0 : min - 500;
            elementChart.ChartAreas[0].AxisY.Maximum = max + 500;
            elementChart.ChartAreas[0].AxisX.Interval = (dailyElementsForChart.First().date - dailyElementsForChart.Last().date).Days / 5 + 1;
            elementChart.DataBind();

        }

        private void addWeightButton_Click(object sender, EventArgs e)
        {
            WeightAddForm weightAddForm = new WeightAddForm(user);
            weightAddForm.Show();
            weightAddForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null || !((WeightAddForm)sender).setted)
                    return;
                if (((WeightAddForm)sender).updated)
                {
                    for (int i = 0; i < userWeights.Count; i++)
                    {
                        if (userWeights[i].updated_at == ((WeightAddForm)sender).userWeight.updated_at)
                        {
                            userWeights[i] = ((WeightAddForm)sender).userWeight;
                            updateDate();
                            return;
                        }                            
                    }                    
                }
                    
                userWeights.Add(((WeightAddForm)sender).userWeight);
                userWeights.Sort(delegate (UserWeight userWeight1, UserWeight userWeight2)
                {
                    if (userWeight1.updated_at == userWeight2.updated_at)
                        return 0;
                    if (userWeight1.updated_at > userWeight2.updated_at)
                        return -1;
                    return 1;
                });
                updateDate();
            };
        }

        private void elementChart_Click(object sender, EventArgs e)
        {

        }

        private void weightChart_GetToolTipText(object? sender, ToolTipEventArgs e)
        {

            int index = e.HitTestResult.PointIndex;

            if (settingIndex(index))
            {
                try
                {
                    string date = userWeightsForChart[index].date.Day + "." + userWeightsForChart[index].date.Month + "." + userWeightsForChart[index].date.Year;
                    string text = userWeightsForChart[index].weight + "кг / " + date;
                    this.toolTip.Show(text, weightChart, e.X + 15, e.Y + 10);
                }
                catch (Exception) { }
            }


        }

        private void elementChart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            int index = e.HitTestResult.PointIndex;

            if (settingIndex(index))
            {
                try
                {
                    string date = dailyElementsForChart[index].date.Day + "." + dailyElementsForChart[index].date.Month + "." + dailyElementsForChart[index].date.Year;
                    string text = $"{dailyElementsForChart[index].calories} ккал / " + date;
                    this.toolTip.Show(text, elementChart, e.X + 15, e.Y + 10);
                }
                catch (Exception) { }        
            }

        }


        private bool settingIndex(int index)
        {
            if (index == -1)
            {
                this.toolTip.Active = false;
                return false;   //Объект не принадлежит диаграмме
            }
            else
            {
                this.toolTip.Active = true;
                return true;    //Объект принадлежит диаграмме
            }
        }
    }
}
