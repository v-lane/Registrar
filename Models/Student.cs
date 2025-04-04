namespace Registrar.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")]
public class Student
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Type {get; set;} = "";
    
    // Navigation Property
    public ICollection<Registration>? Registrations { get; set; }
    
    // public List<Course> Courses {get; set;}
    
}