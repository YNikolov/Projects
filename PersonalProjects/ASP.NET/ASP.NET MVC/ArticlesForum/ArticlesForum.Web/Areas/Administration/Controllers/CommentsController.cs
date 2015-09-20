using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArticlesForum.Data;
using ArticlesForum.Models;

namespace ArticlesForum.Web.Areas.Administration.Controllers
{
    public class CommentsController : AdminController
    {
                // GET: Administration/Comments
        public CommentsController(IArticlesForumData data)
            : base(data)
        { }

        public ActionResult Index()
        {
            var comments = this.Data.Comments.All()
                .Include(c => c.Article)
                .Include(c => c.Author);
            
            return View(comments.ToList());
        }

        // GET: Administration/Comments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var comment = this.Data.Comments.GetById(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // GET: Administration/Comments/Create
        

        // POST: Administration/Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        // GET: Administration/Comments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var comment = this.Data.Comments.GetById(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Administration/Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                this.Data.Context.Entry(comment).State = EntityState.Modified;
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comment);
        }

        // GET: Administration/Comments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var comment = this.Data.Comments.GetById(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Administration/Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            this.Data.Comments.Delete(id);
            this.Data.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Data.Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
