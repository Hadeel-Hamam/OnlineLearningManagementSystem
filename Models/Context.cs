using Microsoft.EntityFrameworkCore;

namespace OnlineLearningManagementSystemProject.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StaffCourse> StaffCourses { get; set; }

        
    }

}
