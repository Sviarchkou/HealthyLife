namespace HealthyLife_Pt2.FormControls
{
    partial class SearchPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPanel));
            filter = new Panel();
            panel1 = new Panel();
            search = new TextBox();
            myPanel1 = new MyPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // filter
            // 
            filter.BackColor = Color.Gainsboro;
            filter.BackgroundImage = (Image)resources.GetObject("filter.BackgroundImage");
            filter.BackgroundImageLayout = ImageLayout.Zoom;
            filter.Location = new Point(380, 15);
            filter.Name = "filter";
            filter.Size = new Size(30, 30);
            filter.TabIndex = 19;
            filter.Click += filter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(365, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 40);
            panel1.TabIndex = 18;
            panel1.Click += filterPanel_Hide;
            // 
            // search
            // 
            search.BackColor = Color.Gainsboro;
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Verdana", 11.8F);
            search.ForeColor = Color.FromArgb(64, 64, 64);
            search.Location = new Point(25, 15);
            search.Name = "search";
            search.Size = new Size(320, 24);
            search.TabIndex = 16;
            search.TabStop = false;
            search.Text = "Поиск...";
            search.Click += search_Click;
            search.TextChanged += search_TextChanged;
            // 
            // myPanel1
            // 
            myPanel1.BackColor = Color.Transparent;
            myPanel1.BorderColor = Color.Transparent;
            myPanel1.Location = new Point(9, 0);
            myPanel1.Margin = new Padding(0);
            myPanel1.Name = "myPanel1";
            myPanel1.PanelColor = Color.Gainsboro;
            myPanel1.Rad = 60;
            myPanel1.Size = new Size(424, 58);
            myPanel1.TabIndex = 17;
            myPanel1.Click += filterPanel_Hide;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = Color.White;
            flowLayoutPanel.Location = new Point(133, 45);
            flowLayoutPanel.MaximumSize = new Size(300, int.MaxValue);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(300, 0);
            flowLayoutPanel.TabIndex = 20;
            // 
            // SearchPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel);
            Controls.Add(filter);
            Controls.Add(panel1);
            Controls.Add(search);
            Controls.Add(myPanel1);
            Name = "SearchPanel";
            Size = new Size(436, 60);
            Click += filterPanel_Hide;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel filter;
        private Panel panel1;
        private TextBox search;
        private MyPanel myPanel1;
        public FlowLayoutPanel flowLayoutPanel;
    }
}
