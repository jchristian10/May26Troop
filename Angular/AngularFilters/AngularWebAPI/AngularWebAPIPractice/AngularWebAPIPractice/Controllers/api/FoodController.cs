using AngularWebAPIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWebAPIPractice.Controllers.api
{
    public class FoodController : ApiController
    {
     
        [Route("api/food/{search}")]// tells you anything after food/ will be put into search property
        public IList<Food> Get(string search)
        {
            var all = new List<Food>
            {
                new Food {Id = 1, Name = "Milk"},

                new Food {Id = 2, Name = "Marzipan"},

                new Food {Id = 3, Name = "Mustard"},

                new Food {Id = 4, Name = "Eggs"},
            };

            return all.Where(f => f.Name.StartsWith(search, StringComparison.InvariantCultureIgnoreCase)).ToList(); 
        }

        public IHttpActionResult Post(Food food)
        {
            if(ModelState.IsValid)
            {
                //save the food to the database

                //return the new id instead (since we have no db)

                return Ok(new { Name = food.Name, Id = 5 });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
