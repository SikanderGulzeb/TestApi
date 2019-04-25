using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product.Domain.Models;

namespace Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;

            if (_context.ProductItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.ProductItems.Add(new ProductItem { Name = "Decoder" });
                _context.SaveChanges();
            }
        }


        public async Task<ActionResult<IEnumerable<ProductItem>>> GetProductItems()
        {
            return await _context.ProductItems.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductItem>> GetProductItem(long id)
        {
            var productItem = await _context.ProductItems.FindAsync(id);

            if (productItem == null)
            {
                return NotFound();
            }

            return productItem;
        }


        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<ProductItem>> PostTodoItem(ProductItem item)
        {
            _context.ProductItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductItem), new { id = item.Id }, item);
        }





        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
