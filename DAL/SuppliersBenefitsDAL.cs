using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliersBenefitsDAL
    {
        public static List<SuppliersBenefits> GetAllSuppliersBenefits()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.SuppliersBenefits.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<SupplierBenefits> GetAllDetailsSuppliersBenefits()
        {
            try
            {
                List<SupplierBenefits> supplierBenefits = new List<SupplierBenefits>();
                List<SuppliersBenefits> suppliersBenefits = ManangementEntitiesSingleton.Instance.SuppliersBenefits.ToList();
                List<Benefits> benefits = BenefitsDAL.GetAllBenefits();
                List<Suppliers> suppliers = SuppliersDAL.GetAllSuppliers();
                foreach (var item in suppliersBenefits)
                {
                    SupplierBenefits s = new SupplierBenefits();
                    s.ID = item.ID;
                    foreach (var item2 in suppliers)
                        if (item2.SupplierID == item.SupplierId)
                        {
                            s.SupplierName = item2.SupplierName;
                            s.SupplierLogo = item2.logo;
                            s.categoryID = item2.categoryID;
                        }

                    foreach (var item2 in benefits)
                        if (item2.BenefitID == item.BenefitId)
                        {
                            s.BenefitDetails = item2.Details;
                            s.BenefitImage = item2.Image;
                            s.Price = item2.price;
                        }

                    supplierBenefits.Add(s);
                }
                return supplierBenefits;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static SuppliersBenefits GetSuppliersBenefitById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.SuppliersBenefits.Where(w => w.ID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostSuppliersBenefit(SuppliersBenefits suppliersBenefits)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.SuppliersBenefits.Add(suppliersBenefits);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutSuppliersBenefit(SuppliersBenefits suppliersBenefits)
        {
            try
            {
                SuppliersBenefits entity = GetSuppliersBenefitById(suppliersBenefits.ID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(suppliersBenefits);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteSuppliersBenefit(int id)
        {
            try
            {
                DAL.SuppliersBenefits itemToRemove = ManangementEntitiesSingleton.Instance.SuppliersBenefits.Where(x => x.ID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.SuppliersBenefits.Remove(itemToRemove);
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
