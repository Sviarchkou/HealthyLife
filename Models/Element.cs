using System;
using System.Collections.Generic;

namespace HealthyLife_Pt2.Models;

public partial class Element
{
    public int id { get; set; }
    public int calories { get; set; } = 0;
    public double proteins { get; set; } = 0;
    public double fats { get; set; } = 0;
    public double carbohydrates { get; set; } = 0;

    public string? minerals { get; set; }
    public string? vitamins { get; set; }

    public virtual Meal? diet { get; set; }
    public virtual Product? product { get; set; }
    public virtual Recipe? recipe { get; set; }

    public override string ToString()
    {
        double p = Math.Round(proteins * 10) / 10;
        double f = Math.Round(fats * 10) / 10;
        double c = Math.Round(carbohydrates * 10) / 10;
        return $"K - {calories} ккал, Б - {p}г., Ж - {f}г., У - {c}г.";
    }
}
