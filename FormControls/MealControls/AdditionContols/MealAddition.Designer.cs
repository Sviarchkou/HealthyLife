namespace HealthyLife_Pt2.FormControls.MealControls
{
    partial class MealAddition
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealAddition));
            breakfastAddButton = new MyPanel();
            breakfastsDiscription = new Label();
            breakfastIcon = new Panel();
            breakfastLabel = new Label();
            breakfastPanel = new MyPanel();
            lunchAddButton = new MyPanel();
            dinnerAddButton = new MyPanel();
            extraFoodAddButton = new MyPanel();
            dayLabel = new Label();
            lunchDescription = new Label();
            lunchLabel = new Label();
            dinnerDescription = new Label();
            dinnerLabel = new Label();
            extraFoodDescription = new Label();
            extraFoodLabel = new Label();
            extrafoodIcon = new Panel();
            dinnerIcon = new Panel();
            lunchIcon = new Panel();
            element = new Label();
            myPanel1 = new MyPanel();
            label4 = new Label();
            SuspendLayout();
            // 
            // breakfastAddButton
            // 
            breakfastAddButton.BackColor = Color.Gainsboro;
            breakfastAddButton.BorderColor = Color.Transparent;
            breakfastAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            breakfastAddButton.ForeColor = Color.DarkViolet;
            breakfastAddButton.Location = new Point(339, 40);
            breakfastAddButton.Name = "breakfastAddButton";
            breakfastAddButton.PanelColor = Color.LavenderBlush;
            breakfastAddButton.Rad = 50;
            breakfastAddButton.Size = new Size(50, 50);
            breakfastAddButton.TabIndex = 24;
            breakfastAddButton.Click += breakfastAddButton_Click;
            breakfastAddButton.MouseEnter += meal_MouseEnter;
            breakfastAddButton.MouseLeave += meal_MouseLeave;
            // 
            // breakfastsDiscription
            // 
            breakfastsDiscription.AutoSize = true;
            breakfastsDiscription.BackColor = Color.Gainsboro;
            breakfastsDiscription.Enabled = false;
            breakfastsDiscription.Font = new Font("Verdana", 10F);
            breakfastsDiscription.Location = new Point(80, 70);
            breakfastsDiscription.MaximumSize = new Size(240, 20);
            breakfastsDiscription.Name = "breakfastsDiscription";
            breakfastsDiscription.Size = new Size(154, 20);
            breakfastsDiscription.TabIndex = 23;
            breakfastsDiscription.Text = "Название блюда";
            // 
            // breakfastIcon
            // 
            breakfastIcon.BackColor = Color.Gainsboro;
            breakfastIcon.BackgroundImage = (Image)resources.GetObject("breakfastIcon.BackgroundImage");
            breakfastIcon.BackgroundImageLayout = ImageLayout.Stretch;
            breakfastIcon.Enabled = false;
            breakfastIcon.Location = new Point(14, 38);
            breakfastIcon.Name = "breakfastIcon";
            breakfastIcon.Size = new Size(60, 60);
            breakfastIcon.TabIndex = 22;
            // 
            // breakfastLabel
            // 
            breakfastLabel.AutoSize = true;
            breakfastLabel.BackColor = Color.Gainsboro;
            breakfastLabel.Enabled = false;
            breakfastLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            breakfastLabel.Location = new Point(80, 38);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new Size(117, 28);
            breakfastLabel.TabIndex = 21;
            breakfastLabel.Text = "Завтрак";
            // 
            // breakfastPanel
            // 
            breakfastPanel.BackColor = Color.Transparent;
            breakfastPanel.BorderColor = Color.Empty;
            breakfastPanel.Location = new Point(0, 0);
            breakfastPanel.Name = "breakfastPanel";
            breakfastPanel.PanelColor = Color.Gainsboro;
            breakfastPanel.Rad = 30;
            breakfastPanel.Size = new Size(410, 345);
            breakfastPanel.TabIndex = 20;
            // 
            // lunchAddButton
            // 
            lunchAddButton.BackColor = Color.Gainsboro;
            lunchAddButton.BorderColor = Color.Transparent;
            lunchAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lunchAddButton.ForeColor = Color.DarkViolet;
            lunchAddButton.Location = new Point(339, 103);
            lunchAddButton.Name = "lunchAddButton";
            lunchAddButton.PanelColor = Color.LavenderBlush;
            lunchAddButton.Rad = 50;
            lunchAddButton.Size = new Size(50, 50);
            lunchAddButton.TabIndex = 128;
            lunchAddButton.Click += lunchAddButton_Click;
            lunchAddButton.MouseEnter += meal_MouseEnter;
            lunchAddButton.MouseLeave += meal_MouseLeave;
            // 
            // dinnerAddButton
            // 
            dinnerAddButton.BackColor = Color.Gainsboro;
            dinnerAddButton.BorderColor = Color.Transparent;
            dinnerAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dinnerAddButton.ForeColor = Color.DarkViolet;
            dinnerAddButton.Location = new Point(339, 166);
            dinnerAddButton.Name = "dinnerAddButton";
            dinnerAddButton.PanelColor = Color.LavenderBlush;
            dinnerAddButton.Rad = 50;
            dinnerAddButton.Size = new Size(50, 50);
            dinnerAddButton.TabIndex = 129;
            dinnerAddButton.Click += dinnerAddButton_Click;
            dinnerAddButton.MouseEnter += meal_MouseEnter;
            dinnerAddButton.MouseLeave += meal_MouseLeave;
            // 
            // extraFoodAddButton
            // 
            extraFoodAddButton.BackColor = Color.Gainsboro;
            extraFoodAddButton.BorderColor = Color.Transparent;
            extraFoodAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            extraFoodAddButton.ForeColor = Color.DarkViolet;
            extraFoodAddButton.Location = new Point(339, 229);
            extraFoodAddButton.Name = "extraFoodAddButton";
            extraFoodAddButton.PanelColor = Color.LavenderBlush;
            extraFoodAddButton.Rad = 50;
            extraFoodAddButton.Size = new Size(50, 50);
            extraFoodAddButton.TabIndex = 130;
            extraFoodAddButton.MouseEnter += meal_MouseEnter;
            extraFoodAddButton.MouseLeave += meal_MouseLeave;
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.BackColor = Color.Gainsboro;
            dayLabel.Enabled = false;
            dayLabel.Font = new Font("Verdana", 10.8F);
            dayLabel.Location = new Point(14, 5);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(93, 22);
            dayLabel.TabIndex = 131;
            dayLabel.Text = "День №1";
            // 
            // lunchDescription
            // 
            lunchDescription.AutoSize = true;
            lunchDescription.BackColor = Color.Gainsboro;
            lunchDescription.Enabled = false;
            lunchDescription.Font = new Font("Verdana", 10F);
            lunchDescription.Location = new Point(80, 133);
            lunchDescription.MaximumSize = new Size(240, 20);
            lunchDescription.Name = "lunchDescription";
            lunchDescription.Size = new Size(154, 20);
            lunchDescription.TabIndex = 133;
            lunchDescription.Text = "Название блюда";
            // 
            // lunchLabel
            // 
            lunchLabel.AutoSize = true;
            lunchLabel.BackColor = Color.Gainsboro;
            lunchLabel.Enabled = false;
            lunchLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            lunchLabel.Location = new Point(80, 101);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new Size(79, 28);
            lunchLabel.TabIndex = 132;
            lunchLabel.Text = "Обед";
            // 
            // dinnerDescription
            // 
            dinnerDescription.AutoSize = true;
            dinnerDescription.BackColor = Color.Gainsboro;
            dinnerDescription.Enabled = false;
            dinnerDescription.Font = new Font("Verdana", 10F);
            dinnerDescription.Location = new Point(80, 196);
            dinnerDescription.MaximumSize = new Size(240, 20);
            dinnerDescription.Name = "dinnerDescription";
            dinnerDescription.Size = new Size(154, 20);
            dinnerDescription.TabIndex = 135;
            dinnerDescription.Text = "Название блюда";
            // 
            // dinnerLabel
            // 
            dinnerLabel.AutoSize = true;
            dinnerLabel.BackColor = Color.Gainsboro;
            dinnerLabel.Enabled = false;
            dinnerLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            dinnerLabel.Location = new Point(80, 164);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new Size(86, 28);
            dinnerLabel.TabIndex = 134;
            dinnerLabel.Text = "Ужин";
            // 
            // extraFoodDescription
            // 
            extraFoodDescription.AutoSize = true;
            extraFoodDescription.BackColor = Color.Gainsboro;
            extraFoodDescription.Enabled = false;
            extraFoodDescription.Font = new Font("Verdana", 10F);
            extraFoodDescription.Location = new Point(80, 259);
            extraFoodDescription.MaximumSize = new Size(240, 20);
            extraFoodDescription.Name = "extraFoodDescription";
            extraFoodDescription.Size = new Size(169, 20);
            extraFoodDescription.TabIndex = 137;
            extraFoodDescription.Text = "Список продуктов";
            // 
            // extraFoodLabel
            // 
            extraFoodLabel.AutoSize = true;
            extraFoodLabel.BackColor = Color.Gainsboro;
            extraFoodLabel.Enabled = false;
            extraFoodLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            extraFoodLabel.Location = new Point(80, 227);
            extraFoodLabel.Name = "extraFoodLabel";
            extraFoodLabel.Size = new Size(143, 28);
            extraFoodLabel.TabIndex = 136;
            extraFoodLabel.Text = "Перекусы";
            // 
            // extrafoodIcon
            // 
            extrafoodIcon.BackColor = Color.Gainsboro;
            extrafoodIcon.BackgroundImage = (Image)resources.GetObject("extrafoodIcon.BackgroundImage");
            extrafoodIcon.BackgroundImageLayout = ImageLayout.Stretch;
            extrafoodIcon.Enabled = false;
            extrafoodIcon.Location = new Point(14, 227);
            extrafoodIcon.Name = "extrafoodIcon";
            extrafoodIcon.Size = new Size(60, 60);
            extrafoodIcon.TabIndex = 141;
            // 
            // dinnerIcon
            // 
            dinnerIcon.BackColor = Color.Gainsboro;
            dinnerIcon.BackgroundImage = (Image)resources.GetObject("dinnerIcon.BackgroundImage");
            dinnerIcon.BackgroundImageLayout = ImageLayout.Stretch;
            dinnerIcon.Enabled = false;
            dinnerIcon.Location = new Point(14, 164);
            dinnerIcon.Name = "dinnerIcon";
            dinnerIcon.Size = new Size(60, 60);
            dinnerIcon.TabIndex = 140;
            // 
            // lunchIcon
            // 
            lunchIcon.BackColor = Color.Gainsboro;
            lunchIcon.BackgroundImage = (Image)resources.GetObject("lunchIcon.BackgroundImage");
            lunchIcon.BackgroundImageLayout = ImageLayout.Stretch;
            lunchIcon.Enabled = false;
            lunchIcon.Location = new Point(14, 101);
            lunchIcon.Name = "lunchIcon";
            lunchIcon.Size = new Size(60, 60);
            lunchIcon.TabIndex = 139;
            // 
            // element
            // 
            element.BackColor = Color.LavenderBlush;
            element.Font = new Font("Verdana", 8F);
            element.ForeColor = Color.Black;
            element.Location = new Point(28, 305);
            element.Name = "element";
            element.Size = new Size(348, 21);
            element.TabIndex = 142;
            element.Text = "КБЖУ";
            // 
            // myPanel1
            // 
            myPanel1.BackColor = Color.Gainsboro;
            myPanel1.BorderColor = Color.Transparent;
            myPanel1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myPanel1.ForeColor = Color.DarkViolet;
            myPanel1.Location = new Point(14, 300);
            myPanel1.Name = "myPanel1";
            myPanel1.PanelColor = Color.LavenderBlush;
            myPanel1.Rad = 30;
            myPanel1.Size = new Size(375, 30);
            myPanel1.TabIndex = 143;
            // 
            // label4
            // 
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(368, 0);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 144;
            label4.Text = "x";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // MealAddition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label4);
            Controls.Add(element);
            Controls.Add(myPanel1);
            Controls.Add(extrafoodIcon);
            Controls.Add(dinnerIcon);
            Controls.Add(lunchIcon);
            Controls.Add(extraFoodDescription);
            Controls.Add(extraFoodLabel);
            Controls.Add(dinnerDescription);
            Controls.Add(dinnerLabel);
            Controls.Add(lunchDescription);
            Controls.Add(lunchLabel);
            Controls.Add(dayLabel);
            Controls.Add(extraFoodAddButton);
            Controls.Add(dinnerAddButton);
            Controls.Add(lunchAddButton);
            Controls.Add(breakfastAddButton);
            Controls.Add(breakfastsDiscription);
            Controls.Add(breakfastIcon);
            Controls.Add(breakfastLabel);
            Controls.Add(breakfastPanel);
            Name = "MealAddition";
            Size = new Size(415, 358);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyPanel breakfastAddButton;
        private Label breakfastsDiscription;
        private Panel breakfastIcon;
        private Label breakfastLabel;
        private MyPanel breakfastPanel;
        private MyPanel lunchAddButton;
        private MyPanel dinnerAddButton;
        private MyPanel extraFoodAddButton;
        private Label dayLabel;
        private Label lunchDescription;
        private Label lunchLabel;
        private Label dinnerDescription;
        private Label dinnerLabel;
        private Label extraFoodDescription;
        private Label extraFoodLabel;
        private Panel extrafoodIcon;
        private Panel dinnerIcon;
        private Panel lunchIcon;
        private Label element;
        private MyPanel myPanel1;
        private Label label4;
    }
}
