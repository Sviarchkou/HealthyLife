namespace HealthyLife_Pt2.Forms.MealForms
{
    partial class UserWeightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            weightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            sevenDaysButton = new Button();
            thirtyDaysButton = new Button();
            ninetyDaysButton = new Button();
            oneYearButton = new Button();
            AllTimeButton = new Button();
            elementChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            addWeightButton = new FormControls.MyPanel();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)weightChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elementChart).BeginInit();
            SuspendLayout();
            // 
            // weightChart
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisY.LabelStyle.Format = "{0} кг";
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.Size = 0F;
            chartArea1.Name = "ChartArea1";
            weightChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            weightChart.Legends.Add(legend1);
            weightChart.Location = new Point(-13, 71);
            weightChart.Name = "weightChart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackSecondaryColor = Color.FromArgb(255, 255, 128);
            series1.BorderColor = Color.FromArgb(64, 64, 0);
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = Color.FromArgb(0, 192, 192);
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            weightChart.Series.Add(series1);
            weightChart.Size = new Size(686, 270);
            weightChart.TabIndex = 0;
            weightChart.Text = "weightChart";
            weightChart.GetToolTipText += weightChart_GetToolTipText;
            // 
            // sevenDaysButton
            // 
            sevenDaysButton.BackColor = Color.FromArgb(220, 255, 192);
            sevenDaysButton.FlatStyle = FlatStyle.Flat;
            sevenDaysButton.Font = new Font("Verdana", 10.8F);
            sevenDaysButton.ForeColor = Color.Black;
            sevenDaysButton.Location = new Point(13, 14);
            sevenDaysButton.Margin = new Padding(0);
            sevenDaysButton.Name = "sevenDaysButton";
            sevenDaysButton.Size = new Size(165, 45);
            sevenDaysButton.TabIndex = 1;
            sevenDaysButton.Text = "7 дней";
            sevenDaysButton.UseVisualStyleBackColor = false;
            sevenDaysButton.Click += sevenDaysButton_Click;
            // 
            // thirtyDaysButton
            // 
            thirtyDaysButton.BackColor = Color.FromArgb(220, 255, 192);
            thirtyDaysButton.FlatStyle = FlatStyle.Flat;
            thirtyDaysButton.Font = new Font("Verdana", 10.8F);
            thirtyDaysButton.ForeColor = Color.Black;
            thirtyDaysButton.Location = new Point(178, 14);
            thirtyDaysButton.Margin = new Padding(0);
            thirtyDaysButton.Name = "thirtyDaysButton";
            thirtyDaysButton.Size = new Size(165, 45);
            thirtyDaysButton.TabIndex = 2;
            thirtyDaysButton.Text = "30 дней";
            thirtyDaysButton.UseVisualStyleBackColor = false;
            thirtyDaysButton.Click += thirtyDaysButton_Click;
            // 
            // ninetyDaysButton
            // 
            ninetyDaysButton.BackColor = Color.FromArgb(220, 255, 192);
            ninetyDaysButton.FlatStyle = FlatStyle.Flat;
            ninetyDaysButton.Font = new Font("Verdana", 10.8F);
            ninetyDaysButton.ForeColor = Color.Black;
            ninetyDaysButton.Location = new Point(343, 14);
            ninetyDaysButton.Margin = new Padding(0);
            ninetyDaysButton.Name = "ninetyDaysButton";
            ninetyDaysButton.Size = new Size(165, 45);
            ninetyDaysButton.TabIndex = 3;
            ninetyDaysButton.Text = "90 дней";
            ninetyDaysButton.UseVisualStyleBackColor = false;
            ninetyDaysButton.Click += ninetyDaysButton_Click;
            // 
            // oneYearButton
            // 
            oneYearButton.BackColor = Color.FromArgb(220, 255, 192);
            oneYearButton.FlatStyle = FlatStyle.Flat;
            oneYearButton.Font = new Font("Verdana", 10.8F);
            oneYearButton.ForeColor = Color.Black;
            oneYearButton.Location = new Point(508, 14);
            oneYearButton.Margin = new Padding(0);
            oneYearButton.Name = "oneYearButton";
            oneYearButton.Size = new Size(165, 45);
            oneYearButton.TabIndex = 4;
            oneYearButton.Text = "1 год";
            oneYearButton.UseVisualStyleBackColor = false;
            oneYearButton.Click += oneYearButton_Click;
            // 
            // AllTimeButton
            // 
            AllTimeButton.BackColor = Color.FromArgb(220, 255, 192);
            AllTimeButton.FlatStyle = FlatStyle.Flat;
            AllTimeButton.Font = new Font("Verdana", 10.8F);
            AllTimeButton.ForeColor = Color.Black;
            AllTimeButton.Location = new Point(673, 14);
            AllTimeButton.Margin = new Padding(0);
            AllTimeButton.Name = "AllTimeButton";
            AllTimeButton.Size = new Size(165, 45);
            AllTimeButton.TabIndex = 5;
            AllTimeButton.Text = "Всё время";
            AllTimeButton.UseVisualStyleBackColor = false;
            AllTimeButton.Click += AllTimeButton_Click;
            // 
            // elementChart
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = Color.DarkGray;
            chartArea2.AxisX.MajorTickMark.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.Size = 2F;
            chartArea2.AxisY.LabelStyle.Format = "{0} ккал";
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = Color.DarkGray;
            chartArea2.AxisY.MajorTickMark.LineWidth = 2;
            chartArea2.AxisY.MajorTickMark.Size = 0F;
            chartArea2.Name = "ChartArea1";
            elementChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            elementChart.Legends.Add(legend2);
            elementChart.Location = new Point(-15, 327);
            elementChart.Name = "elementChart";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = Color.FromArgb(255, 255, 128);
            series2.BorderColor = Color.FromArgb(64, 64, 0);
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = Color.FromArgb(0, 192, 192);
            series2.LabelBorderWidth = 5;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.Name = "Series1";
            elementChart.Series.Add(series2);
            elementChart.Size = new Size(688, 270);
            elementChart.TabIndex = 6;
            elementChart.Text = "elementChart";
            elementChart.GetToolTipText += elementChart_GetToolTipText;
            elementChart.Click += elementChart_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 10.8F);
            button1.Location = new Point(701, 527);
            button1.Name = "button1";
            button1.Size = new Size(137, 61);
            button1.TabIndex = 7;
            button1.Text = "Добавить запись веса";
            button1.UseVisualStyleBackColor = true;
            // 
            // addWeightButton
            // 
            addWeightButton.BorderColor = Color.DarkGray;
            addWeightButton.Font = new Font("Verdana", 10.8F);
            addWeightButton.Location = new Point(679, 90);
            addWeightButton.Name = "addWeightButton";
            addWeightButton.PanelColor = Color.Gainsboro;
            addWeightButton.Rad = 60;
            addWeightButton.Size = new Size(159, 60);
            addWeightButton.TabIndex = 8;
            addWeightButton.Click += addWeightButton_Click;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 100;
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 20;
            // 
            // UserWeightForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 600);
            Controls.Add(addWeightButton);
            Controls.Add(button1);
            Controls.Add(elementChart);
            Controls.Add(AllTimeButton);
            Controls.Add(oneYearButton);
            Controls.Add(ninetyDaysButton);
            Controls.Add(thirtyDaysButton);
            Controls.Add(sevenDaysButton);
            Controls.Add(weightChart);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "UserWeightForm";
            Text = "UserWeightForm";
            ((System.ComponentModel.ISupportInitialize)weightChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)elementChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart weightChart;
        private Button sevenDaysButton;
        private Button thirtyDaysButton;
        private Button ninetyDaysButton;
        private Button oneYearButton;
        private Button AllTimeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart elementChart;
        private Button button1;
        private FormControls.MyPanel addWeightButton;
        private ToolTip toolTip;
    }
}