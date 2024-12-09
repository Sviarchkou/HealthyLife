namespace HealthyLife_Pt2.Forms.MealForms.AddFroms
{
    partial class ExtraFoodAddForm
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
            infoButton = new FormControls.MyPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // searchPanel1
            // 
            searchPanel1.BackColor = Color.Transparent;
            searchPanel1.Location = new Point(25, 25);
            searchPanel1.Name = "searchPanel1";
            searchPanel1.SearhText = "Поиск...";
            searchPanel1.Size = new Size(439, 58);
            searchPanel1.TabIndex = 20;
            // 
            // createButton
            // 
            createButton.BackColor = Color.Transparent;
            createButton.BorderColor = Color.DarkGray;
            createButton.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createButton.Location = new Point(470, 25);
            createButton.Name = "createButton";
            createButton.PanelColor = Color.Gainsboro;
            createButton.Rad = 60;
            createButton.Size = new Size(187, 58);
            createButton.TabIndex = 19;
            createButton.Click += createButton_Click;
            // 
            // infoButton
            // 
            infoButton.BorderColor = Color.DarkGray;
            infoButton.Font = new Font("Verdana", 10.2F);
            infoButton.Location = new Point(500, 107);
            infoButton.Name = "infoButton";
            infoButton.PanelColor = Color.Gainsboro;
            infoButton.Rad = 30;
            infoButton.Size = new Size(157, 77);
            infoButton.TabIndex = 21;
            infoButton.Click += infoButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 443);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 30);
            panel1.TabIndex = 22;
            // 
            // ExtraFoodAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(682, 473);
            Controls.Add(panel1);
            Controls.Add(infoButton);
            Controls.Add(searchPanel1);
            Controls.Add(createButton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(700, 520);
            MinimumSize = new Size(700, 520);
            Name = "ExtraFoodAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private FormControls.SearchPanel searchPanel1;
        private FormControls.MyPanel createButton;
        private FormControls.MyPanel infoButton;
        private Panel panel1;
    }
}