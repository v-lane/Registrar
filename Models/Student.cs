namespace Registrar;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Type {get; set;} = "";
    public List<Course> Courses {get; set;}
    
}