using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
namespace BonusPlus.Controllers
{
    [RoutePrefix("api/Employers")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EmployersController : ApiController
    {
        // GET: api/Employers
        [HttpGet]
        [Route("GetAllEmployers")]
        public List<DTO.EmployersDTO> GetAllEmployers()
        {
            return EmployersBL.GetAllEmployers();
        }

        //GET: api/Employers/5
        [HttpGet]
        [Route("GetEmployerById/{id}")]
        public DTO.EmployersDTO GetEmployerById(int id)
        {
            return BL.EmployersBL.GetEmployerById(id);
        }

        //GET: api/Employers/5
        [HttpGet]
        [Route("GetEmployerByUserName/{userName}")]
        public DTO.EmployersDTO GetEmployerByUserName(string userName)
        
        {
            return BL.EmployersBL.GetEmployerByUserName(userName);
        }

        //POST: api/Employers
        [HttpPost]
       [Route("PostEmployer")]
        public void Post(DTO.EmployersDTO employersDTO)
        {
            BL.EmployersBL.PostEmployer(employersDTO);
        }

        //PUT: api/Employers/5
        [HttpPut]
        [Route("PutEmployer")]
        public void Put(DTO.EmployersDTO employersDTO)
        {
            BL.EmployersBL.PutEmployer(employersDTO);
        }

        //DELETE: api/Employers/5
        [HttpDelete]
        [Route("DeleteEmployer/{id}")]
        public void Delete(int id)
        {
            BL.EmployersBL.DeleteEmployer(id);
        }
    }
}
