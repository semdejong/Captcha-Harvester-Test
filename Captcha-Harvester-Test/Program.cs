using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captcha_Harvester_Test.HttpServer;

namespace Captcha_Harvester_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Http server starter by Sem v1.1.0");
            Console.WriteLine("Press any key to start running the server");

            Console.ReadLine();


            createHttpServer httpServer = new createHttpServer();

            httpServer.fireUpHTTPServer();


        }
    }
}
