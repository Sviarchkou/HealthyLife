namespace HealthyLife_Pt2.FormControls.MealControls
{
    partial class ProductButton
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
            productPicture = new PictureBox();
            name = new Label();
            recipePanel = new MyPanel();
            category = new Label();
            infoButton = new Label();
            ((System.ComponentModel.ISupportInitialize)productPicture).BeginInit();
            SuspendLayout();
            // 
            // productPicture
            // 
            productPicture.BackColor = Color.Gainsboro;
            productPicture.BackgroundImageLayout = ImageLayout.Stretch;
            productPicture.Enabled = false;
            productPicture.Image = Properties.Resources.mealPic;
            productPicture.Location = new Point(23, 11);
            productPicture.Name = "productPicture";
            productPicture.Size = new Size(60, 60);
            productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            productPicture.TabIndex = 32;
            productPicture.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Gainsboro;
            name.Enabled = false;
            name.Font = new Font("Verdana", 11.8F, FontStyle.Bold);
            name.Location = new Point(95, 15);
            name.MaximumSize = new Size(200, 30);
            name.Name = "name";
            name.Size = new Size(194, 25);
            name.TabIndex = 29;
            name.Text = "Куриная грудка";
            // 
            // recipePanel
            // 
            recipePanel.BackColor = Color.Transparent;
            recipePanel.BorderColor = Color.Transparent;
            recipePanel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            recipePanel.Location = new Point(3, 3);
            recipePanel.Name = "recipePanel";
            recipePanel.PanelColor = Color.Gainsboro;
            recipePanel.Rad = 30;
            recipePanel.Size = new Size(330, 77);
            recipePanel.TabIndex = 31;
            // 
            // category
            // 
            category.AutoSize = true;
            category.BackColor = Color.Gainsboro;
            category.Enabled = false;
            category.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            category.Location = new Point(95, 40);
            category.MaximumSize = new Size(200, 42);
            category.Name = "category";
            category.Size = new Size(99, 20);
            category.TabIndex = 34;
            category.Text = "Категория";
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.FromArgb(255, 255, 128);
            infoButton.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoButton.ForeColor = SystemColors.ControlText;
            infoButton.Location = new Point(300, 4);
            infoButton.Margin = new Padding(3);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(20, 20);
            infoButton.TabIndex = 35;
            infoButton.Text = "i";
            infoButton.TextAlign = ContentAlignment.MiddleCenter;
            infoButton.Click += infoButton_Click;
            // 
            // ProductButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(infoButton);
            Controls.Add(category);
            Controls.Add(productPicture);
            Controls.Add(name);
            Controls.Add(recipePanel);
            Name = "ProductButton";
            Size = new Size(336, 82);
            ((System.ComponentModel.ISupportInitialize)productPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox productPicture;
        private Label name;
        private MyPanel recipePanel;
        private Label category;
        private Label infoButton;
    }
}
