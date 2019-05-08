using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Product;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Product_IntegrationTests
{
   public class TestClientProvider
    {

        public HttpClient Client { get; private set; }

        public TestClientProvider ()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
        }

    }
}



