using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.FormControls
{
    public partial class SearchPanel : UserControl
    {

        public string SearhText
        {
            get => search.Text;
            set => search.Text = value;
        }

        public EventHandler? SearchTextChanged;

        public SearchPanel()
        {
            InitializeComponent();
        }

        public Panel Filter
        {
            get => filter;
            private set => filter = value;
        }

        public TextBox Search
        {
            get => search;
            private set => search = value;
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
            search.ForeColor = Color.Black;
        }

        private void searchPanel_Load(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, e);
        }
    }
}
