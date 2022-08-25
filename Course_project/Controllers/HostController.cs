using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course_project.Controllers
{
    public class HostController : Controller
    {
        // GET: HostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
