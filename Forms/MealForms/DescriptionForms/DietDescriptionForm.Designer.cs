namespace HealthyLife_Pt2.Forms.MealForms
{
    partial class DietDescriptionForm
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
            panel1 = new Panel();
            deleteButton = new Button();
            nameLabel = new Label();
            goalLabel = new Label();
            description = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(deleteButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 663);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 40);
            panel1.TabIndex = 6;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(467, 6);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(149, 28);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "УДАЛИТЬ";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Verdana", 13F, FontStyle.Bold);
            nameLabel.Location = new Point(193, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(725, 35);
            nameLabel.TabIndex = 150;
            nameLabel.Text = "Название dfgh sdfgjh  dsfkgh  dfjgh kdjfg k dkfjghksjdfhg ksjdf gdk fjgh kdjsfhg kdjfh kjsdfh g dsf f";
            nameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // goalLabel
            // 
            goalLabel.BackColor = Color.Transparent;
            goalLabel.Font = new Font("Verdana", 12F);
            goalLabel.Location = new Point(381, 7);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new Size(354, 32);
            goalLabel.TabIndex = 151;
            goalLabel.Text = "Цель - поддержание веса";
            goalLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // description
            // 
            description.AutoSize = true;
            description.BackColor = Color.Transparent;
            description.Font = new Font("Verdana", 12F);
            description.Location = new Point(193, 85);
            description.MaximumSize = new Size(725, int.MaxValue);
            description.Name = "description";
            description.Size = new Size(725, 50);
            description.TabIndex = 158;
            description.Text = "Название dfgh sdfgjh  dsппfkgh  dfjgh kdjfg k dkfjghksjdfhg ksjdf gdk fjgh kdjsfhg kdjfh kjsdfh g dsf f";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.saveNotSelected;
            pictureBox2.Location = new Point(1031, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 187;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // DietDescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1082, 703);
            Controls.Add(pictureBox2);
            Controls.Add(description);
            Controls.Add(goalLabel);
            Controls.Add(nameLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1135, 750);
            MinimumSize = new Size(1100, 750);
            Name = "DietDescriptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Button deleteButton;
        private Label nameLabel;
        private Label goalLabel;
        private Label description;
        private PictureBox pictureBox2;
    }
}