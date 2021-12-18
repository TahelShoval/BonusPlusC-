using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SuppliersBL
    {
        public static List<DTO.SuppliersDTO> GetAllSuppliers()
        {
            List<DAL.Suppliers> listSuppliers = DAL.SuppliersDAL.GetAllSuppliers();
            return DTO.Convert.SuppliersConvert.ConvertDalEntityToDto(listSuppliers);
        }

        public static DTO.SuppliersDTO GetSupplierById(int id)
        {
            DAL.Suppliers suppliers = DAL.SuppliersDAL.GetSupplierById(id);
            return DTO.Convert.SuppliersConvert.ConvertDalEntityToDto(suppliers);
        }

        public static void PostSupplier(DTO.SuppliersDTO suppliersDTO)
        {
            DAL.Suppliers suppliers = DTO.Convert.SuppliersConvert.ConvertDalDtoToEntity(suppliersDTO);
            DAL.SuppliersDAL.PostSupplier(suppliers);
        }

        public static void PutSupplier(DTO.SuppliersDTO suppliersDTO)
        {
            DAL.Suppliers suppliers = DTO.Convert.SuppliersConvert.ConvertDalDtoToEntity(suppliersDTO);
            DAL.SuppliersDAL.PutSupplier(suppliers);
        }

        public static void DeleteSupplier(int id)
        {
            DAL.SuppliersDAL.DeleteSupplier(id);
        }
    }
}
