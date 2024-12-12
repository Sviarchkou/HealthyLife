namespace HealthyLife_Pt2.Forms.MealForms.DescriptionForms
{
    partial class DietDailyMealDescriptionForm
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
            dayLabel = new Label();
            breakfastLabel = new Label();
            lunchLabel = new Label();
            dinnerLabel = new Label();
            extraFoodLabel = new Label();
            SuspendLayout();
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dayLabel.Location = new Point(20, 9);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(116, 25);
            dayLabel.TabIndex = 0;
            dayLabel.Text = "День №1";
            // 
            // breakfastLabel
            // 
            breakfastLabel.AutoSize = true;
            breakfastLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            breakfastLabel.Location = new Point(124, 40);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new Size(94, 25);
            breakfastLabel.TabIndex = 1;
            breakfastLabel.Text = "Завтрак";
            // 
            // lunchLabel
            // 
            lunchLabel.AutoSize = true;
            lunchLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lunchLabel.Location = new Point(467, 40);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new Size(64, 25);
            lunchLabel.TabIndex = 2;
            lunchLabel.Text = "Обед";
            // 
            // dinnerLabel
            // 
            dinnerLabel.AutoSize = true;
            dinnerLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dinnerLabel.Location = new Point(792, 40);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new Size(66, 25);
            dinnerLabel.TabIndex = 3;
            dinnerLabel.Text = "Ужин";
            // 
            // extraFoodLabel
            // 
            extraFoodLabel.AutoSize = true;
            extraFoodLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            extraFoodLabel.Location = new Point(20, 405);
            extraFoodLabel.Name = "extraFoodLabel";
            extraFoodLabel.Size = new Size(123, 25);
            extraFoodLabel.TabIndex = 4;
            extraFoodLabel.Text = "Перекусы:";
            // 
            // DietDailyMealDescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1005, 550);
            Controls.Add(extraFoodLabel);
            Controls.Add(dinnerLabel);
            Controls.Add(lunchLabel);
            Controls.Add(breakfastLabel);
            Controls.Add(dayLabel);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1005, 99999);
            Name = "DietDailyMealDescriptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayLabel;
        private Label breakfastLabel;
        private Label lunchLabel;
        private Label dinnerLabel;
        private Label extraFoodLabel;
    }
}