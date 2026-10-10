using System.ComponentModel.DataAnnotations;

namespace firstMVC.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher teacher { get; set; }
        public Student student { get; set; }

       
    }
}
