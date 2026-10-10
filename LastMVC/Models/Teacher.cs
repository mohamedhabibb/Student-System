using LastMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace firstMVC.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        List<Course> Courses { get; set; }
    }
}
