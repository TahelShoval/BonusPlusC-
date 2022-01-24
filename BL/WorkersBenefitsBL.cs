using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class WorkersBenefitsBL
    {
        public static List<DTO.WorkersBenefitsDTO> GetAllWorkersBenefits()
        {
            List<DAL.WorkersBenefits> listWorkersBenefits = DAL.WorkersBenefitsDAL.GetAllWorkersBenefits();
            return DTO.Convert.WorkersBenefitsConvert.ConvertDalEntityToDto(listWorkersBenefits);
        }

        public static DTO.WorkersBenefitsDTO GetWorkersBenefitById(int id)
        {
            DAL.WorkersBenefits workersBenefits = DAL.WorkersBenefitsDAL.GetWorkersBenefitById(id);
            return DTO.Convert.WorkersBenefitsConvert.ConvertDalEntityToDto(workersBenefits);
        }

        public static List<WorkerBenefits> GetWorkersBenefitByWorkerId(int workerId)
        {
            return WorkersBenefitsDAL.GetWorkersBenefitByWorkerId(workerId);
        }

        public static void PostWorkersBenefit(DTO.WorkersBenefitsDTO WorkersBenefitsDTO)
        {
            DAL.WorkersBenefits workersBenefits = DTO.Convert.WorkersBenefitsConvert.ConvertDalDtoToEntity(WorkersBenefitsDTO);
            DAL.WorkersBenefitsDAL.PostWorkersBenefit(workersBenefits);
        }

        public static bool AddWorkersBenefits(List<DTO.WorkersBenefitsDTO> listWB)
        {
            List<WorkersBenefits> newList = new List<WorkersBenefits>();
            foreach (var item in listWB)
            {
                WorkersBenefits workersBenefits = DTO.Convert.WorkersBenefitsConvert.ConvertDalDtoToEntity(item);
                newList.Add(workersBenefits);
            }
            return DAL.WorkersBenefitsDAL.AddWorkersBenefits(newList);
        }

        public static void PutWorkersBenefit(DTO.WorkersBenefitsDTO WorkersBenefitsDTO)
        {
            DAL.WorkersBenefits workersBenefits = DTO.Convert.WorkersBenefitsConvert.ConvertDalDtoToEntity(WorkersBenefitsDTO);
            DAL.WorkersBenefitsDAL.PutWorkersBenefit(workersBenefits);
        }

        public static void DeleteWorkersBenefit(int id)
        {
            DAL.WorkersBenefitsDAL.DeleteWorkersBenefit(id);
        }
    }
}
