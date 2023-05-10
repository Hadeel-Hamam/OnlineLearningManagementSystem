using System.ComponentModel.DataAnnotations;

namespace OnlineLearningManagementSystemProject.Models
{
    public class Student
    {

        [Key]
        public int StudentID { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public string NationalID { get; set; }
        [Required]
        public string UniversityID { get; set; }
        public string Mobile { get; set; }
        [Required]
        public string Email { get; set; }
        public int EnrollYear { get; set; }
        public string StudentPicture { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
