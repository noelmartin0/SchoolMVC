namespace SchoolMVC.Models
{
    public interface ITeacherRepo
    {
        public void Add(TeacherModel model);
        public void Update(TeacherModel model);
        TeacherModel GetById(int id);
        List<TeacherModel> GetAll();
        public void Delete(int id);
    }
    public class TeacherRepo : ITeacherRepo
    {
        SchoolDBContext _context;
        public TeacherRepo(SchoolDBContext context)
        {
            _context = context;
        }
        void ITeacherRepo.Add(TeacherModel model)
        {
            _context.Teachers.Add(model);
            _context.SaveChanges();
        }

        void ITeacherRepo.Delete(int id)
        {
            TeacherModel model = _context.Teachers.Find(id);
            _context.Teachers.Remove(model);
            _context.SaveChanges();

        }

        List<TeacherModel> ITeacherRepo.GetAll()
        {
           return _context.Teachers.ToList();
        }

        TeacherModel ITeacherRepo.GetById(int id)
        {
            TeacherModel model = _context.Teachers.Find(id);
            return model;
        }

        void ITeacherRepo.Update(TeacherModel model)
        {
            TeacherModel m = _context.Teachers.SingleOrDefault(i => i.TeacherID == model.TeacherID);
            m.TeacherName = model.TeacherName;
            m.City = model.City;
            _context.SaveChanges();

        }
    }
}
