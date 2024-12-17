namespace HealthyLife_Pt2.FormControls.MealControls
{
    partial class DietButton
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
            dietPanel = new MyPanel();
            pictureBox = new PictureBox();
            name = new Label();
            description = new Label();
            caloriesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dietPanel
            // 
            dietPanel.BackColor = Color.Transparent;
            dietPanel.BorderColor = Color.Transparent;
            dietPanel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dietPanel.Location = new Point(0, 0);
            dietPanel.Margin = new Padding(3, 3, 3, 10);
            dietPanel.Name = "dietPanel";
            dietPanel.PanelColor = Color.Gainsboro;
            dietPanel.Rad = 45;
            dietPanel.Size = new Size(235, 270);
            dietPanel.TabIndex = 27;
            dietPanel.Click += dietButtonClicked;
            dietPanel.MouseEnter += dietButtonMouseEnter;
            dietPanel.MouseLeave += dietButtonMouseLeave;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.SaddleBrown;
            pictureBox.Image = Properties.Resources.Backgound;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(5);
            pictureBox.Name = "pictureBox";
            pictureBox.Padding = new Padding(0, 8, 0, 0);
            pictureBox.Size = new Size(235, 172);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 28;
            pictureBox.TabStop = false;
            pictureBox.Click += dietButtonClicked;
            pictureBox.MouseEnter += dietButtonMouseEnter;
            pictureBox.MouseLeave += dietButtonMouseLeave;
            // 
            // name
            // 
            name.BackColor = Color.Gainsboro;
            name.Font = new Font("Verdana", 12.8F, FontStyle.Bold);
            name.Location = new Point(12, 198);
            name.Name = "name";
            name.Size = new Size(203, 58);
            name.TabIndex = 29;
            name.Text = "Name";
            name.Click += dietButtonClicked;
            name.MouseEnter += dietButtonMouseEnter;
            name.MouseLeave += dietButtonMouseLeave;
            // 
            // description
            // 
            description.BackColor = Color.Gainsboro;
            description.Font = new Font("Verdana", 9.8F);
            description.Location = new Point(12, 176);
            description.Name = "description";
            description.Size = new Size(220, 22);
            description.TabIndex = 30;
            description.Text = "Для поддержания веса";
            description.Click += dietButtonClicked;
            description.MouseEnter += dietButtonMouseEnter;
            description.MouseLeave += dietButtonMouseLeave;
            // 
            // caloriesLabel
            // 
            caloriesLabel.BackColor = Color.SaddleBrown;
            caloriesLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            caloriesLabel.ForeColor = Color.White;
            caloriesLabel.Location = new Point(62, 0);
            caloriesLabel.Margin = new Padding(0, 0, 0, 0);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(110, 25);
            caloriesLabel.TabIndex = 31;
            caloriesLabel.Text = "3000 ккал";
            caloriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DietButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(caloriesLabel);
            Controls.Add(description);
            Controls.Add(name);
            Controls.Add(pictureBox);
            Controls.Add(dietPanel);
            Name = "DietButton";
            Size = new Size(235, 276);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MyPanel dietPanel;
        private PictureBox pictureBox;
        private Label name;
        private Label description;
        private Label caloriesLabel;
    }
}
