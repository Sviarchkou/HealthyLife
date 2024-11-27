using System;
using System.Collections.Generic;

namespace HealthyLife_Pt2.Models;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public string? description { get; set; }
    public Element element { get; set; }
    public string? photo { get; set; }

    public List<Diet> extrafoods { get; set; } = new List<Diet>();
    public List<Recipe> recipes { get; set; } = new List<Recipe>();

    public override string ToString()
    {
        return name + "(" + element.ToString() + ");";
    }
}
