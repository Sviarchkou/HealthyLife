namespace HealthyLife_Pt2.Forms
{
    partial class FinalRegForm
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
            register = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(55, 26);
            label1.Name = "labelText";
            label1.Size = new Size(415, 134);
            label1.TabIndex = 4;
            label1.Text = "Завершить регистрацию?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // register
            // 
            register.BackColor = Color.FromArgb(255, 255, 192);
            register.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            register.Location = new Point(293, 193);
            register.Name = "register";
            register.Size = new Size(134, 46);
            register.TabIndex = 9;
            register.Text = "Завершить";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            back.Location = new Point(76, 193);
            back.Name = "back";
            back.Size = new Size(131, 46);
            back.TabIndex = 8;
            back.Text = "Вернуться";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // FinalRegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = HealthyLife_Pt2.Properties.Resources.Backgound;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(504, 286);
            Controls.Add(register);
            Controls.Add(back);
            Controls.Add(label1);
            Name = "FinalRegForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button register;
        private Button back;
    }
}