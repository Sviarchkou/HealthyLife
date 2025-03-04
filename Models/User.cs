﻿using System;
using System.Collections.Generic;

namespace HealthyLife_Pt2.Models;
public enum Sex
{
    male = 0,
    female = 1,
    other = 2
}
public enum Goal
{
    loss = 0,
    maintenance = 1,
    gain = 2
}
public enum Activity
{
    low = 0,
    medium = 1,
    high = 2
}

public class User
{
    public Guid id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public bool role { get; set; }

    public Sex sex { get; set; }
    public string getSexAsString()
    {
        switch (sex)
        {
            case Sex.male:
                return "male";
            case Sex.female:
                return "female";
            case Sex.other:
                return "other";
            default:
                return "";
        }
    }
    public string getSexAsStringRu()
    {
        switch (sex)
        {
            case Sex.male:
                return "Мужской";
            case Sex.female:
                return "Женский";
            case Sex.other:
                return "Другое";
            default:
                return "";
        }
    }
    public void setSexAsString(string str)
    {
        switch(str){
            case "male":
            case "1":
                sex = Sex.male;
                break;
            case "female":
            case "2":
                sex = Sex.female;
                break;
            case "other":
            case "3":
                sex = Sex.other;
                break;
        }
    }

    public double weight { get; set; }
    public int height { get; set; }
    
    public Activity activity { get; set; }
    public string getActivityAsString()
    {
        switch (activity)
        {
            case Activity.low:
                return "low";
            case Activity.medium:
                return "medium";
            case Activity.high:
                return "high";
            default:
                return "";
        }
    }
    public string getActivityAsStringRu()
    {
        switch (activity)
        {
            case Activity.low:
                return "Низкий";
            case Activity.medium:
                return "Средний";
            case Activity.high:
                return "Высокий";
            default:
                return "";
        }
    }
    public void setActivityAsString(string str)
    {
        switch (str)
        {
            case "low":
            case "1":
                activity = Activity.low;
                break;
            case "medium":
            case "2":
                activity = Activity.medium;
                break;
            case "high":
            case "3":
                activity = Activity.high;
                break;
        }
    }
    
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
    public string getGoalAsStringRu()
    {
        switch (goal)
        {
            case Goal.loss:
                return "Похудение";
            case Goal.maintenance:
                return "Поддержание веса";
            case Goal.gain:
                return "Набор массы";
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

    public DateTime dateOfBirth { get; set; }
    public string? photo { get; set; }
    public Element element { get; set; }
    public List<Diet> selectedDiets { get; set; } = new List<Diet>();
    public List<Diet> diets { get; set; } = new List<Diet>();
    public List<Recipe> recipes { get; set; } = new List<Recipe>();
    public List<UserWeight> userWeights { get; set; } = new List<UserWeight>();

    public int getAge()
    {
        int age = DateTime.Now.Year - this.dateOfBirth.Year;
        if (DateTime.Now.Month <= this.dateOfBirth.Month)
        {
            if (DateTime.Now.Day <= this.dateOfBirth.Day)
            {
                age -= 1;
            }
        }
        return age;
    }
}
