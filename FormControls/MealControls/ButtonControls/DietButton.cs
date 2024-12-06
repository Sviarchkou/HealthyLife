﻿using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLife_Pt2.FormControls.MealControls
{
    public partial class DietButton : UserControl
    {
        public event EventHandler? DietButtonClicked;
        public event EventHandler? DietButtonMouseEnter;
        public event EventHandler? DietButtonMouseLeave;

        public Color PanelColor
        {
            get => dietPanel.PanelColor;
            set
            {
                dietPanel.PanelColor = value;
                name.BackColor = value;
                description.BackColor = value;
            }
        }

        public Diet diet { get; private set; }
        public DietButton(Diet diet)
        {
            InitializeComponent();            
            this.diet = diet;

            description.Text = diet.description;
            name.Text = diet.name;

            if (diet.photo == null || diet.photo == "")
                return;
            pictureBox.Image = MyImageConverter.converFromStringBytes(diet.photo);

        }

        private void dietButtonClicked(object sender, EventArgs e)
        {
            DietButtonClicked?.Invoke(this, e);
        }

        private void dietButtonMouseEnter(object sender, EventArgs e)
        {
            DietButtonMouseEnter?.Invoke(this, e);
        }
        private void dietButtonMouseLeave(object sender, EventArgs e)
        {
            DietButtonMouseLeave?.Invoke(this, e);
        }
    }
}
