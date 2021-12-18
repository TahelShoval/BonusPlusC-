using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenefitsDAL
    {
        public static List<Benefits> GetAllBenefits()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Benefits.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Benefits GetBenefitById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Benefits.Where(w => w.BenefitID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostBenefit(Benefits benefits)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Benefits.Add(benefits);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutBenefit(Benefits benefits)
        {
            try
            {
                Benefits entity = GetBenefitById(benefits.BenefitID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(benefits);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteBenefit(int id)
        {
            try
            {
                DAL.Benefits itemToRemove = ManangementEntitiesSingleton.Instance.Benefits.Where(x => x.BenefitID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.Benefits.Remove(itemToRemove);
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
