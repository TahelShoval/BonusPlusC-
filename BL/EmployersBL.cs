using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EmployersBL
    {
        public static List<DTO.EmployersDTO> GetAllEmployers()
        {
            List<DAL.Employers> listEmployers = DAL.EmployersDAL.GetAllEmployers();
            return DTO.Convert.EmployersConvert.ConvertDalEntityToDto(listEmployers);
        }

        public static DTO.EmployersDTO GetEmployerById(int id)
        {
            DAL.Employers employers = DAL.EmployersDAL.GetEmployerById(id);
            return DTO.Convert.EmployersConvert.ConvertDalEntityToDto(employers);
        }

        public static DTO.EmployersDTO GetEmployerByUserName(string userName)
        {
            DAL.Employers employer = DAL.EmployersDAL.GetEmployerByUserName(userName);
            return DTO.Convert.EmployersConvert.ConvertDalEntityToDto(employer);
        }

        public static void PostEmployer(DTO.EmployersDTO employersDTO)
        {
            DAL.Employers employers = DTO.Convert.EmployersConvert.ConvertDalDtoToEntity(employersDTO);
            DAL.EmployersDAL.PostEmployer(employers);
        }

        public static void PutEmployer(DTO.EmployersDTO employersDTO)
        {
            DAL.Employers employers = DTO.Convert.EmployersConvert.ConvertDalDtoToEntity(employersDTO);
            DAL.EmployersDAL.PutEmployer(employers);
        }

        public static void DeleteEmployer(int id)
        {
            DAL.EmployersDAL.DeleteEmployer(id);
        }
    }
}
