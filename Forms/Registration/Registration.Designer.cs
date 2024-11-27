namespace HealthyLife_Pt2.Forms
{
    partial class Registration
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
            password = new TextBox();
            login = new TextBox();
            label1 = new Label();
            passwordReplication = new TextBox();
            register = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // password
            // 
            password.Cursor = Cursors.IBeam;
            password.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password.ForeColor = Color.Gray;
            password.Location = new Point(274, 248);
            password.MaximumSize = new Size(260, 32);
            password.MinimumSize = new Size(260, 32);
            password.Name = "password";
            password.Size = new Size(260, 32);
            password.TabIndex = 6;
            password.TabStop = false;
            password.Text = "Пороль";
            password.Click += password_Click;
            // 
            // login
            // 
            login.Cursor = Cursors.IBeam;
            login.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login.ForeColor = Color.Gray;
            login.Location = new Point(274, 193);
            login.MaximumSize = new Size(260, 32);
            login.MinimumSize = new Size(260, 32);
            login.Name = "login";
            login.Size = new Size(260, 32);
            login.TabIndex = 5;
            login.TabStop = false;
            login.Text = "Логин";
            login.Click += login_Click;
            // 
            // labelText
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(240, 61);
            label1.Name = "labelText";
            label1.Size = new Size(342, 65);
            label1.TabIndex = 4;
            label1.Text = "Регистрация";
            // 
            // passwordReplication
            // 
            passwordReplication.Cursor = Cursors.IBeam;
            passwordReplication.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordReplication.ForeColor = Color.Gray;
            passwordReplication.Location = new Point(274, 303);
            passwordReplication.MaximumSize = new Size(260, 32);
            passwordReplication.MinimumSize = new Size(260, 32);
            passwordReplication.Name = "passwordReplication";
            passwordReplication.Size = new Size(260, 32);
            passwordReplication.TabIndex = 7;
            passwordReplication.TabStop = false;
            passwordReplication.Text = "Повтор пороля";
            passwordReplication.Click += passwordReplicaioin_Click;
            // 
            // register
            // 
            register.BackColor = Color.FromArgb(255, 255, 192);
            register.Location = new Point(437, 374);
            register.Name = "register";
            register.Size = new Size(97, 35);
            register.TabIndex = 9;
            register.Text = "Далее";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Location = new Point(274, 374);
            back.Name = "back";
            back.Size = new Size(97, 35);
            back.TabIndex = 8;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgound;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(register);
            Controls.Add(back);
            Controls.Add(passwordReplication);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox password;
        private TextBox login;
        private Label label1;
        private TextBox passwordReplication;
        private Button register;
        private Button back;
    }
}