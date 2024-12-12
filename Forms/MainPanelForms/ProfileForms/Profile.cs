using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls.MealControls;
using HealthyLife_Pt2.Models;
using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;
using HealthyLife_Pt2.Forms.MealForms;
using HealthyLIfe_Pt2;
using HealthyLife_Pt2.Forms.MainPanelForms.Profile;

namespace HealthyLife_Pt2.Forms.MainPanelForms.ProfileForms
{
    public partial class Profile : Form
    {
        User user;
        List<Recipe> recipes = new List<Recipe>();
        List<Diet> diets = new List<Diet>();

        List<RecipeFormButton> recipeFormButtons = new List<RecipeFormButton>();
        List<DietButton> dietButtons = new List<DietButton>();

        Point startPoint = new Point(33, 315);
        int recipeStepX = 360;
        int recipeStepY = 360;
        int dietStepX = 260;
        int dietStepY = 320;

        public Profile(User user)
        {
            InitializeComponent();
            this.user = user;
            fillForm();
        }

        private async void fillForm()
        {
            loginLabel.Text = user.username;
            ageLabel.Text = user.getAge().ToString();
            currentWeightLabel.Text = (Math.Round(user.weight * 10) / 10).ToString();
            heightLabel.Text = user.height.ToString();
            sexLabel.Text = user.getSexAsStringRu();
            activityLevelLabel.Text = user.getActivityAsStringRu();
            goalLabel.Text = user.getGoalAsStringRu();
            if (user.photo != null && user.photo != "")
                pictureBox.Image = MyImageConverter.converFromStringBytes(user.photo);

            RecipeController recipeController = new RecipeController();
            recipes = await recipeController.selectUserRecipes(user.id.ToString());

            DietController dietController = new DietController();
            diets = await dietController.selectUserDiets(user.id.ToString());

            fillRecipeList();
            fillDietList();
        }

        private void fillRecipeList()
        {

            for (int i = 0; i < recipes.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    createRecipeButton(recipes[i], new Point(startPoint.X, startPoint.Y + recipeStepY * (i / 2)));
                }
                else
                {
                    createRecipeButton(recipes[i], new Point(startPoint.X + recipeStepX, startPoint.Y + recipeStepY * (i / 2)));
                }
            }
        }
        private void createRecipeButton(Recipe recipe, Point point)
        {
            RecipeFormButton recipeFormButton = new RecipeFormButton(recipe);
            recipeFormButton.Location = point;
            recipeFormButton.Visible = false;

            recipeFormButtons.Add(recipeFormButton);
            recipeFormButton.BringToFront();
            recipeFormButton.RecipeFormButtonMouseEnter += delegate (object? sender, EventArgs e)
            {
                if (sender == null) return;
                ((RecipeFormButton)sender).PanelColor = Color.YellowGreen;
            };
            recipeFormButton.RecipeFormButtonMouseLeave += delegate (object? sender, EventArgs e)
            {
                if (sender == null) return;
                ((RecipeFormButton)sender).PanelColor = Color.Gainsboro;
            };
            recipeFormButton.RecipeFormButtonClicked += delegate (object? sender, EventArgs e)
            {
                if (sender == null)
                    return;
                RecipeDescriptionForm recipeDescriptionForm = new RecipeDescriptionForm(((RecipeFormButton)sender).recipe);
                DialogResult dialogResult = recipeDescriptionForm.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    recipes.Remove(((RecipeFormButton)sender).recipe);
                    recipeFormButtons.Clear();
                    fillRecipeList();
                }

            };

            Controls.Add(recipeFormButton);
        }

        public void fillDietList()
        {
            int n = diets.Count / 3;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    if (index >= diets.Count)
                        return;
                    createDietButton(diets[i * 3 + j], new Point(startPoint.X + j * dietStepX, startPoint.Y + i * dietStepY));
                }
            }
        }

        private void createDietButton(Diet diet, Point location)
        {
            DietButton dietButton = new DietButton(diet);
            dietButton.Location = location;
            dietButton.Visible = false;

            dietButton.DietButtonMouseEnter += delegate (object? sender, EventArgs e)
            {
                if (sender != null)
                    ((DietButton)sender).PanelColor = Color.GreenYellow;
            };
            dietButton.DietButtonMouseLeave += delegate (object? sender, EventArgs e)
            {
                if (sender != null)
                    ((DietButton)sender).PanelColor = Color.Gainsboro;
            };
            dietButton.DietButtonClicked += delegate (object? sender, EventArgs e)
            {
                if (sender == null)
                {
                    MessageBox.Show("Что-то пошло не так(");
                    return;
                }
                DietDescriptionForm descriptionForm = new DietDescriptionForm(((DietButton)sender).diet, user);
                DialogResult dialogResult = descriptionForm.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    diets.Remove(((DietButton)sender).diet);
                    dietButtons.Clear();
                    fillDietList();
                }

            };

            dietButtons.Add(dietButton);
            dietButton.BringToFront();
            Controls.Add(dietButton);
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            foreach (DietButton dietButton in dietButtons)
            {
                dietButton.Visible = false;
            }
            foreach (RecipeFormButton recipeFormButton in recipeFormButtons)
            {
                recipeFormButton.Visible = true;
            }
        }

        private void dietButton_Click(object sender, EventArgs e)
        {
            foreach (RecipeFormButton recipeFormButton in recipeFormButtons)
            {
                recipeFormButton.Visible = false;
            }
            foreach (DietButton dietButton in dietButtons)
            {
                dietButton.Visible = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ProfileEditingForm profileEditingForm = new ProfileEditingForm(user);
            profileEditingForm.ShowDialog();
            fillForm();
        }
    }
}
