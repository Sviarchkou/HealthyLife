namespace HealthyLife_Pt2.Forms
{
    partial class DailyCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyCounter));
            caloriesBar = new FormControls.CircularProgressBar();
            myPanel1 = new FormControls.MyPanel();
            proteinBar = new FormControls.AnotherProgBar();
            proteinLabel = new Label();
            fatLabel = new Label();
            fatBar = new FormControls.AnotherProgBar();
            carbohydrateLabel = new Label();
            carbohydratesBar = new FormControls.AnotherProgBar();
            breakfastPanel = new FormControls.MyPanel();
            breakfastLabel = new Label();
            breakfastIcon = new Panel();
            breakfastsDiscription = new Label();
            breakfastAddButton = new FormControls.MyPanel();
            lunchAddButton = new FormControls.MyPanel();
            lunchDiscription = new Label();
            lunchIcon = new Panel();
            lunchLabel = new Label();
            lunchPanel = new FormControls.MyPanel();
            dinnerAddButton = new FormControls.MyPanel();
            dinnerDiscription = new Label();
            dinnerIcon = new Panel();
            dinnerLabel = new Label();
            dinnerPanel = new FormControls.MyPanel();
            extrafoodAddButton = new FormControls.MyPanel();
            extrafoodDiscription = new Label();
            extrafoodIcon = new Panel();
            extrafoodLabel = new Label();
            extrafoodPanel = new FormControls.MyPanel();
            proteinValueLabel = new Label();
            fatValueLabel = new Label();
            carboValueLabel = new Label();
            caloriesValueLabel = new Label();
            SuspendLayout();
            // 
            // caloriesBar
            // 
            caloriesBar.ArcColor = Color.Gainsboro;
            caloriesBar.BackColor = Color.FloralWhite;
            caloriesBar.BorderSize = 15;
            caloriesBar.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            caloriesBar.ForeColor = Color.DarkViolet;
            caloriesBar.Location = new Point(233, 65);
            caloriesBar.MiddleCircleColor = Color.DarkViolet;
            caloriesBar.Name = "caloriesBar";
            caloriesBar.OuterCircleColor = Color.Transparent;
            caloriesBar.Size = new Size(226, 226);
            caloriesBar.TabIndex = 4;
            caloriesBar.ValueSize = 40F;
            // 
            // myPanel1
            // 
            myPanel1.BackColor = Color.Transparent;
            myPanel1.BorderColor = Color.Transparent;
            myPanel1.Enabled = false;
            myPanel1.Location = new Point(12, 12);
            myPanel1.Name = "myPanel1";
            myPanel1.PanelColor = Color.FloralWhite;
            myPanel1.Rad = 30;
            myPanel1.Size = new Size(1038, 649);
            myPanel1.TabIndex = 5;
            // 
            // proteinBar
            // 
            proteinBar.BackColor = Color.Gainsboro;
            proteinBar.Location = new Point(253, 371);
            proteinBar.MaxValue = 100;
            proteinBar.MinValue = 0;
            proteinBar.Name = "proteinBar";
            proteinBar.ProgressColor = Color.DarkViolet;
            proteinBar.Size = new Size(163, 13);
            proteinBar.TabIndex = 8;
            proteinBar.Text = "anotherProgBar1";
            proteinBar.Value = 46;
            // 
            // proteinLabel
            // 
            proteinLabel.AutoSize = true;
            proteinLabel.BackColor = Color.FloralWhite;
            proteinLabel.Font = new Font("Verdana", 11.8F, FontStyle.Bold);
            proteinLabel.Location = new Point(253, 334);
            proteinLabel.Name = "proteinLabel";
            proteinLabel.Size = new Size(81, 25);
            proteinLabel.TabIndex = 10;
            proteinLabel.Text = "Белки";
            // 
            // fatLabel
            // 
            fatLabel.AutoSize = true;
            fatLabel.BackColor = Color.FloralWhite;
            fatLabel.Font = new Font("Verdana", 11.8F, FontStyle.Bold);
            fatLabel.Location = new Point(253, 416);
            fatLabel.Name = "fatLabel";
            fatLabel.Size = new Size(81, 25);
            fatLabel.TabIndex = 12;
            fatLabel.Text = "Жиры";
            // 
            // fatBar
            // 
            fatBar.BackColor = Color.Gainsboro;
            fatBar.Location = new Point(253, 453);
            fatBar.MaxValue = 100;
            fatBar.MinValue = 0;
            fatBar.Name = "fatBar";
            fatBar.ProgressColor = Color.DarkViolet;
            fatBar.Size = new Size(163, 13);
            fatBar.TabIndex = 11;
            fatBar.Text = "anotherProgBar1";
            fatBar.Value = 37;
            // 
            // carbohydrateLabel
            // 
            carbohydrateLabel.AutoSize = true;
            carbohydrateLabel.BackColor = Color.FloralWhite;
            carbohydrateLabel.Font = new Font("Verdana", 11.8F, FontStyle.Bold);
            carbohydrateLabel.Location = new Point(253, 498);
            carbohydrateLabel.Name = "carbohydrateLabel";
            carbohydrateLabel.Size = new Size(126, 25);
            carbohydrateLabel.TabIndex = 14;
            carbohydrateLabel.Text = "Угдеводы";
            // 
            // carbohydratesBar
            // 
            carbohydratesBar.BackColor = Color.Gainsboro;
            carbohydratesBar.Location = new Point(253, 535);
            carbohydratesBar.MaxValue = 100;
            carbohydratesBar.MinValue = 0;
            carbohydratesBar.Name = "carbohydratesBar";
            carbohydratesBar.ProgressColor = Color.DarkViolet;
            carbohydratesBar.Size = new Size(163, 13);
            carbohydratesBar.TabIndex = 13;
            carbohydratesBar.Text = "anotherProgBar1";
            carbohydratesBar.Value = 79;
            // 
            // breakfastPanel
            // 
            breakfastPanel.BackColor = Color.FloralWhite;
            breakfastPanel.BorderColor = Color.Empty;
            breakfastPanel.Location = new Point(499, 46);
            breakfastPanel.Name = "breakfastPanel";
            breakfastPanel.PanelColor = Color.Gainsboro;
            breakfastPanel.Rad = 30;
            breakfastPanel.Size = new Size(465, 111);
            breakfastPanel.TabIndex = 15;
            // 
            // breakfastLabel
            // 
            breakfastLabel.AutoSize = true;
            breakfastLabel.BackColor = Color.Gainsboro;
            breakfastLabel.Enabled = false;
            breakfastLabel.Font = new Font("Verdana", 15.8F, FontStyle.Bold);
            breakfastLabel.Location = new Point(613, 73);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new Size(138, 32);
            breakfastLabel.TabIndex = 16;
            breakfastLabel.Text = "Завтрак";
            // 
            // breakfastIcon
            // 
            breakfastIcon.BackColor = Color.Gainsboro;
            breakfastIcon.BackgroundImage = (Image)resources.GetObject("breakfastIcon.BackgroundImage");
            breakfastIcon.BackgroundImageLayout = ImageLayout.Stretch;
            breakfastIcon.Enabled = false;
            breakfastIcon.Location = new Point(525, 65);
            breakfastIcon.Name = "breakfastIcon";
            breakfastIcon.Size = new Size(80, 80);
            breakfastIcon.TabIndex = 17;
            // 
            // breakfastsDiscription
            // 
            breakfastsDiscription.AutoSize = true;
            breakfastsDiscription.BackColor = Color.Gainsboro;
            breakfastsDiscription.Enabled = false;
            breakfastsDiscription.Font = new Font("Verdana", 10F);
            breakfastsDiscription.Location = new Point(617, 108);
            breakfastsDiscription.MaximumSize = new Size(240, 20);
            breakfastsDiscription.Name = "breakfastsDiscription";
            breakfastsDiscription.Size = new Size(238, 20);
            breakfastsDiscription.TabIndex = 18;
            breakfastsDiscription.Text = "Рекомендуется 470 ккал . .  . .";
            // 
            // breakfastAddButton
            // 
            breakfastAddButton.BackColor = Color.Gainsboro;
            breakfastAddButton.BorderColor = Color.Transparent;
            breakfastAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            breakfastAddButton.ForeColor = Color.DarkViolet;
            breakfastAddButton.Location = new Point(874, 73);
            breakfastAddButton.Name = "breakfastAddButton";
            breakfastAddButton.PanelColor = Color.LavenderBlush;
            breakfastAddButton.Rad = 60;
            breakfastAddButton.Size = new Size(60, 60);
            breakfastAddButton.TabIndex = 19;
            breakfastAddButton.Click += breakfastAddButton_Click;
            breakfastAddButton.MouseEnter += meal_MouseEnter;
            breakfastAddButton.MouseLeave += meal_MouseLeave;
            // 
            // lunchAddButton
            // 
            lunchAddButton.BackColor = Color.Gainsboro;
            lunchAddButton.BorderColor = Color.Transparent;
            lunchAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lunchAddButton.ForeColor = Color.DarkViolet;
            lunchAddButton.Location = new Point(874, 212);
            lunchAddButton.Name = "lunchAddButton";
            lunchAddButton.PanelColor = Color.LavenderBlush;
            lunchAddButton.Rad = 60;
            lunchAddButton.Size = new Size(60, 60);
            lunchAddButton.TabIndex = 25;
            lunchAddButton.Click += lunchAddButton_Click;
            lunchAddButton.MouseEnter += meal_MouseEnter;
            lunchAddButton.MouseLeave += meal_MouseLeave;
            // 
            // lunchDiscription
            // 
            lunchDiscription.AutoSize = true;
            lunchDiscription.BackColor = Color.Gainsboro;
            lunchDiscription.Enabled = false;
            lunchDiscription.Font = new Font("Verdana", 10F);
            lunchDiscription.Location = new Point(617, 247);
            lunchDiscription.MaximumSize = new Size(240, 20);
            lunchDiscription.Name = "lunchDiscription";
            lunchDiscription.Size = new Size(238, 20);
            lunchDiscription.TabIndex = 24;
            lunchDiscription.Text = "Рекомендуется 470 ккал . .  . .";
            // 
            // lunchIcon
            // 
            lunchIcon.BackColor = Color.Gainsboro;
            lunchIcon.BackgroundImage = (Image)resources.GetObject("lunchIcon.BackgroundImage");
            lunchIcon.BackgroundImageLayout = ImageLayout.Stretch;
            lunchIcon.Enabled = false;
            lunchIcon.Location = new Point(525, 204);
            lunchIcon.Name = "lunchIcon";
            lunchIcon.Size = new Size(80, 80);
            lunchIcon.TabIndex = 23;
            // 
            // lunchLabel
            // 
            lunchLabel.AutoSize = true;
            lunchLabel.BackColor = Color.Gainsboro;
            lunchLabel.Enabled = false;
            lunchLabel.Font = new Font("Verdana", 15.8F, FontStyle.Bold);
            lunchLabel.Location = new Point(613, 212);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new Size(93, 32);
            lunchLabel.TabIndex = 22;
            lunchLabel.Text = "Обед";
            // 
            // lunchPanel
            // 
            lunchPanel.BackColor = Color.FloralWhite;
            lunchPanel.BorderColor = Color.Empty;
            lunchPanel.Location = new Point(499, 185);
            lunchPanel.Name = "lunchPanel";
            lunchPanel.PanelColor = Color.Gainsboro;
            lunchPanel.Rad = 30;
            lunchPanel.Size = new Size(465, 111);
            lunchPanel.TabIndex = 21;
            // 
            // dinnerAddButton
            // 
            dinnerAddButton.BackColor = Color.Gainsboro;
            dinnerAddButton.BorderColor = Color.Transparent;
            dinnerAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dinnerAddButton.ForeColor = Color.DarkViolet;
            dinnerAddButton.Location = new Point(874, 353);
            dinnerAddButton.Name = "dinnerAddButton";
            dinnerAddButton.PanelColor = Color.LavenderBlush;
            dinnerAddButton.Rad = 60;
            dinnerAddButton.Size = new Size(60, 60);
            dinnerAddButton.TabIndex = 30;
            dinnerAddButton.Click += dinnerAddButton_Click;
            dinnerAddButton.MouseEnter += meal_MouseEnter;
            dinnerAddButton.MouseLeave += meal_MouseLeave;
            // 
            // dinnerDiscription
            // 
            dinnerDiscription.AutoSize = true;
            dinnerDiscription.BackColor = Color.Gainsboro;
            dinnerDiscription.Enabled = false;
            dinnerDiscription.Font = new Font("Verdana", 10F);
            dinnerDiscription.Location = new Point(617, 388);
            dinnerDiscription.MaximumSize = new Size(240, 20);
            dinnerDiscription.Name = "dinnerDiscription";
            dinnerDiscription.Size = new Size(238, 20);
            dinnerDiscription.TabIndex = 29;
            dinnerDiscription.Text = "Рекомендуется 470 ккал . .  . .";
            // 
            // dinnerIcon
            // 
            dinnerIcon.BackColor = Color.Gainsboro;
            dinnerIcon.BackgroundImage = (Image)resources.GetObject("dinnerIcon.BackgroundImage");
            dinnerIcon.BackgroundImageLayout = ImageLayout.Stretch;
            dinnerIcon.Enabled = false;
            dinnerIcon.Location = new Point(525, 343);
            dinnerIcon.Name = "dinnerIcon";
            dinnerIcon.Size = new Size(70, 70);
            dinnerIcon.TabIndex = 28;
            // 
            // dinnerLabel
            // 
            dinnerLabel.AutoSize = true;
            dinnerLabel.BackColor = Color.Gainsboro;
            dinnerLabel.Enabled = false;
            dinnerLabel.Font = new Font("Verdana", 15.8F, FontStyle.Bold);
            dinnerLabel.Location = new Point(613, 353);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new Size(99, 32);
            dinnerLabel.TabIndex = 27;
            dinnerLabel.Text = "Ужин";
            // 
            // dinnerPanel
            // 
            dinnerPanel.BackColor = Color.FloralWhite;
            dinnerPanel.BorderColor = Color.Empty;
            dinnerPanel.Location = new Point(499, 326);
            dinnerPanel.Name = "dinnerPanel";
            dinnerPanel.PanelColor = Color.Gainsboro;
            dinnerPanel.Rad = 30;
            dinnerPanel.Size = new Size(465, 111);
            dinnerPanel.TabIndex = 26;
            // 
            // extrafoodAddButton
            // 
            extrafoodAddButton.BackColor = Color.Gainsboro;
            extrafoodAddButton.BorderColor = Color.Transparent;
            extrafoodAddButton.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            extrafoodAddButton.ForeColor = Color.DarkViolet;
            extrafoodAddButton.Location = new Point(874, 495);
            extrafoodAddButton.Name = "extrafoodAddButton";
            extrafoodAddButton.PanelColor = Color.LavenderBlush;
            extrafoodAddButton.Rad = 60;
            extrafoodAddButton.Size = new Size(60, 60);
            extrafoodAddButton.TabIndex = 35;
            extrafoodAddButton.MouseEnter += meal_MouseEnter;
            extrafoodAddButton.MouseLeave += meal_MouseLeave;
            // 
            // extrafoodDiscription
            // 
            extrafoodDiscription.AutoSize = true;
            extrafoodDiscription.BackColor = Color.Gainsboro;
            extrafoodDiscription.Enabled = false;
            extrafoodDiscription.Font = new Font("Verdana", 10F);
            extrafoodDiscription.Location = new Point(617, 530);
            extrafoodDiscription.MaximumSize = new Size(240, 20);
            extrafoodDiscription.Name = "extrafoodDiscription";
            extrafoodDiscription.Size = new Size(238, 20);
            extrafoodDiscription.TabIndex = 34;
            extrafoodDiscription.Text = "Рекомендуется 470 ккал . .  . .";
            // 
            // extrafoodIcon
            // 
            extrafoodIcon.BackColor = Color.Gainsboro;
            extrafoodIcon.BackgroundImage = (Image)resources.GetObject("extrafoodIcon.BackgroundImage");
            extrafoodIcon.BackgroundImageLayout = ImageLayout.Stretch;
            extrafoodIcon.Enabled = false;
            extrafoodIcon.Location = new Point(525, 495);
            extrafoodIcon.Name = "extrafoodIcon";
            extrafoodIcon.Size = new Size(65, 65);
            extrafoodIcon.TabIndex = 33;
            // 
            // extrafoodLabel
            // 
            extrafoodLabel.AutoSize = true;
            extrafoodLabel.BackColor = Color.Gainsboro;
            extrafoodLabel.Enabled = false;
            extrafoodLabel.Font = new Font("Verdana", 15.8F, FontStyle.Bold);
            extrafoodLabel.Location = new Point(613, 495);
            extrafoodLabel.Name = "extrafoodLabel";
            extrafoodLabel.Size = new Size(169, 32);
            extrafoodLabel.TabIndex = 32;
            extrafoodLabel.Text = "Перекусы";
            // 
            // extrafoodPanel
            // 
            extrafoodPanel.BackColor = Color.FloralWhite;
            extrafoodPanel.BorderColor = Color.Empty;
            extrafoodPanel.Location = new Point(499, 468);
            extrafoodPanel.Name = "extrafoodPanel";
            extrafoodPanel.PanelColor = Color.Gainsboro;
            extrafoodPanel.Rad = 30;
            extrafoodPanel.Size = new Size(465, 111);
            extrafoodPanel.TabIndex = 31;
            // 
            // proteinValueLabel
            // 
            proteinValueLabel.BackColor = Color.FloralWhite;
            proteinValueLabel.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            proteinValueLabel.Location = new Point(306, 387);
            proteinValueLabel.Name = "proteinValueLabel";
            proteinValueLabel.Size = new Size(110, 20);
            proteinValueLabel.TabIndex = 36;
            proteinValueLabel.Text = "708 / 120 г";
            proteinValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fatValueLabel
            // 
            fatValueLabel.BackColor = Color.FloralWhite;
            fatValueLabel.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fatValueLabel.Location = new Point(306, 469);
            fatValueLabel.Name = "fatValueLabel";
            fatValueLabel.Size = new Size(110, 20);
            fatValueLabel.TabIndex = 37;
            fatValueLabel.Text = "58 / 80 г";
            fatValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // carboValueLabel
            // 
            carboValueLabel.BackColor = Color.FloralWhite;
            carboValueLabel.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            carboValueLabel.Location = new Point(306, 551);
            carboValueLabel.Name = "carboValueLabel";
            carboValueLabel.Size = new Size(110, 20);
            carboValueLabel.TabIndex = 38;
            carboValueLabel.Text = "256 / 389 г";
            carboValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // caloriesValueLabel
            // 
            caloriesValueLabel.BackColor = Color.FloralWhite;
            caloriesValueLabel.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            caloriesValueLabel.Location = new Point(253, 42);
            caloriesValueLabel.Name = "caloriesValueLabel";
            caloriesValueLabel.Size = new Size(180, 20);
            caloriesValueLabel.TabIndex = 39;
            caloriesValueLabel.Text = "Цель - 2453 ккал";
            caloriesValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DailyCounter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 673);
            Controls.Add(caloriesValueLabel);
            Controls.Add(carboValueLabel);
            Controls.Add(fatValueLabel);
            Controls.Add(proteinValueLabel);
            Controls.Add(extrafoodAddButton);
            Controls.Add(extrafoodDiscription);
            Controls.Add(extrafoodIcon);
            Controls.Add(extrafoodLabel);
            Controls.Add(extrafoodPanel);
            Controls.Add(dinnerAddButton);
            Controls.Add(dinnerDiscription);
            Controls.Add(dinnerIcon);
            Controls.Add(dinnerLabel);
            Controls.Add(dinnerPanel);
            Controls.Add(lunchAddButton);
            Controls.Add(lunchDiscription);
            Controls.Add(lunchIcon);
            Controls.Add(lunchLabel);
            Controls.Add(lunchPanel);
            Controls.Add(breakfastAddButton);
            Controls.Add(breakfastsDiscription);
            Controls.Add(breakfastIcon);
            Controls.Add(breakfastLabel);
            Controls.Add(breakfastPanel);
            Controls.Add(carbohydrateLabel);
            Controls.Add(carbohydratesBar);
            Controls.Add(fatLabel);
            Controls.Add(fatBar);
            Controls.Add(proteinLabel);
            Controls.Add(proteinBar);
            Controls.Add(caloriesBar);
            Controls.Add(myPanel1);
            Name = "DailyCounter";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += MainMenu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FormControls.CircularProgressBar caloriesBar;
        private FormControls.MyPanel myPanel1;
        private FormControls.AnotherProgBar proteinBar;
        private Label proteinLabel;
        private Label fatLabel;
        private FormControls.AnotherProgBar fatBar;
        private Label carbohydrateLabel;
        private FormControls.AnotherProgBar carbohydratesBar;
        private FormControls.MyPanel breakfastPanel;
        private Label breakfastLabel;
        private Panel breakfastIcon;
        private Label breakfastsDiscription;
        private FormControls.MyPanel breakfastAddButton;
        private FormControls.MyPanel lunchAddButton;
        private Label lunchDiscription;
        private Panel lunchIcon;
        private Label lunchLabel;
        private FormControls.MyPanel lunchPanel;
        private FormControls.MyPanel dinnerAddButton;
        private Label dinnerDiscription;
        private Panel dinnerIcon;
        private Label dinnerLabel;
        private FormControls.MyPanel dinnerPanel;
        private FormControls.MyPanel extrafoodAddButton;
        private Label extrafoodDiscription;
        private Panel extrafoodIcon;
        private Label extrafoodLabel;
        private FormControls.MyPanel extrafoodPanel;
        private Label proteinValueLabel;
        private Label fatValueLabel;
        private Label carboValueLabel;
        private Label caloriesValueLabel;
    }
}