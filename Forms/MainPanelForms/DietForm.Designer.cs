﻿namespace HealthyLife_Pt2.Forms.MainPanelForms
{
    partial class DietForm
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
            dietCreationButton = new FormControls.MyPanel();
            searchPanel1 = new FormControls.SearchPanel();
            SuspendLayout();
            // 
            // dietCreationButton
            // 
            dietCreationButton.BorderColor = Color.Empty;
            dietCreationButton.Location = new Point(545, 27);
            dietCreationButton.Name = "dietCreationButton";
            dietCreationButton.PanelColor = Color.Gainsboro;
            dietCreationButton.Rad = 60;
            dietCreationButton.Size = new Size(256, 58);
            dietCreationButton.TabIndex = 7;
            dietCreationButton.Click += dietCreationButton_Click;
            dietCreationButton.MouseEnter += button_MouseEnter;
            dietCreationButton.MouseLeave += button_MouseLeave;
            // 
            // searchPanel1
            // 
            searchPanel1.BackColor = Color.Transparent;
            searchPanel1.Location = new Point(38, 27);
            searchPanel1.Name = "searchPanel1";
            searchPanel1.Size = new Size(450, 58);
            searchPanel1.TabIndex = 8;
            // 
            // DietForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(850, 600);
            Controls.Add(searchPanel1);
            Controls.Add(dietCreationButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "DietForm";
            Text = "DietForm";
            ResumeLayout(false);
        }

        #endregion
        private FormControls.MyPanel dietCreationButton;
        private FormControls.SearchPanel searchPanel1;
    }
}