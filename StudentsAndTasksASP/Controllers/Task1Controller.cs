﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Duble2.Models;

namespace Duble2.Controllers
{
    public class Task1Controller : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Task1
        public ActionResult Index(string groupNum)
        {
            groupNum = "asu-22-102";
            if (groupNum != "")
            {
                var g = db.TaskOneProc(groupNum);
                return View(g.ToList());
            }
            else
            {
                var rgroup = db.TaskOneProc(groupNum);
                return View(rgroup.ToList());
                //group = db.Group_2.Include(s => s.Student).Take(10);
            }    
        }

        // GET: Task1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group_2 group_2 = db.Group_2.Find(id);
            if (group_2 == null)
            {
                return HttpNotFound();
            }
            return View(group_2);
        }

        // GET: Task1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task1/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GroupNum,MajorName,Year_2")] Group_2 group_2)
        {
            if (ModelState.IsValid)
            {
                db.Group_2.Add(group_2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(group_2);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Task1Query([Bind(Include = "GroupNum,MajorName,Year_2")] Group_2 group_2)
        {
            
            if (ModelState.IsValid)
            {
                var l = db.TaskOneProc(group_2.GroupNum);
            }


            return View("Index", group_2);
        }


        // GET: Task1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group_2 group_2 = db.Group_2.Find(id);
            if (group_2 == null)
            {
                return HttpNotFound();
            }
            return View(group_2);
        }

        // POST: Task1/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GroupNum,MajorName,Year_2")] Group_2 group_2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group_2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(group_2);
        }

        // GET: Task1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group_2 group_2 = db.Group_2.Find(id);
            if (group_2 == null)
            {
                return HttpNotFound();
            }
            return View(group_2);
        }

        // POST: Task1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Group_2 group_2 = db.Group_2.Find(id);
            db.Group_2.Remove(group_2);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
