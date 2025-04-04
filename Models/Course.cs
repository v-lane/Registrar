namespace Registrar.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("course")]
public class Course
{
    [Key] 
    public int Id { get; set; }
    public string Code { get; set; } = "";
    public string Title { get; set; } = "";
    public int WeeklyHours { get; set; }
    // public bool isEnrolled { get; set; } = false;
    
    // Navigation Property
    public ICollection<Registration>? Registrations { get; set; }
    
    public override string ToString()
    {
        return Code + " " + Title + " - " + WeeklyHours.ToString() + (WeeklyHours == 1 ? " hour" : " hours") +
               " per week";
    }
}