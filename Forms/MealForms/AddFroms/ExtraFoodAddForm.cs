using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.FormControls;
using HealthyLife_Pt2.FormControls.MealControls.AdditionContols;
using HealthyLife_Pt2.Forms.MealForms.DescriptionForms;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.Forms.MealForms.AddFroms
{
    public partial class ExtraFoodAddForm : Form
    {

        List<ExtraFood> selectedExtraFood = new List<ExtraFood>();

        List<Product> products = new List<Product>();
        IEnumerable<Product> filteredProducts = new List<Product>();

        List<ExtraFoodAddition> extraFoodAdditions = new List<ExtraFoodAddition>();
        List<ExtraFoodAddition> currentExtraFoodAdditions = new List<ExtraFoodAddition>();

        private SearchPanelFilterButtonList searchPanelFilterButtonList = new SearchPanelFilterButtonList(new Product());

        private Point startPoint = new Point(25, 105);
        private int step = 90;

        User user;

        public ExtraFoodAddForm(List<ExtraFood> selectedExtraFood, User user)
        {
            InitializeComponent();
            this.selectedExtraFood = selectedExtraFood;
            this.user = user;

            fillForm();
            searchPanel1.SearchTextChanged += delegate (object? sender, EventArgs e)
            {
                updateList();
            };
            searchPanel1.FilterClick += delegate (object? sender, EventArgs e)
            {
                List<Button> buttons = searchPanelFilterButtonList.productFilterButtons;
                searchPanel1.flowLayoutPanel.Size = new Size(300, buttons.Count * buttons[0].Height);
                for (int i = 0; i < buttons.Count; i++)
                {
                    searchPanel1.flowLayoutPanel.Controls.Add(buttons[i]);
                    buttons[i].Click += delegate (object? sender, EventArgs e)
                    {
                        if (sender == null)
                            return;
                        int index = searchPanelFilterButtonList.productFilterButtons.IndexOf((Button)sender);
                        if (index < 0) return;
                        products.Sort(searchPanelFilterButtonList.productComparisons[index]);
                        searchPanel1.SearhText = "";
                        updateList();
                        searchPanel1.flowLayoutPanel.Height = 0;
                        searchPanel1.Height = 60;
                    };
                }

            };

            createButton.Text = "Добавить продукт";
            infoButton.Text = "Просмотр добавленных продуктов";
        }

        private async void fillForm()
        {
            ProductController productController = new ProductController();
            products = await productController.select("SELECT * FROM products");
            for (int i = 0; i < products.Count; i++)
            {
                currentExtraFoodAdditions.Add(createExtraFoodAddition(products[i], new Point(startPoint.X, startPoint.Y + step * i)));
            }

        }

        private void filterProducts()
        {
            string str = searchPanel1.SearhText;
            filteredProducts = from p in products where p.name.ToLower().Contains(str.ToLower()) select p;
        }

        private async void updateList()
        {
            if (searchPanel1.SearhText == "")
                filteredProducts = products;
            else
                await Task.Run(() => filterProducts());

            currentExtraFoodAdditions.Clear();
            foreach (ExtraFoodAddition extraFoodAddition in extraFoodAdditions)
            {
                extraFoodAddition.Visible = false;
            }

            foreach (Product p in filteredProducts)
            {
                foreach (ExtraFoodAddition extraFoodAddition in extraFoodAdditions)
                {
                    if (p.Equals(extraFoodAddition.product))
                    {
                        currentExtraFoodAdditions.Add(extraFoodAddition);
                        extraFoodAddition.Visible = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < currentExtraFoodAdditions.Count; i++)
            {
                currentExtraFoodAdditions[i].Location = new Point(startPoint.X, startPoint.Y + i * step);
            }

        }

        private ExtraFoodAddition createExtraFoodAddition(Product product, Point location)
        {
            ExtraFoodAddition extraFoodAddition = new ExtraFoodAddition(product, user);
            extraFoodAddition.Location = location;
            extraFoodAddition.RemovedProduct += delegate ()
            {
                products.Remove(extraFoodAddition.product);
                extraFoodAddition.Dispose();
                if (searchPanel1.SearhText == "Поиск...")
                    searchPanel1.SearhText = "";
                updateList();
            };
            foreach (ExtraFood extraFood in selectedExtraFood)
            {
                if (extraFood.product.Equals(product))
                {
                    extraFoodAddition.weight = extraFood.weight;
                }
            }
            Controls.Add(extraFoodAddition);
            extraFoodAdditions.Add(extraFoodAddition);
            return extraFoodAddition;
        }

        public List<ExtraFood> getSelectedExtraFoods()
        {
            selectedExtraFood.Clear();
            foreach (ExtraFoodAddition extraFoodAddition in extraFoodAdditions)
            {
                if (!extraFoodAddition.selected)
                    continue;
                if (!products.Contains(extraFoodAddition.product))
                    continue;
                try
                {
                    selectedExtraFood.Add(extraFoodAddition.getExtraFood());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
            return selectedExtraFood;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ProductCreationForm productCreationForm = new ProductCreationForm(user);
            productCreationForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (sender == null)
                    return;
                Product? p = ((ProductCreationForm)sender).product;

                if (p == null)
                    return;

                products.Add(p);
                if (searchPanel1.SearhText == "Поиск...")
                    searchPanel1.SearhText = "";
                Point point = extraFoodAdditions.Last().Location;
                createExtraFoodAddition(p, new Point(point.X, point.Y + step));
                updateList();
            };
            productCreationForm.Show();
            
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            ExtraFoodDescriptionForm extraFoodDescriptionForm = new ExtraFoodDescriptionForm(getSelectedExtraFoods(), user);            
            extraFoodDescriptionForm.ShowDialog();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.LightGray;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((MyPanel)sender).PanelColor = Color.Gainsboro;
        }
    }
}
