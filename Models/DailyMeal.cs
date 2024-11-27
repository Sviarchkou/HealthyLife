using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Models
{
    public class DailyMeal
    {
        public int id { get; set; }
        public User user { get; set; }
        public Meal meal { get; set; }
        public DateOnly update_at { get; set; }
    }
}
