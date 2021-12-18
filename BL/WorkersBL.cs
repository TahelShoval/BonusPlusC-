using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkersBL
    {
        public static List<DTO.WorkersDTO> GetAllWorkers()
        {
            List<DAL.Workers> listWorkers = DAL.WorkersDAL.GetAllWorkers();
            return DTO.Convert.WorkersConvert.ConvertDalEntityToDto(listWorkers);
        }

        public static DTO.WorkersDTO GetWorkerById(int id)
        {
            DAL.Workers worker = DAL.WorkersDAL.GetWorkerById(id);
            return DTO.Convert.WorkersConvert.ConvertDalEntityToDto(worker);
        }

        public static List<DTO.WorkersDTO> GetWorkersByEmployerId(int employerId)
        {
            List<DAL.Workers> listWorkers = DAL.WorkersDAL.GetWorkersByEmployerId(employerId);
            return DTO.Convert.WorkersConvert.ConvertDalEntityToDto(listWorkers);
        }

        public static DTO.WorkersDTO GetWorkerByUserName(string userName)
        {
            DAL.Workers worker = DAL.WorkersDAL.GetWorkerByUserName(userName);
            return DTO.Convert.WorkersConvert.ConvertDalEntityToDto(worker);
        }

        public static DTO.WorkersDTO GetWorkerByEmail(string email)
        {
            string newEmail = email.Replace("{}", ".");
            newEmail = newEmail.Replace("[]", "@");
            DAL.Workers worker = DAL.WorkersDAL.GetWorkerByEmail(newEmail);
            return DTO.Convert.WorkersConvert.ConvertDalEntityToDto(worker);
        }

        public static void PostWorker(DTO.WorkersDTO workerDTO)
        {
            DAL.Workers worker = DTO.Convert.WorkersConvert.ConvertDalDtoToEntity(workerDTO);
            DAL.WorkersDAL.PostWorker(worker);
        }

        public static void PutWorker(DTO.WorkersDTO workerDTO)
        {
            DAL.Workers worker = DTO.Convert.WorkersConvert.ConvertDalDtoToEntity(workerDTO);
            DAL.WorkersDAL.PutWorker(worker);
        }

        public static void DeleteWorker(int id)
        {
            DAL.WorkersDAL.DeleteWorker(id);
        }
    }
}
