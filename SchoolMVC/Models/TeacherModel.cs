using System.ComponentModel.DataAnnotations;

namespace SchoolMVC.Models
{
    public class TeacherModel
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string City { get; set; }
    }
}
