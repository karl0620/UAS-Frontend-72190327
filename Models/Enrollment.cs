using System;

namespace UAS.Models
{
    public class Enrollment
    {
        public Student Student { get; set; }
        public String studentID { get; set; }
        public String lastName { get; set; }
        public DateTime enrollmentDate { get; set; }
        public int enrollmentID { get; set; }
        public String grade { get; set; }
        public int courseID { get; set; }
        public String title { get; set; }
        public int credits { get; set; }
    }
}