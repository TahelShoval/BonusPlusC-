using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BenefitsBL
    {
        public static List<DTO.BenefitsDTO> GetAllBenefits()
        {
            List<DAL.Benefits> listBenefits = DAL.BenefitsDAL.GetAllBenefits();
            return DTO.Convert.BenefitsConvert.ConvertDalEntityToDto(listBenefits);
        }

        public static DTO.BenefitsDTO GetBenefitById(int id)
        {
            DAL.Benefits benefits = DAL.BenefitsDAL.GetBenefitById(id);
            return DTO.Convert.BenefitsConvert.ConvertDalEntityToDto(benefits);
        }

        public static void PostBenefit(DTO.BenefitsDTO benefitsDTO)
        {
            DAL.Benefits benefits = DTO.Convert.BenefitsConvert.ConvertDalDtoToEntity(benefitsDTO);
            DAL.BenefitsDAL.PostBenefit(benefits);
        }

        public static void PutBenefit(DTO.BenefitsDTO benefitsDTO)
        {
            DAL.Benefits benefits = DTO.Convert.BenefitsConvert.ConvertDalDtoToEntity(benefitsDTO);
            DAL.BenefitsDAL.PutBenefit(benefits);
        }

        public static void DeleteBenefit(int id)
        {
            DAL.BenefitsDAL.DeleteBenefit(id);
        }
    }
}
