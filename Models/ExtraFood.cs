using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Models
{
    public class ExtraFood
    {
        public Product product { get; set; }
        public Meal meal { get; set; }
        public int weight { get; set; }

        public Element calculateElement()
        {
            if (product == null)
                throw new InvalidOperationException();
            if (weight == 100)
                return product.element;

            Element element = new Element();            

            element.calories = product.element.calories * weight / 100;
            element.proteins = product.element.proteins * weight / 100;
            element.fats = product.element.fats * weight / 100;
            element.carbohydrates = product.element.carbohydrates * weight / 100;
            element.vitamins = product.element.vitamins;
            element.minerals = product.element.minerals;

            return element;
        }
        public override string ToString()
        {
            return $"{product.name} ({weight} г.)";
        }
    }
}
