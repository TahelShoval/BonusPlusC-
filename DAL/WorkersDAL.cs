using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkersDAL
    {
        public static List<Workers> GetAllWorkers()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Workers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Workers GetWorkerById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Workers.Where(w => w.ID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Workers> GetWorkersByEmployerId(int employerId)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Workers.Where(w => w.EmployerID == employerId).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Workers GetWorkerByUserName(string userName)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Workers.Where(w => w.WorkerUserName == userName).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Workers GetWorkerByEmail(string email)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Workers.Where(w => w.Email == email).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostWorker(Workers worker)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Workers.Add(worker);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutWorker(Workers worker)
        {
            try
            {
                Workers entity = GetWorkerById(worker.ID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(worker);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteWorker(int id)
        {
            try
            {
                Workers itemToRemove = ManangementEntitiesSingleton.Instance.Workers.Where(x => x.ID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.Workers.Remove(itemToRemove);
                    ManangementEntitiesSingleton.Instance.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //public static void GetWorkerBenefits(int id)
        //{
        //    List<Benefits> listBenefits = ManangementEntitiesSingleton.Instance.EmployersBenefits.Where(b => b.WorkerID == id).ToList<Benefits>();   
        //}

    }
}
