using PartialViewToController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewToController.Controllers
{
    public class DesignationsController : Controller
    {
        // GET: Designations
        HrModel db = new HrModel();
        public ActionResult Index()
        {
            return View(db.Designations.ToList());
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(db.Designations.Find(id));
        }
        [HttpPost]
        public ActionResult Save(string name,decimal Basic,decimal Convence,decimal MA,decimal mobile,decimal HR,int? id)
        {
            if(id>0)
            {
                //Update
                var model = db.Designations.Find(id);
                model.Basic = Basic;
                model.Name = name;
                model.HRrate = HR;
                model.Id = int.Parse(id.ToString());
                model.MARate = MA;
                model.Convence = Convence;
                model.MobileBill = mobile;
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            else
            {
                Designation designation = new Designation()
                {
                    Name=name, MobileBill = mobile,Basic=Basic,Convence=Convence,MARate=MA,HRrate=HR
                };
                db.Designations.Add(designation);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public JsonResult Edit(int id)
        {
            var model = db.Designations.Find(id);
            return Json(model,JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delete(int id)
        {
            var model = db.Designations.Find(id);
            db.Designations.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
           // return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}