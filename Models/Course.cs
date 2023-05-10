using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningManagementSystemProject.Models
{
    public class Course
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required, MaxLength(100)]
        public string CourseName { get; set; }
        [Required]
        public string CourseCode { get; set; }
        public int Credit { get; set; }
        public int Lecture { get; set; }
        public int Lab { get; set; }
        public int Training { get; set; }
        public string CourseImage { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<StaffCourse> staffcourses { get; set; }
    }
}
