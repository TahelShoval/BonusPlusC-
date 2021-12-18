using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddressDAL
    {
        public static List<Address> GetAllAddress()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Address.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Address GetAddressById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Address.Where(w => w.AddressID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Address GetAddressByZipCode(string zipCode)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Address.FirstOrDefault(w => w.ZipCode == zipCode); 
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostAddress(Address address)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Address.Add(address);
                ManangementEntitiesSingleton.Instance.SaveChanges();          
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutAddress(Address address)
        {
            try
            {
                Address entity = GetAddressById(address.AddressID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(address);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteAddress(int id)
        {
            try
            {
                DAL.Address itemToRemove = ManangementEntitiesSingleton.Instance.Address.Where(x => x.AddressID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.Address.Remove(itemToRemove);
                    ManangementEntitiesSingleton.Instance.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
