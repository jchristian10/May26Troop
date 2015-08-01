using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteEnable.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult GetDocument(string path)
        {
            //var doucment = DocumentRepository.GetDocumentFromDatabase(path);
            return Content("I hope this shit works");
        }
    }
}