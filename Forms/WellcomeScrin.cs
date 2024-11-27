using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms
{
    public partial class WellcomeScrin : Form
    {
        public WellcomeScrin()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registrarion = new Registration();
            registrarion.Show();
            this.Hide();
        }
    }
}
