using System;
using System.Net;
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
        public void Veify_The_Post_method()
        {

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
