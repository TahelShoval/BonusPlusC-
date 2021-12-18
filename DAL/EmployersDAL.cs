using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployersDAL
    {
        public static List<Employers> GetAllEmployers()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Employers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Employers GetEmployerById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Employers.Where(w => w.EmployerID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Employers GetEmployerByUserName(string userName)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Employers.Where(w => w.EmployerUserName == userName).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostEmployer(Employers employers)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Employers.Add(employers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutEmployer(Employers employers)
        {
            try
            {
                Employers entity = GetEmployerById(employers.EmployerID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(employers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteEmployer(int id)
        {
            try
            {
                DAL.Employers itemToRemove = ManangementEntitiesSingleton.Instance.Employers.Where(x => x.EmployerID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.Employers.Remove(itemToRemove);
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
