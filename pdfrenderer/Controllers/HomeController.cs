using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace pdfrenderer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          

            return View();
        }

        public ActionResult Pdf()
        {
            var model = new  {DocTitle = "title", DocContent = "This is a test"};
            return new ViewAsPdf("About",model);
        }

        public ActionResult Viewer(string url)
        {

            ViewBag.PdfRawUrl = url;
            return View();

        }

        
        public ActionResult Embed(string url)
        {

            return new ViewAsPdf("Embed",url);
        }
        

        public ActionResult Renderer(string url)
        {
            ViewBag.PdfRawUrl = url;

            return PartialView();
        }

        public ActionResult About()
        {
            
            return View();
        }
    }
}
