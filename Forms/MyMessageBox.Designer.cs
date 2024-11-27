namespace HealthyLIfe_Pt2.Forms
{
    partial class MyMessageBox
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.MaximumSize = new Size(450, int.MaxValue);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 0;
            label1.SizeChanged += label1_SizeChanged;
            // 
            // MyMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(482, 283);
            Controls.Add(label1);
            Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(500, 330);
            Name = "MyMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MyMessageBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;

        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }
    }
}