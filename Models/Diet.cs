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
    public Goal goal { get; set; }
    public string getGoalAsString()
    {
        switch (goal)
        {
            case Goal.loss:
                return "loss";
            case Goal.maintenance:
                return "maintenance";
            case Goal.gain:
                return "gain";
            default:
                return "";
        }
    }
    public void setGoalAsString(string str)
    {
        switch (str)
        {
            case "loss":
            case "1":
                goal = Goal.loss;
                break;
            case "maintenance":
            case "2":
                goal = Goal.maintenance;
                break;
            case "gain":
            case "3":
                goal = Goal.gain;
                break;
        }
    }

    public List<Meal> meals { get; set; } = new List<Meal>();
    public List<User> users { get; set; } = new List<User>();


    public override bool Equals(object? obj)
    {
        if (obj as Diet == null) return false;
        return base.Equals((Diet)obj);
    }
    public bool Equals(Diet diet)
    {
        if (this.id == diet.id)
            return true;
        return false;
    }

}
