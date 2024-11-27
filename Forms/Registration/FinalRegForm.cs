using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Forms.Registrarion;
using HealthyLife_Pt2.Models;

namespace HealthyLife_Pt2.Forms
{
    public partial class FinalRegForm : Form
    {

        private const string userInfo = "userInfo.txt";
        private const string userData = "userDataRegistrarion.txt";
        private const string activityLevel = "activityLevelReg.txt";
        private const string goalReg = "goalReg.txt";
        
        
        public FinalRegForm()
        {
            InitializeComponent();
        }

        private async void register_Click(object sender, EventArgs e)
        {

            User user = new User();
            string str = await CacheWorker.readData(userInfo);
            string[] data = str.Split("\n");
            user.username = data[0];
            user.password = data[1];

            user.role = false;

            str = await CacheWorker.readData(userData);
            data = str.Split("\n");
            user.setSexAsString(data[0]);
            user.weight = Double.Parse(data[1]);
            user.height = Int32.Parse(data[2]);
            user.dateOfBirth = DateOnly.Parse(data[3]);

            str = await CacheWorker.readData(activityLevel);
            user.setActivityAsString(str[0].ToString());


            str = await CacheWorker.readData(goalReg);
            user.setGoalAsString(str[0].ToString());

            UserController userController = new UserController();
            try
            {
                await userController.insertUser(user);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка регистрации");
                return;
            }

            MessageBox.Show("Вы зарегистрированы");

            WellcomeScrin scrin = new WellcomeScrin();
            scrin.Show();
            
            this.Close();
            
            await CacheWorker.dropCache();
        }
        private void back_Click(object sender, EventArgs e)

        {
            GoalForm goal = new GoalForm();
            goal.Show();
            this.Close();
        }
    }

}
