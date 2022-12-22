using System.ComponentModel.DataAnnotations;

namespace webApi.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Course Courses { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
    public enum Course
    {
        VB, SQL, CSharp
    }
}
