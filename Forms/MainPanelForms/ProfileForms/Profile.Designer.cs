namespace HealthyLife_Pt2.Forms.MainPanelForms.ProfileForms
{
    partial class Profile
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
            pictureBox = new PictureBox();
            loginLabel = new Label();
            heightTextLabel = new Label();
            currentWeightTextLabel = new Label();
            sexLabel = new Label();
            heightLabel = new Label();
            currentWeightLabel = new Label();
            ageTextLabel = new Label();
            ageLabel = new Label();
            sexTextLabel = new Label();
            activityLevelLabel = new Label();
            activityLevelTextLabel = new Label();
            goalLabel = new Label();
            goalTextLabel = new Label();
            recipeButton = new Button();
            dietButton = new Button();
            panel1 = new Panel();
            editButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Image = Properties.Resources.user;
            pictureBox.Location = new Point(33, 32);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(208, 210);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(262, 32);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(113, 34);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин";
            // 
            // heightTextLabel
            // 
            heightTextLabel.AutoSize = true;
            heightTextLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            heightTextLabel.Location = new Point(536, 117);
            heightTextLabel.Name = "heightTextLabel";
            heightTextLabel.Size = new Size(64, 25);
            heightTextLabel.TabIndex = 2;
            heightTextLabel.Text = "Рост";
            // 
            // currentWeightTextLabel
            // 
            currentWeightTextLabel.AutoSize = true;
            currentWeightTextLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            currentWeightTextLabel.Location = new Point(262, 117);
            currentWeightTextLabel.Name = "currentWeightTextLabel";
            currentWeightTextLabel.Size = new Size(159, 25);
            currentWeightTextLabel.TabIndex = 3;
            currentWeightTextLabel.Text = "Текущий вес";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(663, 142);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(66, 25);
            sexLabel.TabIndex = 4;
            sexLabel.Text = "Login";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            heightLabel.Location = new Point(536, 142);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(74, 25);
            heightLabel.TabIndex = 6;
            heightLabel.Text = "Логин";
            // 
            // currentWeightLabel
            // 
            currentWeightLabel.AutoSize = true;
            currentWeightLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentWeightLabel.Location = new Point(262, 142);
            currentWeightLabel.Name = "currentWeightLabel";
            currentWeightLabel.Size = new Size(74, 25);
            currentWeightLabel.TabIndex = 7;
            currentWeightLabel.Text = "Логин";
            // 
            // ageTextLabel
            // 
            ageTextLabel.AutoSize = true;
            ageTextLabel.Font = new Font("Verdana", 11F);
            ageTextLabel.Location = new Point(262, 66);
            ageTextLabel.Name = "ageTextLabel";
            ageTextLabel.Size = new Size(96, 23);
            ageTextLabel.TabIndex = 8;
            ageTextLabel.Text = "Возраст:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Verdana", 11F);
            ageLabel.Location = new Point(355, 66);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(34, 23);
            ageLabel.TabIndex = 9;
            ageLabel.Text = "23";
            // 
            // sexTextLabel
            // 
            sexTextLabel.AutoSize = true;
            sexTextLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            sexTextLabel.Location = new Point(663, 117);
            sexTextLabel.Name = "sexTextLabel";
            sexTextLabel.Size = new Size(57, 25);
            sexTextLabel.TabIndex = 10;
            sexTextLabel.Text = "Пол";
            // 
            // activityLevelLabel
            // 
            activityLevelLabel.AutoSize = true;
            activityLevelLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            activityLevelLabel.Location = new Point(262, 217);
            activityLevelLabel.Name = "activityLevelLabel";
            activityLevelLabel.Size = new Size(74, 25);
            activityLevelLabel.TabIndex = 12;
            activityLevelLabel.Text = "Логин";
            // 
            // activityLevelTextLabel
            // 
            activityLevelTextLabel.AutoSize = true;
            activityLevelTextLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            activityLevelTextLabel.Location = new Point(262, 192);
            activityLevelTextLabel.Name = "activityLevelTextLabel";
            activityLevelTextLabel.Size = new Size(246, 25);
            activityLevelTextLabel.TabIndex = 11;
            activityLevelTextLabel.Text = "Уровень активности";
            // 
            // goalLabel
            // 
            goalLabel.AutoSize = true;
            goalLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            goalLabel.Location = new Point(536, 217);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new Size(74, 25);
            goalLabel.TabIndex = 14;
            goalLabel.Text = "Логин";
            // 
            // goalTextLabel
            // 
            goalTextLabel.AutoSize = true;
            goalTextLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            goalTextLabel.Location = new Point(536, 192);
            goalTextLabel.Name = "goalTextLabel";
            goalTextLabel.Size = new Size(69, 25);
            goalTextLabel.TabIndex = 13;
            goalTextLabel.Text = "Цель";
            // 
            // recipeButton
            // 
            recipeButton.BackColor = Color.Gainsboro;
            recipeButton.FlatAppearance.BorderSize = 0;
            recipeButton.FlatStyle = FlatStyle.Flat;
            recipeButton.Font = new Font("Verdana", 10.8F);
            recipeButton.Location = new Point(33, 261);
            recipeButton.Margin = new Padding(0);
            recipeButton.Name = "recipeButton";
            recipeButton.Size = new Size(199, 38);
            recipeButton.TabIndex = 17;
            recipeButton.Text = "Мои рецепты";
            recipeButton.UseVisualStyleBackColor = false;
            recipeButton.Click += recipeButton_Click;
            // 
            // dietButton
            // 
            dietButton.BackColor = Color.Gainsboro;
            dietButton.FlatAppearance.BorderSize = 0;
            dietButton.FlatStyle = FlatStyle.Flat;
            dietButton.Font = new Font("Verdana", 10.8F);
            dietButton.Location = new Point(241, 261);
            dietButton.Margin = new Padding(0);
            dietButton.Name = "dietButton";
            dietButton.Size = new Size(199, 38);
            dietButton.TabIndex = 18;
            dietButton.Text = "Мои диеты";
            dietButton.UseVisualStyleBackColor = false;
            dietButton.Click += dietButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 40);
            panel1.TabIndex = 19;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Gainsboro;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Verdana", 10.8F);
            editButton.Location = new Point(604, 9);
            editButton.Margin = new Padding(0);
            editButton.Name = "editButton";
            editButton.Size = new Size(199, 38);
            editButton.TabIndex = 20;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(850, 600);
            Controls.Add(editButton);
            Controls.Add(panel1);
            Controls.Add(dietButton);
            Controls.Add(recipeButton);
            Controls.Add(goalLabel);
            Controls.Add(goalTextLabel);
            Controls.Add(activityLevelLabel);
            Controls.Add(activityLevelTextLabel);
            Controls.Add(sexTextLabel);
            Controls.Add(ageLabel);
            Controls.Add(ageTextLabel);
            Controls.Add(currentWeightLabel);
            Controls.Add(heightLabel);
            Controls.Add(sexLabel);
            Controls.Add(currentWeightTextLabel);
            Controls.Add(heightTextLabel);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label loginLabel;
        private Label heightTextLabel;
        private Label currentWeightTextLabel;
        private Label sexLabel;
        private Label heightLabel;
        private Label currentWeightLabel;
        private Label ageTextLabel;
        private Label ageLabel;
        private Label sexTextLabel;
        private Label activityLevelLabel;
        private Label activityLevelTextLabel;
        private Label goalLabel;
        private Label goalTextLabel;
        private Button recipeButton;
        private Button dietButton;
        private Panel panel1;
        private Button editButton;
    }
}