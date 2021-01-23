using FileUploadDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FileUploadDemo.Controllers
{
    public class GalleryController : ApiController
    {
        private FileUploadDemoDbContext Context = new FileUploadDemoDbContext();

        [HttpPost]
        [Route("api/FileUpload")]
        public IHttpActionResult Upload()
        {
            int uploadCount = 0;

            string sPath = System.Web.Hosting.HostingEnvironment.MapPath("/Gallery/");
            System.Web.HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;

            for(int i = 0; i < files.Count; i++)
            {
                System.Web.HttpPostedFile file = files[i];
                string fileName = new FileInfo(file.FileName).Name;

                if(file.ContentLength > 0)
                {
                    Guid id = Guid.NewGuid();

                    string modifiedFileName = id.ToString() + "_" + fileName;

                    if(!File.Exists(sPath + Path.GetFileName(modifiedFileName)))
                    {
                        file.SaveAs(sPath + Path.GetFileName(modifiedFileName));
                        uploadCount++;

                        Context.Galleries.Add(new Gallery() { id = id, FileName = "/Gallery/" + modifiedFileName, Title = fileName });
                    }
                }
            }
            if(uploadCount > 0)
            {
                Context.SaveChanges();
                return Ok("Upload Successfully");
            }
            return InternalServerError();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
