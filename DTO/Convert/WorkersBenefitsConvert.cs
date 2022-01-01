using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO.Convert
{
    public class WorkersBenefitsConvert
    {
        public static List<WorkersBenefitsDTO> ConvertDalEntityToDto(List<WorkersBenefits> WorkersBenefits)
        {
            if (WorkersBenefits == null)
                return null;
            List<WorkersBenefitsDTO> listWorkersBenefits = WorkersBenefits.Select(s => ConvertDalEntityToDto(s)).ToList();
            return listWorkersBenefits;
        }

        public static WorkersBenefitsDTO ConvertDalEntityToDto(WorkersBenefits w)
        {
            if (w is null)
                return null;
            WorkersBenefitsDTO WorkersBenefits = new WorkersBenefitsDTO()
            {
                ID = w.ID,
                SupplierBenefitID = w.SupplierBenefitID,
                WorkerID = w.WorkerID,
                BenefitStatus = w.BenefitStatus,
                Coupon = w.Coupon
            };
            return WorkersBenefits;
        }

        public static WorkersBenefits ConvertDalDtoToEntity(WorkersBenefitsDTO w)
        {
            try
            {
                WorkersBenefits WorkersBenefits = new WorkersBenefits()
                {
                    ID = w.ID,
                    SupplierBenefitID = w.SupplierBenefitID,
                    WorkerID = w.WorkerID,
                    BenefitStatus = w.BenefitStatus,
                    Coupon = w.Coupon
                };
                return WorkersBenefits;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
