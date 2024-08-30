namespace SchoolMVC.Models
{
    public interface ISubjectRepo
    {
        public void Add(SubjectModel model);
        public void Update(SubjectModel model);
        SubjectModel GetById(int id);
        List<SubjectModel> GetAll();
        public void Delete(int id);
    }
    public class SubjectRepo : ISubjectRepo
    {
        SchoolDBContext _context;
        public SubjectRepo(SchoolDBContext context)
        {
            _context = context;
        }
        void ISubjectRepo.Add(SubjectModel model)
        {
            _context.Subjects.Add(model);
            _context.SaveChanges();
        }

        void ISubjectRepo.Delete(int id)
        {
            SubjectModel model = _context.Subjects.Find(id);
            _context.Subjects.Remove(model);
            _context.SaveChanges();

        }

        List<SubjectModel> ISubjectRepo.GetAll()
        {
            return _context.Subjects.ToList();
        }

        SubjectModel ISubjectRepo.GetById(int id)
        {
            SubjectModel model = _context.Subjects.Find(id);
            return model;
        }

        void ISubjectRepo.Update(SubjectModel model)
        {
            SubjectModel m = _context.Subjects.SingleOrDefault(i => i.SubjectID == model.SubjectID);
            m.SubjectName = model.SubjectName;
            _context.SaveChanges();

        }
    }
}
