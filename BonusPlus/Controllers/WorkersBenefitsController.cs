using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace BonusPlus.Controllers
{
    [RoutePrefix("api/WorkersBenefits")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WorkersBenefitsController : ApiController
    {
        // GET: api/WorkersBenefits
        [HttpGet]
        [Route("GetAllWorkersBenefits")]
        public List<DTO.WorkersBenefitsDTO> GetAllWorkersBenefits()
        {
            return BL.WorkersBenefitsBL.GetAllWorkersBenefits();
        }

        // GET: api/WorkersBenefits/5
        [HttpGet]
        [Route("GetWorkersBenefitById/{id}")]
        public DTO.WorkersBenefitsDTO GetWorkersBenefitById(int id)
        {
            return BL.WorkersBenefitsBL.GetWorkersBenefitById(id);
        }

        // GET: api/WorkersBenefits/5
        [HttpGet]
        [Route("GetWorkersBenefitByWorkerId/{workerId}")]
        public List<DAL.WorkerBenefits> GetWorkersBenefitByWorkerId(int workerId)
        {
            return BL.WorkersBenefitsBL.GetWorkersBenefitByWorkerId(workerId);
        }

        // POST: api/WorkersBenefits
        [HttpPost]
        [Route("PostWorkersBenefit")]
        public void Post(DTO.WorkersBenefitsDTO workersBenefitsDTO)
        {
            BL.WorkersBenefitsBL.PostWorkersBenefit(workersBenefitsDTO);
        }

        // POST: api/WorkersBenefits/arr
        [HttpPost]
        [Route("PostWorkersBenefits")]
        public bool PostWorkersBenefit(List<DTO.WorkersBenefitsDTO> listWB)
        {
            return BL.WorkersBenefitsBL.AddWorkersBenefits(listWB);
        }

        // PUT: api/WorkersBenefits/5
        [HttpPut]
        [Route("PutWorkersBenefit")]
        public void Put(DTO.WorkersBenefitsDTO workersBenefitsDTO)
        {
            BL.WorkersBenefitsBL.PutWorkersBenefit(workersBenefitsDTO);
        }

        // DELETE: api/WorkersBenefits/5
        [HttpDelete]
        [Route("DeleteWorkersBenefit/{id}")]
        public void Delete(int id)
        {
            BL.WorkersBenefitsBL.DeleteWorkersBenefit(id);
        }
    }
}
