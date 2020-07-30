using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsListApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContactsListApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository repo;

        public IActionResult Index()
        {
            var contacts = repo.GetAllContacts();
            return View(contacts);
        }
        
        public ContactController(IContactRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult ViewContact(int id)
        {
            var contact = repo.GetContact(id);
            return View(contact);
        }
        public IActionResult CreateContact()
        {
            var cont = repo.AssignCategory();
            return View(cont);
        }

        public IActionResult InsertContactToDatabase(Contact contactToInsert)
        {
            repo.CreateContact(contactToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateContact(int id)
        {
            Contact cont = repo.GetContact(id);

            repo.UpdateContact(cont);
            if (cont == null)
            {
                return View("ContactNotFound");

            }
            return View(cont);
        }
        public IActionResult UpdateContactToDatabase(Contact contact)
        {
            repo.UpdateContact(contact);
            return RedirectToAction("ViewContact", new { id = contact.ID });
        }
        public IActionResult DeleteContact(Contact contact)
        {
            repo.DeleteContact(contact);
            return RedirectToAction("Index");
        }
    }
}
