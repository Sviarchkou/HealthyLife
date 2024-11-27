using HealthyLife_Pt2.Models;
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
    public partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            Form childForm = new DailyCounter(user);
            childForm.TopLevel = false;
            panel2.Controls.Add(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
