namespace HealthyLife_Pt2.FormControls
{
    partial class RecipeAddition
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

        public int Rad
        {
            get => recipePanel.Rad;
            set
            {
                if (value < 1)
                    value = 1;
                if (value > 90)
                    value = 90;
                recipePanel.Rad = value;
            }
        }
        public string LabelText
        {
            get => recipeLabel.Text;
            set => recipeLabel.Text = value;
        }

        public string DescriptionText
        {
            get => recipeDiscription.Text;
            set => recipeDiscription.Text = value;
        }

        public Image RecipeImage
        {
            get => recipePicture.BackgroundImage;
            set => recipePicture.BackgroundImage = value;
        }

        public Color PanelColor
        {
            get => recipePanel.PanelColor;
            set => recipePanel.PanelColor = value;
        }


        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            recipeLabel = new Label();
            recipeDiscription = new Label();
            recipePanel = new MyPanel();
            recipePicture = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)recipePicture).BeginInit();
            SuspendLayout();
            // 
            // recipeLabel
            // 
            recipeLabel.AutoSize = true;
            recipeLabel.BackColor = Color.Gainsboro;
            recipeLabel.Enabled = false;
            recipeLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            recipeLabel.Location = new Point(124, 20);
            recipeLabel.MaximumSize = new Size(280, 30);
            recipeLabel.Name = "recipeLabel";
            recipeLabel.Size = new Size(279, 28);
            recipeLabel.TabIndex = 22;
            recipeLabel.Text = "Запечёная курицаф";
            // 
            // recipeDiscription
            // 
            recipeDiscription.AutoSize = true;
            recipeDiscription.BackColor = Color.Gainsboro;
            recipeDiscription.Enabled = false;
            recipeDiscription.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            recipeDiscription.Location = new Point(124, 50);
            recipeDiscription.MaximumSize = new Size(250, 42);
            recipeDiscription.Name = "recipeDiscription";
            recipeDiscription.Size = new Size(235, 40);
            recipeDiscription.TabIndex = 24;
            recipeDiscription.Text = "К - 130 ккал, Б - 70.2 г., Ж - 35.2 г., У - 140 г.";
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
            recipePanel.Size = new Size(487, 97);
            recipePanel.TabIndex = 26;
            // 
            // recipePicture
            // 
            recipePicture.BackColor = Color.Gainsboro;
            recipePicture.BackgroundImageLayout = ImageLayout.Stretch;
            recipePicture.Enabled = false;
            recipePicture.Image = Properties.Resources.mealPic;
            recipePicture.Location = new Point(23, 11);
            recipePicture.Name = "recipePicture";
            recipePicture.Size = new Size(80, 80);
            recipePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            recipePicture.TabIndex = 27;
            recipePicture.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(453, 4);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 28;
            label1.Text = "i";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // RecipeAddition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(recipePicture);
            Controls.Add(recipeDiscription);
            Controls.Add(recipeLabel);
            Controls.Add(recipePanel);
            MaximumSize = new Size(500, 105);
            MinimumSize = new Size(500, 105);
            Name = "RecipeAddition";
            Size = new Size(500, 105);
            ((System.ComponentModel.ISupportInitialize)recipePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label recipeLabel;
        private Label recipeDiscription;
        private MyPanel recipePanel;
        private PictureBox recipePicture;
        private Label label1;
    }
}
