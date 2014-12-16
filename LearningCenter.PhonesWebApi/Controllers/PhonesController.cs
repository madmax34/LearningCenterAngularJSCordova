using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using LearningCenter.PhonesWebApi.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;

namespace LearningCenter.PhonesWebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PhonesController : ApiController
    {
        // GET api/values
        public object Get()
        {
            var path = string.Format("{0}://{1}", Request.RequestUri.Scheme, Request.RequestUri.Host);
            return Json(JsonConvert.SerializeObject(PhoneModel.GetAllPhones(path)));
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
