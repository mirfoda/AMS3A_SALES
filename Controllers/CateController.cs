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
    public class CateController:ControllerBase
    {
        private readonly ApplicationDataContext _context;
        public CateController(ApplicationDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategory()
        {
            return _context.Category.ToList();
        }
        [HttpGet]
        [Route("{id.Guid}")]
        public ActionResult<Category> GetByCategory(Guid id)
        {
           var category = _context.Category.FirstOrDefault( ca => ca.Id == id);
           if (category == null) return NotFound();
           return Ok(category);
        }
        [HttpPost]
        public ActionResult Post(CategoryRequest categoryRequest)
        {

        
            var category = new Category (){
                Description = categoryRequest.Description,
                IsActive = true,
                ImageUrl = categoryRequest.ImageUrl,


            };

            _context.Category.Add(category);
            _context.SaveChanges();
            return Ok();
        }

    }
}