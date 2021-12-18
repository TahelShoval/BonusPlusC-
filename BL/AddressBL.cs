using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AddressBL
    {
        public static List<DTO.AddressDTO> GetAllAddress()
        {
            List<DAL.Address> listAddress = DAL.AddressDAL.GetAllAddress();
            return DTO.Convert.AddressConvert.ConvertDalEntityToDto(listAddress);
        }

        public static DTO.AddressDTO GetAddressById(int id)
        {
            DAL.Address address = DAL.AddressDAL.GetAddressById(id);
            return DTO.Convert.AddressConvert.ConvertDalEntityToDto(address);
        }

        public static DTO.AddressDTO GetAddressByZipCode(string zipCode)
        {
            DAL.Address address = DAL.AddressDAL.GetAddressByZipCode(zipCode);
            return DTO.Convert.AddressConvert.ConvertDalEntityToDto(address);
        }

        public static void PostAddress(DTO.AddressDTO addressDTO)
        {
            DAL.Address address = DTO.Convert.AddressConvert.ConvertDalDtoToEntity(addressDTO);
            DAL.AddressDAL.PostAddress(address);
        }

        public static void PutAddress(DTO.AddressDTO addressDTO)
        {
            DAL.Address address = DTO.Convert.AddressConvert.ConvertDalDtoToEntity(addressDTO);
            DAL.AddressDAL.PutAddress(address);
        }

        public static void DeleteAddress(int id)
        {
            DAL.AddressDAL.DeleteAddress(id);
        }
    }
}
