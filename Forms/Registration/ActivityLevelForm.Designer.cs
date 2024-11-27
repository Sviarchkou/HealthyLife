namespace HealthyLife_Pt2.Controllers
{
    partial class ActivityLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityLevelForm));
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            next = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(225, -9);
            label1.Name = "labelText";
            label1.Size = new Size(393, 65);
            label1.TabIndex = 5;
            label1.Text = "Замечательно!";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(93, 56);
            label2.Name = "label2";
            label2.Size = new Size(638, 105);
            label2.TabIndex = 6;
            label2.Text = "Теперь определимся с уровнем активности";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(43, 189);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 43);
            radioButton1.TabIndex = 7;
            radioButton1.Text = "Низкий";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(287, 189);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(148, 43);
            radioButton2.TabIndex = 8;
            radioButton2.Text = "Средний";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton3.ForeColor = SystemColors.ControlLightLight;
            radioButton3.Location = new Point(540, 189);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(151, 43);
            radioButton3.TabIndex = 9;
            radioButton3.Text = "Высокий";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(43, 235);
            label3.Name = "label3";
            label3.Size = new Size(218, 111);
            label3.TabIndex = 10;
            label3.Text = "Мало активности в течении дня. Нет тренировок";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(287, 235);
            label4.Name = "label4";
            label4.Size = new Size(218, 162);
            label4.TabIndex = 11;
            label4.Text = "Есть физическая активность.  Добавляются тренировки 2-4 раза в неделю";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(540, 235);
            label5.Name = "label5";
            label5.Size = new Size(232, 162);
            label5.TabIndex = 12;
            label5.Text = "Много активности на протяжении всего дня. Тренировки 5 и более раз в неделю";
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(255, 255, 192);
            next.Location = new Point(437, 403);
            next.Name = "next";
            next.Size = new Size(97, 35);
            next.TabIndex = 18;
            next.Text = "Далее";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Location = new Point(254, 403);
            back.Name = "back";
            back.Size = new Size(97, 35);
            back.TabIndex = 17;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // ActivityLevelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(next);
            Controls.Add(back);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActivityLevelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActivityLevelForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button next;
        private Button back;
    }
}