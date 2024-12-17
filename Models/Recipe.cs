using System;
using System.Collections.Generic;

namespace HealthyLife_Pt2.Models;

public class Recipe
{
    public int id { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
    public Element element { get; set; } = new Element();
    public string? photo { get; set; }
    public bool verified { get; set; } = false;

    public List<Ingredient> ingredients { get; set; } = new List<Ingredient>();
    public List<User> users { get; set; } = new List<User>();

    public override bool Equals(object? obj)
    {
        if (obj as  Recipe == null) return false;
        return base.Equals((Recipe)obj);
    }
    public bool Equals(Recipe recipe)
    {
        if (this.id == recipe.id)
            return true;
        return false;
    }
}
