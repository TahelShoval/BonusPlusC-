using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Convert
{
    public class EmployersConvert
    {
        public static List<EmployersDTO> ConvertDalEntityToDto(List<Employers> employers)
        {
            if (employers == null)
                return null;
            List<EmployersDTO> listEmployers = employers.Select(e => ConvertDalEntityToDto(e)).ToList();
            return listEmployers;
        }

        public static EmployersDTO ConvertDalEntityToDto(Employers e)
        {
            if (e is null)
                return null;
            EmployersDTO employer = new EmployersDTO()
            {
                EmployerID = e.EmployerID,
                CompanyName = e.CompanyName,
                NameEmployer = e.NameEmployer,
                AddressID = e.AddressID,
                Phone = e.Phone,
                Email = e.Email,
                EmployerUserName = e.EmployerUserName,
                EmployerPassword = e.EmployerPassword
            };
            return employer;
        }

        public static Employers ConvertDalDtoToEntity(EmployersDTO e)
        {
            try
            {
                Employers employer = new Employers()
                {
                    EmployerID = e.EmployerID,
                    CompanyName = e.CompanyName,
                    NameEmployer = e.NameEmployer,
                    AddressID = e.AddressID,
                    Phone = e.Phone,
                    Email = e.Email,
                    EmployerUserName = e.EmployerUserName,
                    EmployerPassword = e.EmployerPassword
                };
                return employer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
