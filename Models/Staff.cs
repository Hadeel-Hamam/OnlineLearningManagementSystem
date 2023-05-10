using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningManagementSystemProject.Models
{
    public class Staff
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public string NationalID { get; set; }
        public string Mobile { get; set; }
        [Required]
        public string Email { get; set; }
        public string StaffImage { get; set; }
       public virtual ICollection<StaffCourse> staffcourses { get; set; }
    }
}
