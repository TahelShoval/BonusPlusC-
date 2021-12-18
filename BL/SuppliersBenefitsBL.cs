using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class SuppliersBenefitsBL
    {
        public static List<DTO.SuppliersBenefitsDTO> GetAllSuppliersBenefits()
        {
            List<DAL.SuppliersBenefits> listSuppliersBenefits = DAL.SuppliersBenefitsDAL.GetAllSuppliersBenefits();
            return DTO.Convert.SuppliersBenefitsConvert.ConvertDalEntityToDto(listSuppliersBenefits);
        }

        public static DTO.SuppliersBenefitsDTO GetSuppliersBenefitById(int id)
        {
            DAL.SuppliersBenefits suppliersBenefits = DAL.SuppliersBenefitsDAL.GetSuppliersBenefitById(id);
            return DTO.Convert.SuppliersBenefitsConvert.ConvertDalEntityToDto(suppliersBenefits);
        }

        public static void PostSuppliersBenefit(DTO.SuppliersBenefitsDTO suppliersBenefitsDTO)
        {
            DAL.SuppliersBenefits suppliersBenefits = DTO.Convert.SuppliersBenefitsConvert.ConvertDalDtoToEntity(suppliersBenefitsDTO);
            DAL.SuppliersBenefitsDAL.PostSuppliersBenefit(suppliersBenefits);
        }

        public static void PutSuppliersBenefit(DTO.SuppliersBenefitsDTO suppliersBenefitsDTO)
        {
            DAL.SuppliersBenefits suppliersBenefits = DTO.Convert.SuppliersBenefitsConvert.ConvertDalDtoToEntity(suppliersBenefitsDTO);
            DAL.SuppliersBenefitsDAL.PutSuppliersBenefit(suppliersBenefits);
        }

        public static void DeleteSuppliersBenefit(int id)
        {
            DAL.SuppliersBenefitsDAL.DeleteSuppliersBenefit(id);
        }
    }
}
