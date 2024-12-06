namespace HealthyLife_Pt2.FormControls.MealControls
{
    partial class RecipeFormButton
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
            elements = new Label();
            name = new Label();
            pictureBox = new PictureBox();
            recipePanel = new MyPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // elements
            // 
            elements.BackColor = Color.Gainsboro;
            elements.Font = new Font("Verdana", 10F);
            elements.Location = new Point(19, 209);
            elements.Name = "elements";
            elements.Size = new Size(257, 45);
            elements.TabIndex = 34;
            elements.Text = "Description";
            elements.Click += recipeFormButtonClicked;
            elements.MouseEnter += recipeFormButtonMouseEnter;
            elements.MouseLeave += recipeFormButtonMouseLeave;
            // 
            // name
            // 
            name.BackColor = Color.Gainsboro;
            name.Font = new Font("Verdana", 12.8F, FontStyle.Bold);
            name.Location = new Point(19, 254);
            name.Name = "name";
            name.Size = new Size(257, 58);
            name.TabIndex = 33;
            name.Text = "Name";
            name.Click += recipeFormButtonClicked;
            name.MouseEnter += recipeFormButtonMouseEnter;
            name.MouseLeave += recipeFormButtonMouseLeave;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(128, 64, 0);
            pictureBox.Image = Properties.Resources.Backgound;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(5);
            pictureBox.Name = "pictureBox";
            pictureBox.Padding = new Padding(0, 8, 0, 0);
            pictureBox.Size = new Size(296, 204);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 32;
            pictureBox.TabStop = false;
            pictureBox.Click += recipeFormButtonClicked;
            pictureBox.MouseEnter += recipeFormButtonMouseEnter;
            pictureBox.MouseLeave += recipeFormButtonMouseLeave;
            // 
            // recipePanel
            // 
            recipePanel.BackColor = Color.Transparent;
            recipePanel.BorderColor = Color.Transparent;
            recipePanel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            recipePanel.Location = new Point(0, 0);
            recipePanel.Margin = new Padding(3, 3, 3, 10);
            recipePanel.Name = "recipePanel";
            recipePanel.PanelColor = Color.Gainsboro;
            recipePanel.Rad = 45;
            recipePanel.Size = new Size(296, 322);
            recipePanel.TabIndex = 31;
            recipePanel.Click += recipeFormButtonClicked;
            recipePanel.MouseEnter += recipeFormButtonMouseEnter;
            recipePanel.MouseLeave += recipeFormButtonMouseLeave;
            // 
            // RecipeFormButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(elements);
            Controls.Add(name);
            Controls.Add(pictureBox);
            Controls.Add(recipePanel);
            Name = "RecipeFormButton";
            Size = new Size(297, 326);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label elements;
        private Label name;
        private PictureBox pictureBox;
        private MyPanel recipePanel;
    }
}
