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
        [HttpGet]
        public JsonResult GetMultiProductByCategory(int categoryid)
        {
            try
            {
                var response = _db.Products.Where(x => x.Status == true && x.CategoryID == categoryid).Skip(0).Take(20).OrderBy(x => x.Name).ToList();
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public ActionResult GetMultiProductByCategory()
        {
            return View();
        }
    }
}