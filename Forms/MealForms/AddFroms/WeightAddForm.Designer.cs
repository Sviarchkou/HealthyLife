namespace HealthyLife_Pt2.Forms.MealForms.AddFroms
{
    partial class WeightAddForm
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
            addButton = new FormControls.MyPanel();
            label1 = new Label();
            panel7 = new Panel();
            weightTextBox = new TextBox();
            myPanel7 = new FormControls.MyPanel();
            weightLabel = new Label();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.Transparent;
            addButton.BorderColor = Color.Transparent;
            addButton.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(51, 100);
            addButton.Name = "addButton";
            addButton.PanelColor = Color.Gainsboro;
            addButton.Rad = 40;
            addButton.Size = new Size(156, 40);
            addButton.TabIndex = 95;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F);
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 93;
            label1.Text = "Дата";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Enabled = false;
            panel7.Location = new Point(28, 65);
            panel7.Name = "panel7";
            panel7.Size = new Size(40, 1);
            panel7.TabIndex = 92;
            // 
            // weightTextBox
            // 
            weightTextBox.BackColor = Color.Gainsboro;
            weightTextBox.BorderStyle = BorderStyle.None;
            weightTextBox.Font = new Font("Verdana", 10F);
            weightTextBox.Location = new Point(28, 44);
            weightTextBox.MaximumSize = new Size(40, 25);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(40, 21);
            weightTextBox.TabIndex = 90;
            weightTextBox.TabStop = false;
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // myPanel7
            // 
            myPanel7.BackColor = Color.Transparent;
            myPanel7.BorderColor = Color.Transparent;
            myPanel7.Location = new Point(15, 35);
            myPanel7.Name = "myPanel7";
            myPanel7.PanelColor = Color.Gainsboro;
            myPanel7.Rad = 40;
            myPanel7.Size = new Size(87, 40);
            myPanel7.TabIndex = 91;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Verdana", 11F);
            weightLabel.Location = new Point(37, 9);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(44, 23);
            weightLabel.TabIndex = 89;
            weightLabel.Text = "Вес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Verdana", 10F);
            label2.Location = new Point(67, 44);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 97;
            label2.Text = "кг";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(125, 42);
            dateTimePicker.MaxDate = new DateTime(2024, 12, 9, 15, 54, 59, 351);
            dateTimePicker.MinDate = new DateTime(2023, 12, 9, 15, 54, 59, 352);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(119, 26);
            dateTimePicker.TabIndex = 99;
            dateTimePicker.Value = new DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // WeightAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(257, 167);
            Controls.Add(dateTimePicker);
            Controls.Add(label2);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(weightTextBox);
            Controls.Add(myPanel7);
            Controls.Add(weightLabel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "WeightAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FormControls.MyPanel addButton;
        private Label label1;
        private Panel panel7;
        private TextBox weightTextBox;
        private FormControls.MyPanel myPanel7;
        private Label weightLabel;
        private Label label2;
        private DateTimePicker dateTimePicker;
    }
}