using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImageManipulation.Controllers
{
    public class ImageUploadController : ApiController
    {
        // GET: api/ImageUpload
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ImageUpload/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ImageUpload
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ImageUpload/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ImageUpload/5
        public void Delete(int id)
        {
        }

        [HttpPost]
        public int ImageUpload(byte[] byteImageArray)
        {



            return 0;
        }
    }
}
