namespace HealthyLife_Pt2.Forms.Registrarion
{
    partial class UserDataForm
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
            label2 = new Label();
            height = new TextBox();
            weight = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            next = new Button();
            back = new Button();
            dateOfBirth = new TextBox();
            SuspendLayout();
            // 
            // labelText
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(424, 3);
            label1.Name = "labelText";
            label1.Size = new Size(277, 69);
            label1.TabIndex = 0;
            label1.Text = "Отлично!";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(434, 72);
            label2.Name = "label2";
            label2.Size = new Size(267, 100);
            label2.TabIndex = 1;
            label2.Text = "Теперь введите свои данные";
            // 
            // height
            // 
            height.Cursor = Cursors.IBeam;
            height.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            height.ForeColor = Color.Gray;
            height.Location = new Point(441, 303);
            height.MaximumSize = new Size(280, 32);
            height.MinimumSize = new Size(280, 32);
            height.Name = "height";
            height.Size = new Size(280, 32);
            height.TabIndex = 10;
            height.TabStop = false;
            height.Text = "Ваш рост (см)";
            height.Click += height_Click;
            // 
            // weight
            // 
            weight.Cursor = Cursors.IBeam;
            weight.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            weight.ForeColor = Color.Gray;
            weight.Location = new Point(441, 265);
            weight.MaximumSize = new Size(280, 32);
            weight.MinimumSize = new Size(280, 32);
            weight.Name = "weight";
            weight.Size = new Size(280, 32);
            weight.TabIndex = 9;
            weight.TabStop = false;
            weight.Text = "Ваш вес (кг)";
            weight.Click += weight_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(434, 189);
            label3.Name = "label3";
            label3.Size = new Size(129, 43);
            label3.TabIndex = 11;
            label3.Text = "Ваш пол";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(441, 226);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 33);
            radioButton1.TabIndex = 12;
            radioButton1.Text = "муж.";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(534, 226);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 33);
            radioButton2.TabIndex = 13;
            radioButton2.Text = "жен.";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton3.ForeColor = SystemColors.ControlLightLight;
            radioButton3.Location = new Point(625, 226);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(109, 33);
            radioButton3.TabIndex = 14;
            radioButton3.Text = "другое";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(255, 255, 192);
            next.Location = new Point(624, 396);
            next.Name = "next";
            next.Size = new Size(97, 35);
            next.TabIndex = 16;
            next.Text = "Далее";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Location = new Point(441, 396);
            back.Name = "back";
            back.Size = new Size(97, 35);
            back.TabIndex = 15;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Cursor = Cursors.IBeam;
            dateOfBirth.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateOfBirth.ForeColor = Color.Gray;
            dateOfBirth.Location = new Point(441, 341);
            dateOfBirth.MaximumSize = new Size(280, 32);
            dateOfBirth.MinimumSize = new Size(280, 32);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(280, 32);
            dateOfBirth.TabIndex = 17;
            dateOfBirth.TabStop = false;
            dateOfBirth.Text = "Дата рожд. (дд.мм.гггг)";
            dateOfBirth.Click += dateOfBirth_Click;
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = HealthyLife_Pt2.Properties.Resources.RegistrationBask;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(dateOfBirth);
            Controls.Add(next);
            Controls.Add(back);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(height);
            Controls.Add(weight);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(820, 500);
            MinimumSize = new Size(820, 500);
            Name = "UserDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox height;
        private TextBox weight;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button next;
        private Button back;
        private TextBox dateOfBirth;
    }
}