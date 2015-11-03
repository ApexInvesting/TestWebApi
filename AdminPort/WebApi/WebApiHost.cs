using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPort {

    class WebApiHost : IDisposable {

        readonly IDisposable app;

        public WebApiHost() {

            app = WebApp.Start(new StartOptions("http://localhost:5050"));
        }

        public void Dispose() {

            app.Dispose();
        }
    }
}
