using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPort {

    class Program {

        static WebApiHost webApiHost;

        static void Main(string[] args) {

            webApiHost = new WebApiHost();

            Console.WriteLine("Listening on http://localhost:5050/command/start");
            Console.WriteLine("Listening on http://localhost:5050/command/stop");
            Console.WriteLine();
            Console.WriteLine("Press any key to terminate");
            Console.ReadKey();

            Console.WriteLine("Terminating");
            webApiHost.Dispose();
        }
    }
}
