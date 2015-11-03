using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Service.ExampleVehicle.WebApiControllers {

    [RoutePrefix("command")]
    public class CustomCommandController : ApiController {

        [HttpGet]
        [Route("custom")]
        public HttpResponseMessage Custom() {

            return new HttpResponseMessage {
                Content = new StringContent("Custom"),
            };
        }
    }
}
