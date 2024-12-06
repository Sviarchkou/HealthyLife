namespace HealthyLife_Pt2.FormControls.MealControls.AdditionContols
{
    partial class ExtraFoodAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraFoodAddition));
            infoButton = new Label();
            elements = new Label();
            productPicture = new PictureBox();
            name = new Label();
            productPanel = new MyPanel();
            decrimentButton = new Button();
            incrementButton = new Button();
            counterLabel = new Label();
            label1 = new Label();
            weightTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productPicture).BeginInit();
            SuspendLayout();
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.FromArgb(255, 255, 128);
            infoButton.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoButton.ForeColor = SystemColors.ControlText;
            infoButton.Location = new Point(421, 3);
            infoButton.Margin = new Padding(3);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(20, 20);
            infoButton.TabIndex = 40;
            infoButton.Text = "i";
            infoButton.TextAlign = ContentAlignment.MiddleCenter;
            infoButton.Click += infoButton_Click;
            // 
            // elements
            // 
            elements.BackColor = Color.Gainsboro;
            elements.Enabled = false;
            elements.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            elements.ForeColor = Color.Black;
            elements.Location = new Point(94, 48);
            elements.Margin = new Padding(0);
            elements.MaximumSize = new Size(355, 22);
            elements.Name = "elements";
            elements.Size = new Size(355, 22);
            elements.TabIndex = 39;
            elements.Text = "Категория";
            // 
            // productPicture
            // 
            productPicture.BackColor = Color.Gainsboro;
            productPicture.BackgroundImageLayout = ImageLayout.Stretch;
            productPicture.Enabled = false;
            productPicture.Image = Properties.Resources.mealPic;
            productPicture.Location = new Point(22, 10);
            productPicture.Name = "productPicture";
            productPicture.Size = new Size(60, 60);
            productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            productPicture.TabIndex = 38;
            productPicture.TabStop = false;
            // 
            // name
            // 
            name.BackColor = Color.Gainsboro;
            name.Enabled = false;
            name.Font = new Font("Verdana", 11.8F, FontStyle.Bold);
            name.ForeColor = Color.Black;
            name.Location = new Point(94, 14);
            name.MaximumSize = new Size(220, 25);
            name.Name = "name";
            name.Size = new Size(220, 25);
            name.TabIndex = 36;
            name.Text = "Куриная грудка";
            // 
            // productPanel
            // 
            productPanel.BackColor = Color.Transparent;
            productPanel.BorderColor = Color.Transparent;
            productPanel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productPanel.Location = new Point(2, 2);
            productPanel.Name = "productPanel";
            productPanel.PanelColor = Color.Gainsboro;
            productPanel.Rad = 30;
            productPanel.Size = new Size(457, 77);
            productPanel.TabIndex = 37;
            // 
            // decrimentButton
            // 
            decrimentButton.BackColor = Color.Gainsboro;
            decrimentButton.BackgroundImage = (Image)resources.GetObject("decrimentButton.BackgroundImage");
            decrimentButton.BackgroundImageLayout = ImageLayout.Zoom;
            decrimentButton.FlatAppearance.BorderSize = 0;
            decrimentButton.Font = new Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decrimentButton.Location = new Point(426, 82);
            decrimentButton.Margin = new Padding(0);
            decrimentButton.Name = "decrimentButton";
            decrimentButton.Size = new Size(25, 25);
            decrimentButton.TabIndex = 42;
            decrimentButton.UseVisualStyleBackColor = false;
            decrimentButton.Click += decrimentButton_Click;
            // 
            // incrementButton
            // 
            incrementButton.BackColor = Color.Gainsboro;
            incrementButton.BackgroundImage = (Image)resources.GetObject("incrementButton.BackgroundImage");
            incrementButton.BackgroundImageLayout = ImageLayout.Zoom;
            incrementButton.FlatAppearance.BorderSize = 0;
            incrementButton.Font = new Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            incrementButton.Location = new Point(483, 82);
            incrementButton.Margin = new Padding(0);
            incrementButton.Name = "incrementButton";
            incrementButton.Size = new Size(25, 25);
            incrementButton.TabIndex = 43;
            incrementButton.UseVisualStyleBackColor = false;
            incrementButton.Click += incrementButton_Click;
            // 
            // counterLabel
            // 
            counterLabel.BackColor = Color.FromArgb(255, 255, 128);
            counterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            counterLabel.Location = new Point(451, 82);
            counterLabel.Margin = new Padding(0);
            counterLabel.Name = "counterLabel";
            counterLabel.Size = new Size(32, 25);
            counterLabel.TabIndex = 44;
            counterLabel.Text = "0";
            counterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(392, 20);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 82;
            label1.Text = "г.";
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Verdana", 9.2F);
            weightTextBox.ForeColor = Color.Gray;
            weightTextBox.Location = new Point(332, 17);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(54, 26);
            weightTextBox.TabIndex = 81;
            weightTextBox.Text = "100";
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            weightTextBox.Click += weightTextBox_Click;
            weightTextBox.TextChanged += weightTextBox_TextChanged;
            // 
            // ExtraFoodAddition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(weightTextBox);
            Controls.Add(counterLabel);
            Controls.Add(incrementButton);
            Controls.Add(decrimentButton);
            Controls.Add(infoButton);
            Controls.Add(elements);
            Controls.Add(productPicture);
            Controls.Add(name);
            Controls.Add(productPanel);
            Name = "ExtraFoodAddition";
            Size = new Size(463, 82);
            ((System.ComponentModel.ISupportInitialize)productPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoButton;
        private Label elements;
        private PictureBox productPicture;
        private Label name;
        private MyPanel productPanel;
        private Button decrimentButton;
        private Button incrementButton;
        private Label counterLabel;
        private Label label1;
        private TextBox weightTextBox;
    }
}
