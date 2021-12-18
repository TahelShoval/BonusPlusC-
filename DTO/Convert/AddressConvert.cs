using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Convert
{
    public class AddressConvert
    {
        public static List<AddressDTO> ConvertDalEntityToDto(List<Address> address)
        {
            if (address == null)
                return null;
            List<AddressDTO> listAddress = address.Select(a => ConvertDalEntityToDto(a)).ToList();
            return listAddress;
        }

        public static AddressDTO ConvertDalEntityToDto(Address a)
        {
            if (a is null)
                return null;
            AddressDTO address = new AddressDTO()
            {
                AddressID = a.AddressID,
                City = a.City,
                Street = a.Street,
                ZipCode = a.ZipCode
            };
            return address;
        }

        public static Address ConvertDalDtoToEntity(AddressDTO a)
        {
            try
            {
                Address address = new Address()
                {
                    AddressID = a.AddressID,
                    City = a.City,
                    Street = a.Street,
                    ZipCode = a.ZipCode
                };
                return address;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
