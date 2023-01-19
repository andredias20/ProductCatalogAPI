using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Database.Context;
using ProductCatalogAPI.Entities;

namespace ProductCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDepartmentsController : ControllerBase
    {
        private readonly Context _context;

        public ProductDepartmentsController(Context context)
        {
            _context = context;
        }

        // GET: api/ProductDepartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDepartment>>> GetProductDepartments()
        {
            return await _context.ProductDepartments.ToListAsync();
        }

        // GET: api/ProductDepartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDepartment>> GetProductDepartment(int id)
        {
            var productDepartment = await _context.ProductDepartments.FindAsync(id);

            if (productDepartment == null)
            {
                return NotFound();
            }

            return productDepartment;
        }

        // PUT: api/ProductDepartments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductDepartment(int id, ProductDepartment productDepartment)
        {
            if (id != productDepartment.Id)
            {
                return BadRequest();
            }

            _context.Entry(productDepartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductDepartmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductDepartments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductDepartment>> PostProductDepartment(ProductDepartment productDepartment)
        {
            _context.ProductDepartments.Add(productDepartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductDepartment", new { id = productDepartment.Id }, productDepartment);
        }

        // DELETE: api/ProductDepartments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDepartment(int id)
        {
            var productDepartment = await _context.ProductDepartments.FindAsync(id);
            if (productDepartment == null)
            {
                return NotFound();
            }

            _context.ProductDepartments.Remove(productDepartment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductDepartmentExists(int id)
        {
            return _context.ProductDepartments.Any(e => e.Id == id);
        }
    }
}
