using Architecture.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.ASP.Controllers
{
    public class VakantieController : Controller
    {
        private IVakantieRepository _repo;

        public VakantieController(IVakantieRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var gerecht = _repo.GetOne(id.Value);
                return View(gerecht);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vakantie vakantie)
        {
            if (id != vakantie.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var model = _repo.Update(vakantie);
                return RedirectToAction("Index");
            }
            return View(vakantie);
        }


        public ActionResult Delete(int id)
        {
            var model = _repo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var model = _repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
