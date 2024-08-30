using System.ComponentModel.DataAnnotations;

namespace SchoolMVC.Models
{
    public class SubjectModel
    {
        [Key]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int TeacherID { get; set; }
    }
}
