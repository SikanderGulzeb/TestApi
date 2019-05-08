using Newtonsoft.Json;
using Product.Domain.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Product_IntegrationTests
{
    public class ProductIntegrationTests
    {


[Fact]
        public async Task Test_Get_All()
        {

            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/product");

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }

        //Get Method
        [Fact]
        public void Verify_the_Get_Method()
        {



        }

        //Post Method

        [Fact]
        public async Task Veify_The_Post_methodAsync()
        {

            using (var client = new TestClientProvider().Client)
            {
                var response = await client.PostAsync("/api/product"
                        , new StringContent(
                        JsonConvert.SerializeObject(new ProductItem { Name = "Decoder", Manufacturer = "Arvato", Price = "100" }),
                    Encoding.UTF8,
                    "application/json"));

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            }


        }


        //Update

        [Fact]
        public void Verify_the_update_method()
        {

        }

        //Delete
        [Fact]
        public void Verify_the_Delete_Method()
        {

        }
    }
}
