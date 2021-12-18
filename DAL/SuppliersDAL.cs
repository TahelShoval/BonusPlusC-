using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliersDAL
    {
        public static List<Suppliers> GetAllSuppliers()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Suppliers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Suppliers GetSupplierById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Suppliers.Where(w => w.SupplierID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostSupplier(Suppliers suppliers)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Suppliers.Add(suppliers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutSupplier(Suppliers suppliers)
        {
            try
            {
                Suppliers entity = GetSupplierById(suppliers.SupplierID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(suppliers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteSupplier(int id)
        {
            try
            {
                DAL.Suppliers itemToRemove = ManangementEntitiesSingleton.Instance.Suppliers.Where(x => x.SupplierID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.Suppliers.Remove(itemToRemove);
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
