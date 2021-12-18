using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO.Convert
{
    public class WorkersConvert
    {
        public static List<WorkersDTO> ConvertDalEntityToDto(List<Workers> workers)
        {
            if (workers == null)
                return null;
            List<WorkersDTO> listWorkers = workers.Select(w => ConvertDalEntityToDto(w)).ToList();
            return listWorkers;
        }

        public static WorkersDTO ConvertDalEntityToDto(Workers w)
        {
            if (w is null)
                return null;
            WorkersDTO worker = new WorkersDTO()
            {
                ID = w.ID,
                WorkerID = w.WorkerID,
                EmployerID = w.EmployerID,
                WorkerName = w.WorkerName,
                JobType = w.JobType,
                Seniority = w.Seniority,
                Email = w.Email,
                WorkerUserName = w.WorkerUserName,
                WorkerPassword = w.WorkerPassword
            };
            return worker;
        }

        public static Workers ConvertDalDtoToEntity(WorkersDTO w)
        {
            try
            {
                Workers worker = new Workers()
                {
                    ID = w.ID,
                    WorkerID = w.WorkerID,
                    EmployerID = w.EmployerID,
                    WorkerName = w.WorkerName,
                    JobType = w.JobType,
                    Seniority = w.Seniority,
                    Email = w.Email,
                    WorkerUserName = w.WorkerUserName,
                    WorkerPassword = w.WorkerPassword
                };
                return worker;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
