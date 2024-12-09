namespace HealthyLife_Pt2.Models;


public class UserWeight
{
    public int id { get; set; }
    public DateTime updated_at { get; set; }
    public double weight { get; set; }
    public double goal { get; set; }
    public User user { get; set; }

}

