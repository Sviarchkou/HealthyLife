using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Models
{
    public class Meal
    {
        public int id { get; set; }
        public Recipe? breakfast { get; set; }
        public Recipe? lunch { get; set; }
        public Recipe? dinner { get; set; }
        public List<ExtraFood> extraFood { get; set; } = new List<ExtraFood>();
        public Element element { get; set; } = new Element();

    }
}
