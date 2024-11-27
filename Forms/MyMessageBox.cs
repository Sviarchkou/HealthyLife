using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLIfe_Pt2.Forms
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            //this.Size = new Size(label1.Width + 5, label1.Height + 25);
        }
    }
}
