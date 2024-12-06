namespace HealthyLife_Pt2.Forms
{
    partial class Authorization
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
            login = new TextBox();
            password = new TextBox();
            back = new Button();
            authorize = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(233, 37);
            label1.Name = "labelText";
            label1.Size = new Size(352, 65);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // login
            // 
            login.Cursor = Cursors.IBeam;
            login.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login.ForeColor = Color.Gray;
            login.Location = new Point(276, 206);
            login.MaximumSize = new Size(260, 32);
            login.MinimumSize = new Size(260, 32);
            login.Name = "login";
            login.Size = new Size(260, 32);
            login.TabIndex = 2;
            login.TabStop = false;
            login.Text = "Логин";
            login.Click += login_Click;
            // 
            // password
            // 
            password.BackColor = SystemColors.Window;
            password.Cursor = Cursors.IBeam;
            password.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password.ForeColor = Color.Gray;
            password.Location = new Point(276, 267);
            password.MaximumSize = new Size(260, 32);
            password.MinimumSize = new Size(260, 32);
            password.Name = "password";
            password.Size = new Size(260, 32);
            password.TabIndex = 3;
            password.TabStop = false;
            password.Text = "Пароль";
            password.Click += password_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Location = new Point(276, 360);
            back.Name = "back";
            back.Size = new Size(97, 35);
            back.TabIndex = 5;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // authorize
            // 
            authorize.BackColor = Color.FromArgb(255, 255, 192);
            authorize.Location = new Point(439, 360);
            authorize.Name = "authorize";
            authorize.Size = new Size(97, 35);
            authorize.TabIndex = 6;
            authorize.Text = "Войти";
            authorize.UseVisualStyleBackColor = false;
            authorize.Click += authorize_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = HealthyLife_Pt2.Properties.Resources.Backgound;
            ClientSize = new Size(802, 453);
            Controls.Add(authorize);
            Controls.Add(back);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label1);
            MaximumSize = new Size(820, 500);
            MinimumSize = new Size(820, 500);
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "      ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox login;
        private TextBox password;
        private Button back;
        private Button authorize;
    }
}