using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthyLife_Pt2.Models;

public class Diet
{
    public int id { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
    public User creator { get; set; }
    public string? photo { get; set; }
     
    public List<Meal> meals { get; set; } = new List<Meal>();
    public List<User> users { get; set; } = new List<User>();
}
