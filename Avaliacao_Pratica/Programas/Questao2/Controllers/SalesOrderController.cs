using System.Web.Mvc;
using Questao2.Business;
using Questao2.Business.Impl;

namespace Questao2.Controllers
{
    public class SalesOrderController : Controller
    {
        //
        // GET: /SalesOrder/

        public ActionResult Index()
        {
            var list = BusinessFactory.GetInstance().CreateBusiness<SalesOrderBusiness>();
            return View(list);
        }

        //
        // GET: /SalesOrder/Create

        public ActionResult Create()
        {
            // TODO: Implementação.
            return View();
        } 

        //
        // POST: /SalesOrder/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            // TODO: Implementação.
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /SalesOrder/Edit/5
 
        public ActionResult Edit(int id)
        {
            // TODO: Implementação.
            return View();
        }

        //
        // POST: /SalesOrder/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            // TODO: Implementação.
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //
        // POST: /SalesOrder/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // TODO: Implementação.
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
