using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StudentCreateVm
    {
        [Required]
        [StringLength(20,MinimumLength = 4)]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

    }
}
