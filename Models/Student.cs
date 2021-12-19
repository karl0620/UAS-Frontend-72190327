using System;
using System.ComponentModel.DataAnnotations;

namespace UAS.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String EnrollmentDate { get; set; }
    }
}