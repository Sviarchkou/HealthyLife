using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Models
{
    public class DailyElement
    {
        public int id { get; set; }
        public User user { get; set; }
        public Element element { get; set; }
        public DateOnly date { get; set; }

    }
}
