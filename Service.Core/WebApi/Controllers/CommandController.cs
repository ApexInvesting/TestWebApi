using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Service.Core.WebApi.Controllers {

    [RoutePrefix("command")]
    public class CommandController : ApiController {

        [HttpGet]
        [Route("start")]
        public HttpResponseMessage Start() {

            return new HttpResponseMessage {
                Content = new StringContent("Started"),
            };
        }

        [HttpGet]
        [Route("stop")]
        public HttpResponseMessage Stop() {

            return new HttpResponseMessage {
                Content = new StringContent("Stopped"),
            };
        }
    }
}
