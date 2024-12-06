namespace HealthyLife_Pt2.Forms.MealForms
{
    partial class ProductAddForm
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
            searchPanel1 = new FormControls.SearchPanel();
            createButton = new FormControls.MyPanel();
            SuspendLayout();
            // 
            // searchPanel1
            // 
            searchPanel1.BackColor = Color.Transparent;
            searchPanel1.Location = new Point(25, 25);
            searchPanel1.Name = "searchPanel1";
            searchPanel1.SearhText = "Поиск...";
            searchPanel1.Size = new Size(439, 58);
            searchPanel1.TabIndex = 18;
            // 
            // createButton
            // 
            createButton.BackColor = Color.Transparent;
            createButton.BorderColor = Color.DarkGray;
            createButton.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createButton.Location = new Point(480, 25);
            createButton.Name = "createButton";
            createButton.PanelColor = Color.Gainsboro;
            createButton.Rad = 60;
            createButton.Size = new Size(177, 58);
            createButton.TabIndex = 17;
            // 
            // ProductAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(682, 473);
            Controls.Add(searchPanel1);
            Controls.Add(createButton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(700, 520);
            MinimumSize = new Size(700, 520);
            Name = "ProductAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private FormControls.SearchPanel searchPanel1;
        private FormControls.MyPanel createButton;
    }
}