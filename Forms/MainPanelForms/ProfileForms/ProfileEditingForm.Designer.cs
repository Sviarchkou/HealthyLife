namespace HealthyLife_Pt2.Forms.MainPanelForms.Profile
{
    partial class ProfileEditingForm
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
            goalTextLabel = new Label();
            activityLevelTextLabel = new Label();
            sexTextLabel = new Label();
            ageTextLabel = new Label();
            currentWeightTextLabel = new Label();
            heightTextLabel = new Label();
            pictureBox = new PictureBox();
            goalComboBox = new ComboBox();
            activityComboBox = new ComboBox();
            sexComboBox = new ComboBox();
            weightTextBox = new TextBox();
            heightTextBox = new TextBox();
            loginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            saveButton = new Button();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // goalTextLabel
            // 
            goalTextLabel.AutoSize = true;
            goalTextLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            goalTextLabel.Location = new Point(20, 292);
            goalTextLabel.Name = "goalTextLabel";
            goalTextLabel.Size = new Size(62, 25);
            goalTextLabel.TabIndex = 27;
            goalTextLabel.Text = "Цель";
            // 
            // activityLevelTextLabel
            // 
            activityLevelTextLabel.AutoSize = true;
            activityLevelTextLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            activityLevelTextLabel.Location = new Point(18, 225);
            activityLevelTextLabel.Name = "activityLevelTextLabel";
            activityLevelTextLabel.Size = new Size(221, 25);
            activityLevelTextLabel.TabIndex = 25;
            activityLevelTextLabel.Text = "Уровень активности";
            // 
            // sexTextLabel
            // 
            sexTextLabel.AutoSize = true;
            sexTextLabel.BackColor = Color.FloralWhite;
            sexTextLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexTextLabel.Location = new Point(20, 156);
            sexTextLabel.Name = "sexTextLabel";
            sexTextLabel.Size = new Size(51, 25);
            sexTextLabel.TabIndex = 24;
            sexTextLabel.Text = "Пол";
            // 
            // ageTextLabel
            // 
            ageTextLabel.AutoSize = true;
            ageTextLabel.BackColor = Color.FloralWhite;
            ageTextLabel.Font = new Font("Verdana", 12F);
            ageTextLabel.Location = new Point(312, 85);
            ageTextLabel.Name = "ageTextLabel";
            ageTextLabel.Size = new Size(170, 25);
            ageTextLabel.TabIndex = 22;
            ageTextLabel.Text = "Дата рождения";
            // 
            // currentWeightTextLabel
            // 
            currentWeightTextLabel.AutoSize = true;
            currentWeightTextLabel.BackColor = Color.FloralWhite;
            currentWeightTextLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentWeightTextLabel.Location = new Point(18, 85);
            currentWeightTextLabel.Name = "currentWeightTextLabel";
            currentWeightTextLabel.Size = new Size(146, 25);
            currentWeightTextLabel.TabIndex = 18;
            currentWeightTextLabel.Text = "Текущий вес";
            // 
            // heightTextLabel
            // 
            heightTextLabel.AutoSize = true;
            heightTextLabel.BackColor = Color.FloralWhite;
            heightTextLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            heightTextLabel.Location = new Point(182, 85);
            heightTextLabel.Name = "heightTextLabel";
            heightTextLabel.Size = new Size(57, 25);
            heightTextLabel.TabIndex = 17;
            heightTextLabel.Text = "Рост";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FloralWhite;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Image = Properties.Resources.user;
            pictureBox.Location = new Point(314, 184);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(179, 164);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 15;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // goalComboBox
            // 
            goalComboBox.BackColor = Color.White;
            goalComboBox.Font = new Font("Verdana", 10.2F);
            goalComboBox.FormattingEnabled = true;
            goalComboBox.Items.AddRange(new object[] { "Похудение", "Поддержание веса", "Набор массы" });
            goalComboBox.Location = new Point(20, 320);
            goalComboBox.Name = "goalComboBox";
            goalComboBox.Size = new Size(248, 28);
            goalComboBox.TabIndex = 104;
            // 
            // activityComboBox
            // 
            activityComboBox.BackColor = Color.White;
            activityComboBox.Font = new Font("Verdana", 10.2F);
            activityComboBox.FormattingEnabled = true;
            activityComboBox.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            activityComboBox.Location = new Point(18, 253);
            activityComboBox.Name = "activityComboBox";
            activityComboBox.Size = new Size(250, 28);
            activityComboBox.TabIndex = 105;
            // 
            // sexComboBox
            // 
            sexComboBox.BackColor = Color.White;
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Мужской", "Женский", "Другое" });
            sexComboBox.Location = new Point(20, 184);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(248, 28);
            sexComboBox.TabIndex = 106;
            // 
            // weightTextBox
            // 
            weightTextBox.BackColor = Color.White;
            weightTextBox.Location = new Point(20, 114);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(60, 27);
            weightTextBox.TabIndex = 107;
            // 
            // heightTextBox
            // 
            heightTextBox.BackColor = Color.White;
            heightTextBox.Location = new Point(182, 114);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(60, 27);
            heightTextBox.TabIndex = 108;
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = Color.White;
            loginTextBox.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            loginTextBox.Location = new Point(159, 20);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(347, 40);
            loginTextBox.TabIndex = 110;
            loginTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 34);
            label1.TabIndex = 111;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(312, 156);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 113;
            label2.Text = "Фото";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(192, 255, 192);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(109, 388);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(297, 44);
            saveButton.TabIndex = 114;
            saveButton.Text = "Сохранить изменения";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(314, 113);
            dateTimePicker.MaxDate = new DateTime(2024, 12, 11, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(1944, 12, 11, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(179, 27);
            dateTimePicker.TabIndex = 115;
            dateTimePicker.Value = new DateTime(2024, 12, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Verdana", 10F);
            label3.Location = new Point(242, 117);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 116;
            label3.Text = "см";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Verdana", 10F);
            label4.Location = new Point(80, 117);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 117;
            label4.Text = "кг";
            // 
            // ProfileEditingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(518, 444);
            Controls.Add(label4);
            Controls.Add(dateTimePicker);
            Controls.Add(saveButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(sexComboBox);
            Controls.Add(activityComboBox);
            Controls.Add(goalComboBox);
            Controls.Add(goalTextLabel);
            Controls.Add(activityLevelTextLabel);
            Controls.Add(sexTextLabel);
            Controls.Add(ageTextLabel);
            Controls.Add(currentWeightTextLabel);
            Controls.Add(heightTextLabel);
            Controls.Add(pictureBox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ProfileEditingForm";
            Load += ProfileEditingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label goalTextLabel;
        private Label activityLevelTextLabel;
        private Label sexTextLabel;
        private Label ageTextLabel;
        private Label currentWeightTextLabel;
        private Label heightTextLabel;
        private PictureBox pictureBox;
        private ComboBox goalComboBox;
        private ComboBox activityComboBox;
        private ComboBox sexComboBox;
        private TextBox weightTextBox;
        private TextBox heightTextBox;
        private TextBox loginTextBox;
        private Label label1;
        private Label label2;
        private Button saveButton;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private Label label4;
    }
}