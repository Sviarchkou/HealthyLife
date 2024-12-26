namespace HealthyLife_Pt2.Forms.Registrarion
{
    partial class GoalForm
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            back = new Button();
            next = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(89, 106);
            label2.Name = "label2";
            label2.Size = new Size(638, 56);
            label2.TabIndex = 11;
            label2.Text = "Какие у вас цели диеты?";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(168, 24);
            label1.Name = "label1";
            label1.Size = new Size(481, 65);
            label1.TabIndex = 10;
            label1.Text = "Почти закончили!";
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(26, 198);
            button1.Name = "button1";
            button1.Size = new Size(244, 185);
            button1.TabIndex = 15;
            button1.Text = "Похудение";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(276, 198);
            button2.Name = "button2";
            button2.Size = new Size(244, 185);
            button2.TabIndex = 16;
            button2.Text = "Поддержание веса";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(526, 198);
            button3.Name = "button3";
            button3.Size = new Size(244, 185);
            button3.TabIndex = 17;
            button3.Text = "Набор массы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Location = new Point(276, 403);
            back.Name = "back";
            back.Size = new Size(97, 35);
            back.TabIndex = 18;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(255, 255, 192);
            next.Location = new Point(423, 403);
            next.Name = "next";
            next.Size = new Size(97, 35);
            next.TabIndex = 19;
            next.Text = "Далее";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // GoalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RegGoal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(next);
            Controls.Add(back);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GoalForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button back;
        private Button next;
    }
}