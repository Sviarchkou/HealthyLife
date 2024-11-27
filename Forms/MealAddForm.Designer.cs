namespace HealthyLife_Pt2.Forms
{
    partial class MealAddForm
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
            search = new TextBox();
            searchPanel = new FormControls.MyPanel();
            createButton = new FormControls.MyPanel();
            SuspendLayout();
            // 
            // search
            // 
            search.BackColor = Color.Gainsboro;
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Verdana", 11.8F);
            search.Location = new Point(70, 47);
            search.Name = "search";
            search.Size = new Size(305, 24);
            search.TabIndex = 0;
            search.TabStop = false;
            search.Text = "Поиск";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.Transparent;
            searchPanel.BorderColor = Color.Transparent;
            searchPanel.Location = new Point(47, 30);
            searchPanel.Name = "searchPanel";
            searchPanel.PanelColor = Color.Gainsboro;
            searchPanel.Rad = 60;
            searchPanel.Size = new Size(392, 58);
            searchPanel.TabIndex = 1;
            // 
            // createButton
            // 
            createButton.BackColor = Color.Transparent;
            createButton.BorderColor = Color.DarkGray;
            createButton.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createButton.Location = new Point(481, 30);
            createButton.Name = "createButton";
            createButton.PanelColor = Color.Gainsboro;
            createButton.Rad = 60;
            createButton.Size = new Size(177, 58);
            createButton.TabIndex = 2;
            createButton.Click += createButton_Click;
            // 
            // MealAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(682, 473);
            Controls.Add(createButton);
            Controls.Add(search);
            Controls.Add(searchPanel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(700, 520);
            MinimumSize = new Size(700, 520);
            Name = "MealAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search;
        private FormControls.MyPanel searchPanel;
        private FormControls.MyPanel createButton;
    }
}