namespace Registrar.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("registration")]
public class Registration
{
    [Key, ForeignKey("Student")]
    public int StudentId { get; set; }
    [Key, ForeignKey("Course")]
    public int CourseId { get; set; }
    
    // Navigation Properties
    public Student? Student { get; set; }
    public Course? Course { get; set; }
}