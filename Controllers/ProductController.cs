using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS3A.Sales.Context;
using AMS3A.Sales.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AMS3A.Sales.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController: ControllerBase
    {
    private readonly ApplicationDataContext _context;  
    public ProductController(ApplicationDataContext context)
    {
       _context = context;
    }
    [HttpGet]

    public ActionResult<IEnumerable<Product>> GetProduct()
    {
        return _context.Product.ToList();
    }
     
       [HttpPost]
        public ActionResult PostProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
           
            return Ok();
        }
        [HttpGet]
        [Route("{id.Guid}")]
        public ActionResult<Product> GetByProduct(Guid id)
        {
           var product = _context.Product.FirstOrDefault( p => p.Id == id);
           if (product == null) return NotFound();
           return Ok(product);
        }
    
    }
}