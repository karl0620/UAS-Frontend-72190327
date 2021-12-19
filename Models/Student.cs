using System;
using System.ComponentModel.DataAnnotations;

namespace UAS.Models
{
    public class Student
    {
        public String studentId { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100,MinimumLength =2)]
        public String lastName { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100,MinimumLength =2)]
        public String firstName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}