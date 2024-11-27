namespace HealthyLIfe_Pt2.FormControls
{
    partial class IngredientAddition
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            myPanel1 = new HealthyLife_Pt2.FormControls.MyPanel();
            element = new Label();
            addButton = new HealthyLife_Pt2.FormControls.MyPanel();
            textBox1 = new TextBox();
            weightTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // myPanel1
            // 
            myPanel1.BackColor = Color.Transparent;
            myPanel1.BorderColor = Color.DarkGray;
            myPanel1.Enabled = false;
            myPanel1.Location = new Point(3, 3);
            myPanel1.Name = "myPanel1";
            myPanel1.PanelColor = Color.Gainsboro;
            myPanel1.Rad = 30;
            myPanel1.Size = new Size(466, 99);
            myPanel1.TabIndex = 0;
            // 
            // element
            // 
            element.BackColor = Color.Gainsboro;
            element.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            element.ForeColor = Color.Black;
            element.Location = new Point(28, 66);
            element.Name = "element";
            element.Size = new Size(311, 21);
            element.TabIndex = 48;
            element.Text = "КБЖУ";
            element.Click += hideFlowLayoutPanel;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Gainsboro;
            addButton.BorderColor = Color.Transparent;
            addButton.Font = new Font("Verdana", 8.800001F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.DarkViolet;
            addButton.Location = new Point(345, 33);
            addButton.Name = "addButton";
            addButton.PanelColor = Color.FloralWhite;
            addButton.Rad = 30;
            addButton.Size = new Size(96, 54);
            addButton.TabIndex = 74;
            addButton.Click += addButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(28, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 28);
            textBox1.TabIndex = 75;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_Click;
            textBox1.Enter += textBox1_Click;
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Verdana", 10.2F);
            weightTextBox.Location = new Point(263, 33);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(52, 28);
            weightTextBox.TabIndex = 77;
            weightTextBox.Enter += hideFlowLayoutPanel;
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(316, 38);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 78;
            label1.Text = "г.";
            // 
            // label2
            // 
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Verdana", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(213, 21);
            label2.TabIndex = 79;
            label2.Text = "Выберете продукт";
            // 
            // label3
            // 
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Verdana", 10.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(263, 9);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 80;
            label3.Text = "Вес";
            // 
            // label4
            // 
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(429, 3);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 81;
            label4.Text = "x";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(28, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 5);
            flowLayoutPanel1.TabIndex = 82;
            // 
            // IngredientAddition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(weightTextBox);
            Controls.Add(addButton);
            Controls.Add(element);
            Controls.Add(myPanel1);
            Name = "IngredientAddition";
            Size = new Size(472, 105);
            Click += hideFlowLayoutPanel;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HealthyLife_Pt2.FormControls.MyPanel myPanel1;
        private Label element;
        private HealthyLife_Pt2.FormControls.MyPanel addButton;
        private TextBox textBox1;
        private TextBox weightTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
