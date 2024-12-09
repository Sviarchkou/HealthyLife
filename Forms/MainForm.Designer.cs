namespace HealthyLife_Pt2.Forms
{
    partial class MainForm
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
            formPanel = new Panel();
            panel1 = new Panel();
            products = new Button();
            userWeightButton = new Button();
            profileButton = new Button();
            button3 = new Button();
            dietMenuButton = new Button();
            counterButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.FloralWhite;
            formPanel.Dock = DockStyle.Right;
            formPanel.Location = new Point(206, 0);
            formPanel.Margin = new Padding(0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(850, 600);
            formPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 31, 46);
            panel1.Controls.Add(products);
            panel1.Controls.Add(userWeightButton);
            panel1.Controls.Add(profileButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dietMenuButton);
            panel1.Controls.Add(counterButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 600);
            panel1.TabIndex = 2;
            // 
            // products
            // 
            products.BackColor = Color.FromArgb(43, 31, 46);
            products.FlatAppearance.BorderSize = 0;
            products.FlatStyle = FlatStyle.Flat;
            products.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            products.ForeColor = Color.White;
            products.Location = new Point(0, 389);
            products.Margin = new Padding(0);
            products.Name = "products";
            products.Size = new Size(206, 62);
            products.TabIndex = 5;
            products.Text = "Продукты";
            products.UseVisualStyleBackColor = false;
            // 
            // userWeightButton
            // 
            userWeightButton.BackColor = Color.FromArgb(43, 31, 46);
            userWeightButton.FlatAppearance.BorderSize = 0;
            userWeightButton.FlatStyle = FlatStyle.Flat;
            userWeightButton.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userWeightButton.ForeColor = Color.White;
            userWeightButton.Location = new Point(0, 327);
            userWeightButton.Margin = new Padding(0);
            userWeightButton.Name = "userWeightButton";
            userWeightButton.Size = new Size(206, 62);
            userWeightButton.TabIndex = 4;
            userWeightButton.Text = "Прогресс";
            userWeightButton.UseVisualStyleBackColor = false;
            userWeightButton.Click += userWeightButton_Click;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.FromArgb(43, 31, 46);
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            profileButton.ForeColor = Color.White;
            profileButton.Location = new Point(0, 79);
            profileButton.Margin = new Padding(0);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(206, 62);
            profileButton.TabIndex = 3;
            profileButton.Text = "Профиль";
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            profileButton.MouseEnter += button_MouseEnter;
            profileButton.MouseLeave += button_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 31, 46);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 265);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(206, 62);
            button3.TabIndex = 2;
            button3.Text = "Рецепты";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseEnter += button_MouseEnter;
            button3.MouseLeave += button_MouseLeave;
            // 
            // dietMenuButton
            // 
            dietMenuButton.BackColor = Color.FromArgb(43, 31, 46);
            dietMenuButton.FlatAppearance.BorderSize = 0;
            dietMenuButton.FlatStyle = FlatStyle.Flat;
            dietMenuButton.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dietMenuButton.ForeColor = Color.White;
            dietMenuButton.Location = new Point(0, 203);
            dietMenuButton.Margin = new Padding(0);
            dietMenuButton.Name = "dietMenuButton";
            dietMenuButton.Size = new Size(206, 62);
            dietMenuButton.TabIndex = 1;
            dietMenuButton.Text = "Рационы";
            dietMenuButton.UseVisualStyleBackColor = false;
            dietMenuButton.Click += dietMenuButton_Click;
            dietMenuButton.MouseEnter += button_MouseEnter;
            dietMenuButton.MouseLeave += button_MouseLeave;
            // 
            // counterButton
            // 
            counterButton.BackColor = Color.FromArgb(43, 31, 46);
            counterButton.FlatAppearance.BorderSize = 0;
            counterButton.FlatStyle = FlatStyle.Flat;
            counterButton.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            counterButton.ForeColor = Color.White;
            counterButton.Location = new Point(0, 141);
            counterButton.Margin = new Padding(0);
            counterButton.Name = "counterButton";
            counterButton.Size = new Size(206, 62);
            counterButton.TabIndex = 0;
            counterButton.Text = "Счётчик";
            counterButton.UseVisualStyleBackColor = false;
            counterButton.Click += counterButton_Click;
            counterButton.MouseEnter += button_MouseEnter;
            counterButton.MouseLeave += button_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 600);
            Controls.Add(formPanel);
            Controls.Add(panel1);
            MaximumSize = new Size(1074, 647);
            MinimumSize = new Size(1074, 647);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += MainForm_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel formPanel;
        private Panel panel1;
        private Button counterButton;
        private Button dietMenuButton;
        private Button button3;
        private Button userWeightButton;
        private Button profileButton;
        private Button products;
    }
}