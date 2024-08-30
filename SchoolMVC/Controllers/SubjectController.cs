using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SubjectController : Controller
    {
        // GET: TeacherController
        ISubjectRepo _repo;
        public SubjectController(ISubjectRepo repo)
        {
            _repo = repo;
        }
        public ActionResult Index()
        {
            List<SubjectModel> list = new List<SubjectModel>();
            list = _repo.GetAll();
            return View(list);
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            SubjectModel model = _repo.GetById(id);
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }



        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubjectModel model)
        {
            _repo.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            SubjectModel model = _repo.GetById(id);
            return View(model);
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SubjectModel data)
        {
            _repo.Update(data);
            return RedirectToAction("Index");
        }

        // GET: TeacherController/Delete/5

        public ActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
            //return View();
        }
    }
}
