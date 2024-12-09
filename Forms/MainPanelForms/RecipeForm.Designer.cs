namespace HealthyLife_Pt2.Forms.MainPanelForms
{
    partial class RecipeForm
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
            recipeCreationButton = new FormControls.MyPanel();
            searchPanel1 = new FormControls.SearchPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // recipeCreationButton
            // 
            recipeCreationButton.BorderColor = Color.Empty;
            recipeCreationButton.Font = new Font("Verdana", 10.2F);
            recipeCreationButton.Location = new Point(546, 27);
            recipeCreationButton.Name = "recipeCreationButton";
            recipeCreationButton.PanelColor = Color.Gainsboro;
            recipeCreationButton.Rad = 60;
            recipeCreationButton.Size = new Size(256, 58);
            recipeCreationButton.TabIndex = 12;
            recipeCreationButton.Click += recipeCreationButton_Click;
            recipeCreationButton.MouseEnter += button_MouseEnter;
            recipeCreationButton.MouseLeave += button_MouseLeave;
            // 
            // searchPanel1
            // 
            searchPanel1.BackColor = Color.Transparent;
            searchPanel1.Location = new Point(41, 27);
            searchPanel1.Name = "searchPanel1";
            searchPanel1.SearhText = "Поиск...";
            searchPanel1.Size = new Size(440, 58);
            searchPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 40);
            panel1.TabIndex = 15;
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(850, 600);
            Controls.Add(panel1);
            Controls.Add(searchPanel1);
            Controls.Add(recipeCreationButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "RecipeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeForm";
            ResumeLayout(false);
        }

        #endregion

        private FormControls.MyPanel recipeCreationButton;
        private FormControls.SearchPanel searchPanel1;
        private Panel panel1;
    }
}