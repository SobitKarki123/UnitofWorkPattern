using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitofWorkPatternRepositoryPattern.Models;
using UnitofWorkPatternRepositoryPattern.Repository;
using UnitofWorkPatternRepositoryPattern.Repository.Contacts;
using UnitofWorkPatternRepositoryPattern.ServiceLayer;

namespace UnitofWorkPatternRepositoryPattern.Controllers
{
    public class GenericContactsController : Controller
    {
      
     
       private readonly IContactService _contactService;

      

        public GenericContactsController(IContactService contactService)
        {
           
            this._contactService = contactService;

        }

        public ActionResult Index()
        {
            return View(_contactService.GetAll());
        }

        //
        // GET: /Contacts/Details/5

        public ActionResult Details(int id = 0)
        {
            Contact contact = _contactService.Get(c => c.Id == id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        //
        // GET: /Contacts/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contacts/Create

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Post(contact);
              
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        //
        // GET: /Contacts/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Contact contact = _contactService.Get(c => c.Id == id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        //
        // POST: /Contacts/Edit/5

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Attach(contact);
                
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        //
        // GET: /Contacts/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Contact contact = _contactService.Get(c => c.Id == id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        //
        // POST: /Contacts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = _contactService.Get(c => c.Id == id);
          
            return RedirectToAction("Index");
        }
    }
}