using HealthyLife_Pt2.Forms.Registrarion;
using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Controllers;

namespace HealthyLife_Pt2.Forms.Registrarion
{
    public partial class GoalForm : Form
    {
        private const string cacheFileName = "goalReg.txt";

        int buttonNum = 0;
        public GoalForm()
        {
            InitializeComponent(); 

            loadData();
        }

        private async void loadData()
        {
            try
            {
                string str = await CacheWorker.readData(cacheFileName);
                switch (str[0])
                {
                    case '1':
                        button1_Click(new Object(), new EventArgs());
                        break;
                    case '2':
                        button2_Click(new Object(), new EventArgs());
                        break;
                    case '3':
                        button3_Click(new Object(), new EventArgs());
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleGreen;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.PaleGreen;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.PaleGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Ivory;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Ivory;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Ivory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonNum == 2)
            {
                button2.MouseEnter += button2_MouseEnter;
                button2.MouseLeave += button2_MouseLeave;
                button2_MouseLeave(sender, e);
            }
            if (buttonNum == 3)
            {
                button3.MouseEnter += button3_MouseEnter;
                button3.MouseLeave += button3_MouseLeave;
                button3_MouseLeave(sender, e);
            }

            button1.BackColor = Color.GreenYellow;
            button1.MouseEnter -= button1_MouseEnter;
            button1.MouseLeave -= button1_MouseLeave;
            buttonNum = 1;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonNum == 1)
            {
                button1.MouseEnter += button1_MouseEnter;
                button1.MouseLeave += button1_MouseLeave;
                button1_MouseLeave(sender, e);
            }
            if (buttonNum == 3)
            {
                button3.MouseEnter += button3_MouseEnter;
                button3.MouseLeave += button3_MouseLeave;
                button3_MouseLeave(sender, e);
            }

            button2.BackColor = Color.GreenYellow;
            button2.MouseEnter -= button2_MouseEnter;
            button2.MouseLeave -= button2_MouseLeave;
            buttonNum = 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (buttonNum == 1)
            {
                button1.MouseEnter += button1_MouseEnter;
                button1.MouseLeave += button1_MouseLeave;
                button1_MouseLeave(sender, e);
            }
            if (buttonNum == 2)
            {
                button2.MouseEnter += button2_MouseEnter;
                button2.MouseLeave += button2_MouseLeave;
                button2_MouseLeave(sender, e);
            }
            button3.BackColor = Color.GreenYellow;
            button3.MouseEnter -= button3_MouseEnter;
            button3.MouseLeave -= button3_MouseLeave;
            buttonNum = 3;
        }


        private async void writeCache()
        {
            await Task.Run(() => CacheWorker.writeData(cacheFileName, buttonNum.ToString()));
        }

        private void back_Click(object sender, EventArgs e)
        {
            writeCache();
            ActivityLevelForm activityLevel = new ActivityLevelForm();
            activityLevel.Show();
            this.Close();

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (buttonNum == 0)
            {
                MessageBox.Show("Сначала выберете цель");
                return;
            }
            writeCache();
            FinalRegForm final = new FinalRegForm();
            final.Show();
            this.Close();
        }
    }
}
