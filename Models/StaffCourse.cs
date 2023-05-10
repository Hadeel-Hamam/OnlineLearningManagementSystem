using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningManagementSystemProject.Models
{
    public class StaffCourse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int CourseID { get; set; }
        public Course course { get; set; }
    }
}
