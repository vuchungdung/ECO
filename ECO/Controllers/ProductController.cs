using ECO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECO.Controllers
{
    public class ProductController : Controller
    {
        ECODBContext _db = new ECODBContext();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetMultiProduct()
        {
            try
            {
                var response = _db.Products.Where(x => x.Status == true).ToList().Skip(0).Take(20).OrderBy(x => x.Name);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetMultiProductByCategory()
        {
            int categoryid = Convert.ToInt32(TempData["keyword"]);
            try
            {
                var response = _db.Products.Where(x => x.Status == true && x.CategoryID == categoryid).OrderBy(x => x.Name).ToList();
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult ProductByCategory(int id)
        {
            TempData["keyword"] = id;
            return View();
        }
    }
}