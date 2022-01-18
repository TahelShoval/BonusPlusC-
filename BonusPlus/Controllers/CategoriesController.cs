using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace BonusPlus.Controllers
{

    [RoutePrefix("api/Categories")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CategoriesController : ApiController
    {
        // GET: api/Categories
        [HttpGet]
        [Route("GetAllCategories")]
        public List<DTO.CategoriesDTO> GetAllCategories()
        {
            return BL.CategoriesBL.GetAllCategories();
        }

        // GET: api/Categories/5
        [HttpGet]
        [Route("GetCategoryById/{id}")]
        public DTO.CategoriesDTO GetCategoryById(int id)
        {
            return BL.CategoriesBL.GetCategoryById(id);
        }

        // POST: api/Categories
        [HttpPost]
        [Route("PostCategory")]
        public void Post(DTO.CategoriesDTO categoryDTO)
        {
            BL.CategoriesBL.PostCategory(categoryDTO);
        }

        // PUT: api/Categories/5
        [HttpPut]
        [Route("PutCategory")]
        public void Put(DTO.CategoriesDTO categoryDTO)
        {
            BL.CategoriesBL.PutCategory(categoryDTO);
        }

        // DELETE: api/Categories/5
        [HttpDelete]
        [Route("DeleteCategory/{id}")]
        public void Delete(int id)
        {
            BL.CategoriesBL.DeleteCategory(id);
        }
    }
}
