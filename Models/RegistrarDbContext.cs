namespace Registrar.Models;
using Microsoft.EntityFrameworkCore;

public class RegistrarDbContext : DbContext
{
    public RegistrarDbContext(DbContextOptions<RegistrarDbContext> options) : base(options)
    {
        // Optional constructor code
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Registration> Registrations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Course)
            .WithMany(c => c.Registrations)
            .HasForeignKey(r => r.CourseId);
        
        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Student)
            .WithMany(s => s.Registrations)
            .HasForeignKey(r => r.StudentId);
        
        modelBuilder.Entity<Registration>()
            .HasKey(r => new {r.StudentId, r.CourseId});
    }


}