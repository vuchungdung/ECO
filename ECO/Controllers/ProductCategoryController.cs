using ECO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECO.Controllers
{
    public class ProductCategoryController : Controller
    {
        ECODBContext _db = new ECODBContext();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllCategory()
        {
            try
            {
                var response = _db.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}