using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Convert
{
    public class SuppliersBenefitsConvert
    {
        public static List<SuppliersBenefitsDTO> ConvertDalEntityToDto(List<SuppliersBenefits> suppliersBenefits)
        {
            if (suppliersBenefits == null)
                return null;
            List<SuppliersBenefitsDTO> listSuppliersBenefits = suppliersBenefits.Select(s => ConvertDalEntityToDto(s)).ToList();
            return listSuppliersBenefits;
        }

        public static SuppliersBenefitsDTO ConvertDalEntityToDto(SuppliersBenefits s)
        {
            if (s is null)
                return null;
            SuppliersBenefitsDTO suppliersBenefits = new SuppliersBenefitsDTO()
            {
                ID = s.ID,
                SupplierId = s.SupplierId,
                BenefitId = s.BenefitId,
                
            };
            return suppliersBenefits;
        }

        public static SuppliersBenefits ConvertDalDtoToEntity(SuppliersBenefitsDTO s)
        {
            try
            {
                SuppliersBenefits suppliersBenefits = new SuppliersBenefits()
                {
                    ID = s.ID,
                    SupplierId = s.SupplierId,
                    BenefitId = s.BenefitId,
                };
                return suppliersBenefits;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
