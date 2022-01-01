using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Convert
{
    public class BenefitsConvert
    {
        public static List<BenefitsDTO> ConvertDalEntityToDto(List<Benefits> benefits)
        {
            if (benefits == null)
                return null;
            List<BenefitsDTO> listBenefits = benefits.Select(b => ConvertDalEntityToDto(b)).ToList();
            return listBenefits;
        }

        public static BenefitsDTO ConvertDalEntityToDto(Benefits b)
        {
            if (b is null)
                return null;
            BenefitsDTO benefit = new BenefitsDTO()
            {
                BenefitID = b.BenefitID,
                Details = b.Details,
                Image = b.Image,
                price = b.price
            };
            return benefit;
        }

        public static Benefits ConvertDalDtoToEntity(BenefitsDTO b)
        {
            try
            {
                Benefits benefit = new Benefits()
                {
                    BenefitID = b.BenefitID,
                    Details = b.Details,
                    Image = b.Image,
                    price = b.price
                };
                return benefit;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
