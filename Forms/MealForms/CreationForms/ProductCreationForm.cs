﻿using HealthyLife_Pt2.Controllers;
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

namespace HealthyLIfe_Pt2.Forms
{
    public partial class ProductCreationForm : Form
    {
        
        public Product? product { get; private set; }

        User user;

        public ProductCreationForm(User user)
        {
            InitializeComponent();
            this.user = user;
            addButton.Text = "Дабавить";
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            product = new Product();
            product.name = nameTextBox.Text;
            product.category = categoryTextBox.Text;
            product.description = descriptionTextBox.Text;

            Element element = new Element();

            try
            {
                element.calories = Int32.Parse(caloriesTextBox.Text);
                element.proteins = Double.Parse(proteinsTextBox.Text);
                element.fats = Double.Parse(fatsTextBox.Text);
                element.carbohydrates = Double.Parse(carboTextBox.Text);
                element.minerals = mineralsTextBox.Text;
                element.vitamins = vitaminsTextBox.Text;
            }catch(Exception ex)
            {
                MessageBox.Show("Неверные параметры");
                return;
            }

            product.element = element;
            
            if (user.role == true)
                product.verified = true; 

            ProductController productController = new ProductController();
            await productController.insertProduct(product);

            MessageBox.Show("Продукт добавлен");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Image? image;
                product.photo = MyImageConverter.chooseImage(out image);

                if (image == null)
                    return;

                pictureBox1.Image = image;
            } catch (Exception ex) { MessageBox.Show("Не получилось добавить фото("); }
        }
    }
}
