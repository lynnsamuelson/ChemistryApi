using PeriodicTableApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeriodicTableApi.Controllers
{
    public class ElementController : ApiController
    {
        ElementContext element = new ElementContext();
        public IEnumerable<Element> GetAllProducts()
        {
            var atoms = (from ele in element.Element
                         select new Element
                         {
                             AtomicName = ele.AtomicName
                         });
            return atoms;
        }

        //public IHttpActionResult GetProduct(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
    }
}
