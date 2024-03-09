using System;
using System.Diagnostics;
using System.IO;
using System.Web;

namespace Dropzone.Models
{
    public static class Utilities
    {
        public static string SaveFile(HttpPostedFileBase file, string virtualPath, string physicalPath, string filePath)
        {
            try
            {
                //Check directory exis or not
                if (!Directory.Exists(physicalPath))
                {
                    Directory.CreateDirectory(physicalPath);
                }

                //Check file is exist or not
                if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
                {
                    //Delete Existing file
                    File.Delete(filePath);
                }

                //Save new image and update user data
                var filename = string.Concat(Guid.NewGuid(), Path.GetExtension(file.FileName));
                var savePath = Path.Combine(physicalPath, filename);
                file.SaveAs(savePath);

                return filename;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return string.Empty;
            }
        }
    }
}