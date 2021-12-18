using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BonusPlus.Controllers
{
    [RoutePrefix("api/Benefits")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class BenefitsController : ApiController
    {
        // GET: api/Benefits
        [HttpGet]
        [Route("GetAllBenefits")]
        public List<DTO.BenefitsDTO> GetAllBenefits()
        {
           return BL.BenefitsBL.GetAllBenefits();
        }

        // GET: api/Benefits/5
        [HttpGet]
        [Route("GetBenefitById/{id}")]
        public DTO.BenefitsDTO GetBenefitById(int id)
        {
            return BL.BenefitsBL.GetBenefitById(id);
        }

        // POST: api/Benefits
        [HttpPost]
        [Route("PostBenefit")]
        public void Post(DTO.BenefitsDTO benefitsDTO)
        {
            BL.BenefitsBL.PostBenefit(benefitsDTO);
        }

        // PUT: api/Benefits/5
        [HttpPut]
        [Route("PutBenefit")]
        public void Put(DTO.BenefitsDTO benefitsDTO)
        {
            BL.BenefitsBL.PutBenefit(benefitsDTO);
        }

        // DELETE: api/Benefits/5
        [HttpDelete]
        [Route("DeleteBenefit/{id}")]
        public void Delete(int id)
        {
            BL.BenefitsBL.DeleteBenefit(id);
        }
    }
}
