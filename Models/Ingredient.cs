using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Models
{
    public class Ingredient
    {
        public int id { get; set; }
        public double weight { get; set; } = 0;
        public Product product { get; set; }
        public Recipe recipe { get; set; }
    }
}
