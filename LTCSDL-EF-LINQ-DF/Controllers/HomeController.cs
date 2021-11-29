using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LTCSDL.BLL;
using LTCSDL.DTO;

namespace LTCSDL_EF_LINQ_DF.Controllers
{
    public class HomeController : Controller
    {
        private CategoryBLL bus;
        public HomeController()
        {
            bus = new CategoryBLL();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Category()
        {
            ViewBag.Title = "Category - Danh mục sản phẩm";
            List<CategoryDTO> lst = bus.GetAll().ToList();
            return View(lst);
        }
    }
}
