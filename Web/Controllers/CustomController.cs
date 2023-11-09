using Bussiness;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CustomController : Controller
    {
        // GET: CustomController
        public ActionResult Index()
        {
            
            List<Client>customers = new List<Client>();

            BClient bCustomer = new BClient();

            List<CustomerModel> models = new List<CustomerModel>();

            customers = bCustomer.GetAll();

            models = customers.Select(x=> new CustomerModel
            {   Id = x.Id,
                Name = x.Name,
                Phone = x.Phone

            }).ToList();
            return View(models);
        }

        // GET: CustomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomController/Create
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

        // GET: CustomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomController/Edit/5
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

        // GET: CustomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomController/Delete/5
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
