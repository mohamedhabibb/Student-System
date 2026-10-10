using System.ComponentModel.DataAnnotations;

namespace firstMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        
        List<Course> Courses { get; set; }
    }
}
