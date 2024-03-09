using System.Collections.Generic;
using System.Web;

namespace Dropzone.Models
{
    public class UploadModel
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public List<HttpPostedFileBase> Images { get; set; }

        public UploadModel()
        {
            Images = new List<HttpPostedFileBase>();
        }
    }
}