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
    public bool verified { get; set; } = false;

    public List<Diet> extrafoods { get; set; } = new List<Diet>();
    public List<Recipe> recipes { get; set; } = new List<Recipe>();

    public override string ToString()
    {
        return name + "(" + element.ToString() + ");";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is Product) return Equals((Product)obj);
        return false;
    }
    private bool Equals(Product p)
    {
        if (p.id == this.id) 
            return true;
        if (p.name == this.name && 
            p.category == this.category &&
            p.description == p.description &&
            this.element.Equals(p.element))
        {
            return true;
        }
        return false;
    }
}
