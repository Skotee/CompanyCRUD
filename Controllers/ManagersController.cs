using System.Linq;
using CRUD_Operations.Models;
using Microsoft.AspNetCore.Mvc;
namespace CRUD_Operations.Models
{
    public class ManagersController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Managers.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateManager(Managers manager){
            db.Managers.Add(manager);
            db.SaveChanges();
            return RedirectToAction("Index", "Managers");
        }
        [HttpPost]
        public bool Delete(int id){
            try
            {
                Managers manager = db.Managers.Where(s => s.Id == id).First();
                db.Managers.Remove(manager);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }
        public ActionResult Update(int id){
            return View(db.Managers.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateManager(Managers manager){
            Managers d = db.Managers.Where(s => s.Id == manager.Id).First();
            d.Name = manager.Name;
            d.Phone = manager.Phone;
            d.Team = manager.Team;
            db.SaveChanges();
            return RedirectToAction("Index", "Managers");
        }
    }
}