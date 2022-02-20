using Microsoft.AspNetCore.Mvc;
using API_ProductTask.Model;
using API_ProductTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_ProductTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly IRepository<Category> _rep;

        public CategoryController(IRepository<Category> rep)
        {

            _rep = rep;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public ActionResult <IEnumerable<Category>>Get()
        {
            var Items = _rep.GetAll();
            return Ok(Items);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var Item = _rep.GetById(id);
            if (Item != null)
                return Ok(Item);
            else
                return NotFound();
        }

        // POST api/<CategoryController>
        [HttpPost]
        
        public void Post([FromBody] Category model)
        {
            _rep.Add(model);
            _rep.SaveChanges();
        }

        // PUT api/<CategoryController>/5
        [HttpPost]
        public ActionResult Update(int Id, Category cat)
        {
            if (cat != null)
            {

                _rep.Edit(Id, cat);
                _rep.SaveChanges();
                return Ok(cat);
            }
            else
                return BadRequest();


        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
