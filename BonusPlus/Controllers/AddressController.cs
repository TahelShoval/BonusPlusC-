using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BonusPlus.Controllers
{
    [RoutePrefix("api/Address")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class AddressController : ApiController
    {
        // GET: api/Address
        [HttpGet]
        [Route("GetAllAddress")]
        public List<DTO.AddressDTO> GetAllAddress()
        {
            return BL.AddressBL.GetAllAddress();
        }

        // GET: api/Address/5
        [HttpGet]
        [Route("GetAddressById/{id}")]
        public DTO.AddressDTO GetAddressById(int id)
        {
            return BL.AddressBL.GetAddressById(id);
        }

        // GET: api/Address/5
        [HttpGet]
        [Route("GetAddressByZipCode/{zipCode}")]
        public DTO.AddressDTO GetAddressByZipCode(string zipCode)
        {
            return BL.AddressBL.GetAddressByZipCode(zipCode);
        }

        // POST: api/Address
        [HttpPost]
        [Route("PostAddress")]
        public void Post(DTO.AddressDTO addressDTO)
        {
            if(GetAddressByZipCode(addressDTO.ZipCode)  == null)
            BL.AddressBL.PostAddress(addressDTO);
        }

        // PUT: api/Address/5
        [HttpPut]
        [Route("PutAddress")]
        public void Put(DTO.AddressDTO addressDTO)
        {
            BL.AddressBL.PutAddress(addressDTO);
        }

        // DELETE: api/Address/5
        [HttpDelete]
        [Route("DeleteAddress/{id}")]
        public void Delete(int id)
        {
            BL.AddressBL.DeleteAddress(id);
        }
    }
}
