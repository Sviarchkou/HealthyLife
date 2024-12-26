namespace HealthyLife_Pt2.Forms.MealForms
{
    partial class DietCreationForm
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
            myPanel6 = new FormControls.MyPanel();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            myPanel2 = new FormControls.MyPanel();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            addMealButton = new FormControls.MyPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Enabled = false;
            panel5.Location = new Point(65, 89);
            panel5.Name = "panel5";
            panel5.Size = new Size(342, 1);
            panel5.TabIndex = 96;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Verdana", 12F);
            descriptionLabel.Location = new Point(60, 117);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(115, 25);
            descriptionLabel.TabIndex = 95;
            descriptionLabel.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.Gainsboro;
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Font = new Font("Verdana", 11F);
            descriptionTextBox.Location = new Point(60, 162);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(345, 214);
            descriptionTextBox.TabIndex = 93;
            descriptionTextBox.TabStop = false;
            // 
            // myPanel6
            // 
            myPanel6.BackColor = Color.Transparent;
            myPanel6.BorderColor = Color.Transparent;
            myPanel6.Location = new Point(37, 145);
            myPanel6.Name = "myPanel6";
            myPanel6.PanelColor = Color.Gainsboro;
            myPanel6.Rad = 50;
            myPanel6.Size = new Size(392, 250);
            myPanel6.TabIndex = 94;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(60, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(111, 25);
            nameLabel.TabIndex = 92;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.Gainsboro;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Verdana", 11F);
            nameTextBox.Location = new Point(65, 63);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(340, 23);
            nameTextBox.TabIndex = 90;
            nameTextBox.TabStop = false;
            // 
            // myPanel2
            // 
            myPanel2.BackColor = Color.Transparent;
            myPanel2.BorderColor = Color.Transparent;
            myPanel2.Location = new Point(37, 50);
            myPanel2.Name = "myPanel2";
            myPanel2.PanelColor = Color.Gainsboro;
            myPanel2.Rad = 50;
            myPanel2.Size = new Size(392, 50);
            myPanel2.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F);
            label1.Location = new Point(185, 413);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 101;
            label1.Text = "Цель диеты";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.Font = new Font("Verdana", 11F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Items.AddRange(new object[] { "Похудение", "Поддержание веса", "Набор массы" });
            listBox1.Location = new Point(185, 445);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(222, 70);
            listBox1.TabIndex = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F);
            label2.Location = new Point(65, 413);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 134;
            label2.Text = "Фото";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(37, 445);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 133;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.DarkViolet;
            button1.Location = new Point(0, 581);
            button1.Margin = new Padding(0, 20, 0, 0);
            button1.Name = "button1";
            button1.Size = new Size(1341, 50);
            button1.TabIndex = 135;
            button1.Text = "Создать этот рацион питания";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addMealButton
            // 
            addMealButton.BorderColor = Color.DarkGray;
            addMealButton.Font = new Font("Verdana", 11F, FontStyle.Bold);
            addMealButton.ForeColor = Color.DarkViolet;
            addMealButton.Location = new Point(460, 410);
            addMealButton.Margin = new Padding(10);
            addMealButton.Name = "addMealButton";
            addMealButton.Padding = new Padding(10);
            addMealButton.PanelColor = Color.Gainsboro;
            addMealButton.Rad = 38;
            addMealButton.Size = new Size(414, 38);
            addMealButton.TabIndex = 136;
            addMealButton.Click += addMealButton_Click;
            addMealButton.MouseEnter += addMealButton_MouseEnter;
            addMealButton.MouseLeave += addMealButton_MouseLeave;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 562);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 19);
            panel1.TabIndex = 137;
            // 
            // DietCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1362, 628);
            Controls.Add(panel1);
            Controls.Add(addMealButton);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(descriptionLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(myPanel6);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(myPanel2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DietCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private FormControls.MyPanel myPanel6;
        private Label nameLabel;
        private TextBox nameTextBox;
        private FormControls.MyPanel myPanel2;
        private FormControls.MealControls.MealAddition mealAddition1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private FormControls.MyPanel addMealButton;
        private Panel panel1;
    }
}