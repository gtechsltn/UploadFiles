using Dropzone.Models;
using System.Web.Mvc;

namespace Dropzone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(UploadModel model)
        {
            if (model != null && model.Images != null)
            {
                var virtualPath = StaticValues.ImagePath;
                var physicalPath = Server.MapPath(virtualPath);
                var filePath = model.Images[0].FileName;
                Utilities.SaveFile(model.Images[0], virtualPath, physicalPath, filePath);
            }
            var resp = new UploadResponse() { Success = true };
            return Json(resp, JsonRequestBehavior.AllowGet);
        }
    }
}