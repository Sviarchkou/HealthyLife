namespace HealthyLife_Pt2.Forms
{
    partial class WellcomeScrin
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
            label1 = new Label();
            authButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 112);
            label1.Name = "label1";
            label1.Size = new Size(535, 69);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            // 
            // authButton
            // 
            authButton.BackColor = Color.FloralWhite;
            authButton.Font = new Font("Sitka Small", 11F, FontStyle.Bold);
            authButton.Location = new Point(305, 252);
            authButton.Name = "authButton";
            authButton.Size = new Size(184, 43);
            authButton.TabIndex = 1;
            authButton.Text = "Вход";
            authButton.UseVisualStyleBackColor = false;
            authButton.Click += authButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.Font = new Font("Sitka Small", 11F, FontStyle.Bold);
            button1.Location = new Point(305, 315);
            button1.Name = "button1";
            button1.Size = new Size(184, 43);
            button1.TabIndex = 2;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WellcomeScrin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgound;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(button1);
            Controls.Add(authButton);
            Controls.Add(label1);
            Name = "WellcomeScrin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button authButton;
        private Button button1;
    }
}