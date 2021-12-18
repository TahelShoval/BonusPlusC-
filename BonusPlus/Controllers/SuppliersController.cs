using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BonusPlus.Controllers
{
    [RoutePrefix("api/Suppliers")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class SuppliersController : ApiController
    {
        // GET: api/Suppliers
        [HttpGet]
        [Route("GetAllSuppliers")]
        public List<DTO.SuppliersDTO> GetAllSuppliers()
        {
            return BL.SuppliersBL.GetAllSuppliers();
        }

        // GET: api/Suppliers/5
        [HttpGet]
        [Route("GetSupplierById/{id}")]
        public DTO.SuppliersDTO GetSupplierById(int id)
        {
            return BL.SuppliersBL.GetSupplierById(id);
        }

        // POST: api/Suppliers
        [HttpPost]
        [Route("PostSupplier")]
        public void Post(DTO.SuppliersDTO suppliersDTO)
        {
            BL.SuppliersBL.PostSupplier(suppliersDTO);
        }

        // PUT: api/Suppliers/5
        [HttpPut]
        [Route("PutSupplier")]
        public void Put(DTO.SuppliersDTO suppliersDTO)
        {
            BL.SuppliersBL.PutSupplier(suppliersDTO);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete]
        [Route("DeleteSupplier/{id}")]
        public void Delete(int id)
        {
            BL.SuppliersBL.DeleteSupplier(id);
        }
    }
}
