namespace Registrar.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")]
public class Student
{
    [Key] public int Id { get; set; } = new Random().Next(100000, 999999);
    [Required][MaxLength(50)] public string FirstName { get; set; } = "";
    [Required][MaxLength(100)] public string LastName { get; set; } = "";
    [Required][MaxLength(10)] public string Type { get; set; } = "";

    // Navigation Property
    public ICollection<Registration>? Registrations { get; set; }

    // public List<Course> Courses {get; set;}
}