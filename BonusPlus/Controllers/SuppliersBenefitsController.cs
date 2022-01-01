using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BonusPlus.Controllers
{
    [RoutePrefix("api/SuppliersBenefits")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class SuppliersBenefitsController : ApiController
    {
        // GET: api/SuppliersBenefits
        [HttpGet]
        [Route("GetAllSuppliersBenefits")]
        public List<DTO.SuppliersBenefitsDTO> GetAllSuppliersBenefits()
        {
            return BL.SuppliersBenefitsBL.GetAllSuppliersBenefits();
        }

        // GET: api/SuppliersBenefits
        [HttpGet]
        [Route("GetAllDetailsSuppliersBenefits")]
        public List<DAL.SupplierBenefits> GetAllDetailsSuppliersBenefits()
        {
            return BL.SuppliersBenefitsBL.GetAllDetailsSuppliersBenefits();
        }

        // GET: api/SuppliersBenefits/5
        [HttpGet]
        [Route("GetSuppliersBenefitById/{id}")]
        public DTO.SuppliersBenefitsDTO GetSuppliersBenefitById(int id)
        {
            return BL.SuppliersBenefitsBL.GetSuppliersBenefitById(id);
        }

        // POST: api/SuppliersBenefits
        [HttpPost]
        [Route("PostSuppliersBenefit")]
        public void Post(DTO.SuppliersBenefitsDTO suppliersBenefitsDTO)
        {
            BL.SuppliersBenefitsBL.PostSuppliersBenefit(suppliersBenefitsDTO);
        }

        // PUT: api/SuppliersBenefits/5
        [HttpPut]
        [Route("PutSuppliersBenefit")]
        public void Put(DTO.SuppliersBenefitsDTO suppliersBenefitsDTO)
        {
            BL.SuppliersBenefitsBL.PutSuppliersBenefit(suppliersBenefitsDTO);
        }

        // DELETE: api/SuppliersBenefits/5
        [HttpDelete]
        [Route("DeleteSuppliersBenefit/{id}")]
        public void Delete(int id)
        {
            BL.SuppliersBenefitsBL.DeleteSuppliersBenefit(id);
        }
    }
}
