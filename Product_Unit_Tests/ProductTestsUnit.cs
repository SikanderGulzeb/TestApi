using Product.Controllers;
using Product.Domain.Models;
using System;
using Xunit;

namespace ProductUnitTests
{
    public class ProductTestsUnit
    {

        ProductController _controller;
        ProductContext _service;


        public ProductTestsUnit()
        {
          // _service = new ProductContext();
            _controller = new ProductController(_service);
        }


        [Fact]
        public void Verify_that_GetAll_returns_all_Products ()
        {
            // Arrange 


            // act
            // Assert

        }

        [Fact]
        public void Verify_that_Get_returns_single_Product()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify_that_Post_is_Adding_Product()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify_that_Remove_is_removing__Products()
        {

            // Arrange 
            // act
            // Assert

        }

        [Fact]
        public void Verify_that_Remove_is__removing_Product()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify__that__Remove_is_removing_Product()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify_that_Remove_is_removing_Products()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify_that_update_is_updating_Products()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify_that_update_is_updating_correct_Products()
        {

            // Arrange 
            // act
            // Assert

        }
        [Fact]
        public void Verify_that_response_is_updating_correct()
        {

            // Arrange 
            // act
            // Assert

        }
    }
}
