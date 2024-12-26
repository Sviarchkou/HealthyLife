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
            createButton = new FormControls.MyPanel();
            searchPanel1 = new FormControls.SearchPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.BackColor = Color.Transparent;
            createButton.BorderColor = Color.DarkGray;
            createButton.Enabled = false;
            createButton.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createButton.Location = new Point(480, 25);
            createButton.Name = "createButton";
            createButton.PanelColor = Color.Gainsboro;
            createButton.Rad = 60;
            createButton.Size = new Size(177, 58);
            createButton.TabIndex = 2;
            createButton.Click += createButton_Click;
            createButton.MouseEnter += button_MouseEnter;
            createButton.MouseLeave += button_MouseLeave;
            // 
            // searchPanel1
            // 
            searchPanel1.AutoSize = true;
            searchPanel1.BackColor = Color.Transparent;
            searchPanel1.Location = new Point(25, 25);
            searchPanel1.Name = "searchPanel1";
            searchPanel1.SearhText = "Поиск...";
            searchPanel1.Size = new Size(439, 58);
            searchPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 443);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 30);
            panel1.TabIndex = 23;
            // 
            // MealAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(682, 473);
            Controls.Add(panel1);
            Controls.Add(searchPanel1);
            Controls.Add(createButton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(700, 520);
            MinimumSize = new Size(700, 520);
            Name = "MealAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += MealAddForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FormControls.MyPanel createButton;
        private FormControls.SearchPanel searchPanel1;
        private Panel panel1;
    }
}