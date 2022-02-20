using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ProductTask.Model;
using API_ProductTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        readonly IRepository<ProductViewModel> _rep;

        public ProductController(IRepository<ProductViewModel> rep)
        {

            _rep = rep;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> GetAllProduct()
        {
            var Items = _rep.GetAll();
            return Ok(Items);
        }

        [HttpGet("{Id}")]
        [Route("GetProductById")]
        public ActionResult<ProductViewModel> GetProductById(int Id)
        {
            var Item = _rep.GetById(Id);
            if (Item != null)
                return Ok(Item);
            else
                return NotFound();
        }

        [HttpGet("{Name}")]
        [Route("GetProductByName")]
        public ActionResult<ProductViewModel> GetProductByName(string Name)
    {
        var Item = _rep.FindByName(Name);
        if (Item != null)
            return Ok(Item);
        else
            return NotFound();
    }
        [HttpGet("{Date}")]
        [Route("GetProductByDate")]
        public ActionResult<ProductViewModel> GetProductByDate(string Date)
        {
            var Item = _rep.FindByDate(Date);
            if (Item != null)
                return Ok(Item);
            else
                return NotFound();
        }

        [HttpDelete]
        [Route("ArcheiveProduct")]
        public ActionResult Archeive(int id)
        {
            _rep.Delete(id);
            if (_rep.SaveChanges())
                return Ok();
            else
                return BadRequest("you are not allowed to archeive");
        }

        [HttpPut]
        public ActionResult Update(int Id, ProductViewModel product)
        {
            if (product != null)
            {

                _rep.Edit(Id, product);
                _rep.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();


        }
        [HttpPost]
        public void Post([FromBody] ProductViewModel model)
        {
            _rep.Add(model);
            _rep.SaveChanges();
        }
    }

  

}
