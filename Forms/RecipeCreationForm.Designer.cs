namespace HealthyLIfe_Pt2.Forms
{
    partial class RecipeCreationForm
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
            panel5 = new Panel();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            myPanel6 = new HealthyLife_Pt2.FormControls.MyPanel();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            myPanel2 = new HealthyLife_Pt2.FormControls.MyPanel();
            addIngredientPanel = new HealthyLife_Pt2.FormControls.MyPanel();
            anotherProgBar1 = new HealthyLife_Pt2.FormControls.AnotherProgBar();
            label11 = new Label();
            myPanel5 = new HealthyLife_Pt2.FormControls.MyPanel();
            label6 = new Label();
            myPanel3 = new HealthyLife_Pt2.FormControls.MyPanel();
            label4 = new Label();
            carboLabel = new Label();
            fatsLabel = new Label();
            myPanel1 = new HealthyLife_Pt2.FormControls.MyPanel();
            caloriesLabel = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            myPanel4 = new HealthyLife_Pt2.FormControls.MyPanel();
            proteinsLabel = new Label();
            caloriesCounter = new Label();
            proteinCounter = new Label();
            fatsCounter = new Label();
            carboCounter = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Enabled = false;
            panel5.Location = new Point(56, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(342, 1);
            panel5.TabIndex = 89;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Verdana", 12F);
            descriptionLabel.Location = new Point(51, 118);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(115, 25);
            descriptionLabel.TabIndex = 85;
            descriptionLabel.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.Gainsboro;
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Font = new Font("Verdana", 11F);
            descriptionTextBox.Location = new Point(51, 163);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(345, 225);
            descriptionTextBox.TabIndex = 83;
            descriptionTextBox.TabStop = false;
            descriptionTextBox.Text = "Поиск";
            // 
            // myPanel6
            // 
            myPanel6.BackColor = Color.Transparent;
            myPanel6.BorderColor = Color.Transparent;
            myPanel6.Location = new Point(28, 146);
            myPanel6.Name = "myPanel6";
            myPanel6.PanelColor = Color.Gainsboro;
            myPanel6.Rad = 50;
            myPanel6.Size = new Size(392, 261);
            myPanel6.TabIndex = 84;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(51, 17);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(111, 25);
            nameLabel.TabIndex = 82;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.Gainsboro;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Verdana", 11F);
            nameTextBox.Location = new Point(56, 58);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(340, 23);
            nameTextBox.TabIndex = 80;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "Поиск";
            // 
            // myPanel2
            // 
            myPanel2.BackColor = Color.Transparent;
            myPanel2.BorderColor = Color.Transparent;
            myPanel2.Location = new Point(28, 45);
            myPanel2.Name = "myPanel2";
            myPanel2.PanelColor = Color.Gainsboro;
            myPanel2.Rad = 50;
            myPanel2.Size = new Size(392, 50);
            myPanel2.TabIndex = 81;
            // 
            // addIngredientPanel
            // 
            addIngredientPanel.BorderColor = Color.DarkGray;
            addIngredientPanel.Font = new Font("Verdana", 11F, FontStyle.Bold);
            addIngredientPanel.ForeColor = Color.DarkViolet;
            addIngredientPanel.Location = new Point(470, 155);
            addIngredientPanel.Margin = new Padding(10);
            addIngredientPanel.Name = "addIngredientPanel";
            addIngredientPanel.Padding = new Padding(10);
            addIngredientPanel.PanelColor = Color.Gainsboro;
            addIngredientPanel.Rad = 30;
            addIngredientPanel.Size = new Size(471, 38);
            addIngredientPanel.TabIndex = 105;
            addIngredientPanel.Click += addIngredientPanel_Click;
            addIngredientPanel.MouseEnter += addIngredientPanel_MouseEnter;
            addIngredientPanel.MouseLeave += addIngredientPanel_MouseLeave;
            // 
            // anotherProgBar1
            // 
            anotherProgBar1.Location = new Point(470, 42);
            anotherProgBar1.MaxValue = 100;
            anotherProgBar1.MinValue = 0;
            anotherProgBar1.Name = "anotherProgBar1";
            anotherProgBar1.ProgressColor = Color.DarkViolet;
            anotherProgBar1.Size = new Size(471, 100);
            anotherProgBar1.TabIndex = 107;
            anotherProgBar1.Text = "anotherProgBar1";
            anotherProgBar1.Value = 100;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Verdana", 10F);
            label11.Location = new Point(242, 494);
            label11.Name = "label11";
            label11.Size = new Size(23, 20);
            label11.TabIndex = 123;
            label11.Text = "г.";
            // 
            // myPanel5
            // 
            myPanel5.BackColor = Color.Transparent;
            myPanel5.BorderColor = Color.Transparent;
            myPanel5.Location = new Point(188, 485);
            myPanel5.Name = "myPanel5";
            myPanel5.PanelColor = Color.Gainsboro;
            myPanel5.Rad = 40;
            myPanel5.Size = new Size(87, 40);
            myPanel5.TabIndex = 122;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Verdana", 10F);
            label6.Location = new Point(242, 586);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 120;
            label6.Text = "г.";
            // 
            // myPanel3
            // 
            myPanel3.BackColor = Color.Transparent;
            myPanel3.BorderColor = Color.Transparent;
            myPanel3.Location = new Point(188, 577);
            myPanel3.Name = "myPanel3";
            myPanel3.PanelColor = Color.Gainsboro;
            myPanel3.Rad = 40;
            myPanel3.Size = new Size(87, 40);
            myPanel3.TabIndex = 119;
            // 
            // label4
            // 
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Verdana", 10F);
            label4.Location = new Point(211, 448);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 117;
            label4.Text = "ккал.";
            // 
            // carboLabel
            // 
            carboLabel.AutoSize = true;
            carboLabel.Font = new Font("Verdana", 10F);
            carboLabel.Location = new Point(41, 586);
            carboLabel.Name = "carboLabel";
            carboLabel.Size = new Size(93, 20);
            carboLabel.TabIndex = 113;
            carboLabel.Text = "Углеводы";
            // 
            // fatsLabel
            // 
            fatsLabel.AutoSize = true;
            fatsLabel.Font = new Font("Verdana", 10F);
            fatsLabel.Location = new Point(41, 540);
            fatsLabel.Name = "fatsLabel";
            fatsLabel.Size = new Size(62, 20);
            fatsLabel.TabIndex = 112;
            fatsLabel.Text = "Жиры";
            // 
            // myPanel1
            // 
            myPanel1.BackColor = Color.Transparent;
            myPanel1.BorderColor = Color.Transparent;
            myPanel1.Location = new Point(153, 439);
            myPanel1.Name = "myPanel1";
            myPanel1.PanelColor = Color.Gainsboro;
            myPanel1.Rad = 40;
            myPanel1.Size = new Size(122, 40);
            myPanel1.TabIndex = 110;
            // 
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Font = new Font("Verdana", 10F);
            caloriesLabel.Location = new Point(41, 448);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(96, 20);
            caloriesLabel.TabIndex = 108;
            caloriesLabel.Text = "Каллории";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(298, 494);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 124;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Verdana", 10F);
            label5.Location = new Point(242, 540);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 127;
            label5.Text = "г.";
            // 
            // myPanel4
            // 
            myPanel4.BackColor = Color.Transparent;
            myPanel4.BorderColor = Color.Transparent;
            myPanel4.Location = new Point(188, 531);
            myPanel4.Name = "myPanel4";
            myPanel4.PanelColor = Color.Gainsboro;
            myPanel4.Rad = 40;
            myPanel4.Size = new Size(87, 40);
            myPanel4.TabIndex = 126;
            // 
            // proteinsLabel
            // 
            proteinsLabel.AutoSize = true;
            proteinsLabel.Font = new Font("Verdana", 10F);
            proteinsLabel.Location = new Point(41, 494);
            proteinsLabel.Name = "proteinsLabel";
            proteinsLabel.Size = new Size(63, 20);
            proteinsLabel.TabIndex = 125;
            proteinsLabel.Text = "Белки";
            // 
            // caloriesCounter
            // 
            caloriesCounter.BackColor = Color.Gainsboro;
            caloriesCounter.Font = new Font("Verdana", 10F);
            caloriesCounter.Location = new Point(162, 448);
            caloriesCounter.Name = "caloriesCounter";
            caloriesCounter.Size = new Size(53, 20);
            caloriesCounter.TabIndex = 128;
            caloriesCounter.Text = "785";
            caloriesCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // proteinCounter
            // 
            proteinCounter.BackColor = Color.Gainsboro;
            proteinCounter.Font = new Font("Verdana", 10F);
            proteinCounter.Location = new Point(196, 494);
            proteinCounter.Name = "proteinCounter";
            proteinCounter.Size = new Size(49, 20);
            proteinCounter.TabIndex = 129;
            proteinCounter.Text = "60";
            proteinCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fatsCounter
            // 
            fatsCounter.BackColor = Color.Gainsboro;
            fatsCounter.Font = new Font("Verdana", 10F);
            fatsCounter.Location = new Point(196, 540);
            fatsCounter.Name = "fatsCounter";
            fatsCounter.Size = new Size(49, 20);
            fatsCounter.TabIndex = 130;
            fatsCounter.Text = "40";
            fatsCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // carboCounter
            // 
            carboCounter.BackColor = Color.Gainsboro;
            carboCounter.Font = new Font("Verdana", 10F);
            carboCounter.Location = new Point(196, 586);
            carboCounter.Name = "carboCounter";
            carboCounter.Size = new Size(49, 20);
            carboCounter.TabIndex = 131;
            carboCounter.Text = "450";
            carboCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F);
            label1.Location = new Point(323, 597);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 132;
            label1.Text = "Фото";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F);
            button1.Location = new Point(298, 439);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 133;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Dock = DockStyle.Bottom;
            button2.Font = new Font("Verdana", 14F, FontStyle.Bold);
            button2.ForeColor = Color.DarkViolet;
            button2.Location = new Point(0, 665);
            button2.Name = "button2";
            button2.Size = new Size(970, 42);
            button2.TabIndex = 134;
            button2.Text = "Создать этот рецепт";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RecipeCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(970, 707);
            Controls.Add(addIngredientPanel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(carboCounter);
            Controls.Add(fatsCounter);
            Controls.Add(proteinCounter);
            Controls.Add(caloriesCounter);
            Controls.Add(label5);
            Controls.Add(myPanel4);
            Controls.Add(proteinsLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(myPanel5);
            Controls.Add(label6);
            Controls.Add(myPanel3);
            Controls.Add(label4);
            Controls.Add(carboLabel);
            Controls.Add(fatsLabel);
            Controls.Add(myPanel1);
            Controls.Add(caloriesLabel);
            Controls.Add(anotherProgBar1);
            Controls.Add(panel5);
            Controls.Add(descriptionLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(myPanel6);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(myPanel2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(700, 520);
            Name = "RecipeCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeCreationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private HealthyLife_Pt2.FormControls.MyPanel myPanel6;
        private Label nameLabel;
        private TextBox nameTextBox;
        private HealthyLife_Pt2.FormControls.MyPanel myPanel2;
        private HealthyLife_Pt2.FormControls.MyPanel addIngredientPanel;
        private HealthyLife_Pt2.FormControls.AnotherProgBar anotherProgBar1;
        private Label label11;
        private HealthyLife_Pt2.FormControls.MyPanel myPanel5;
        private Label label6;
        private HealthyLife_Pt2.FormControls.MyPanel myPanel3;
        private Label label4;
        private Label carboLabel;
        private Label fatsLabel;
        private HealthyLife_Pt2.FormControls.MyPanel myPanel1;
        private Label caloriesLabel;
        private PictureBox pictureBox1;
        private Label label5;
        private HealthyLife_Pt2.FormControls.MyPanel myPanel4;
        private Label proteinsLabel;
        private Label caloriesCounter;
        private Label proteinCounter;
        private Label fatsCounter;
        private Label carboCounter;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}