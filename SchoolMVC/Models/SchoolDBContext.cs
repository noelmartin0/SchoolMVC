using Microsoft.EntityFrameworkCore;

namespace SchoolMVC.Models
{
    public class SchoolDBContext : DbContext

    {

        public SchoolDBContext()
        {

        }

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }

        public DbSet<TeacherModel> Teachers{ get; set; }
        public DbSet<SubjectModel> Subjects{ get; set; }

    }
}
