using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Convert
{
    public class SuppliersConvert
    {
        public static List<SuppliersDTO> ConvertDalEntityToDto(List<Suppliers> suppliers)
        {
            if (suppliers == null)
                return null;
            List<SuppliersDTO> listSuppliers = suppliers.Select(s => ConvertDalEntityToDto(s)).ToList();
            return listSuppliers;
        }

        public static SuppliersDTO ConvertDalEntityToDto(Suppliers s)
        {
            if (s is null)
                return null;
            SuppliersDTO supplier = new SuppliersDTO()
            {
                SupplierID = s.SupplierID,
                SupplierName = s.SupplierName,
                logo = s.logo,
                categoryID = s.categoryID
            };
            return supplier;
        }

        public static Suppliers ConvertDalDtoToEntity(SuppliersDTO s)
        {
            try
            {
                Suppliers supplier = new Suppliers()
                {
                    SupplierID = s.SupplierID,
                    SupplierName = s.SupplierName,
                    logo = s.logo,
                    categoryID = s.categoryID
                };
                return supplier;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
