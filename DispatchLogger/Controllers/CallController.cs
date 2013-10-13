using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DispatchLogger.Models;
using DispatchLogger.Models.DAL;

namespace DispatchLogger.Controllers
{ 
    public class CallController : Controller
    {
        private CallLogDBContext db = new CallLogDBContext();

        //
        // GET: /NewCall/

        public ViewResult Index()
        {
            return View(db.CallLog.ToList());
        }

        //
        // GET: /NewCall/Details/5

        public ViewResult Details(int id)
        {
            CallLog calllog = db.CallLog.Find(id);
            return View(calllog);
        }

        //
        // GET: /NewCall/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /NewCall/Create

        [HttpPost]
        public ActionResult Create(CallLog calllog)
        {
            if (ModelState.IsValid)
            {
                db.CallLog.Add(calllog);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(calllog);
        }
        
        //
        // GET: /NewCall/Edit/5
 
        public ActionResult Edit(int id)
        {
            CallLog calllog = db.CallLog.Find(id);
            return View(calllog);
        }

        //
        // POST: /NewCall/Edit/5

        [HttpPost]
        public ActionResult Edit(CallLog calllog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calllog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calllog);
        }

        //
        // GET: /NewCall/Delete/5
 
        public ActionResult Delete(int id)
        {
            CallLog calllog = db.CallLog.Find(id);
            return View(calllog);
        }

        //
        // POST: /NewCall/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            CallLog calllog = db.CallLog.Find(id);
            db.CallLog.Remove(calllog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}