using DevExpress.Web;
using SampleMVC4App.Models;
using SampleMVC4App.Models.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC4App.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            //var products = db.Products.ToList();

            //if (!products.Any())
            //{
            //    // Log or debug here to check if the data is actually being retrieved
            //    ViewBag.Message = "No products found.";
            //}

            //return View(products);
            return View();
        }

        public ActionResult GridViewPartial()
        {
            return PartialView("GridViewPartial");
        }

        //[HttpPost, ValidateInput(false)]
        //public ActionResult EditModesUpdatePartial(EditableProduct product, GridViewEditingMode editMode)
        //{
        //    if (ModelState.IsValid)
        //        SafeExecute(() => ApplicationDataProvider.UpdateProduct(product));
        //    else
        //        ViewData["EditError"] = "Please, correct all errors.";
        //    return EditModesPartial(editMode);
        //}
    }
}