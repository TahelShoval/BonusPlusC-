using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkersBenefitsDAL
    {
        public static List<WorkersBenefits> GetAllWorkersBenefits()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.WorkersBenefits.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static WorkersBenefits GetWorkersBenefitById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.WorkersBenefits.Where(w => w.ID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<WorkerBenefits> GetWorkersBenefitByWorkerId(int WorkerId)
        {
            try
            {
                List<WorkerBenefits> workerBenefits = new List<WorkerBenefits>();
                List<WorkersBenefits> WorkersBenefits = ManangementEntitiesSingleton.Instance.WorkersBenefits.Where(w => w.WorkerID == WorkerId).ToList();
                List<Benefits> benefits = BenefitsDAL.GetAllBenefits();
                List<Suppliers> suppliers = SuppliersDAL.GetAllSuppliers();
                foreach (var item in WorkersBenefits)
                {
                    WorkerBenefits w = new WorkerBenefits();
                    w.ID = item.ID;
                    foreach (var item2 in suppliers)
                        if (item2.SupplierID == item.SupplierID)
                            w.SupplierName = item2.SupplierName;
                    foreach (var item2 in benefits)
                        if (item2.BenefitID == item.BenefitID)
                            w.DetailsBenefit = item2.Details;
                    w.WorkerID = item.WorkerID;
                    w.BenefitStatus = item.BenefitStatus;
                    w.Coupon = item.Coupon;
                    workerBenefits.Add(w);
                }
                return workerBenefits;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostWorkersBenefit(WorkersBenefits WorkersBenefits)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.WorkersBenefits.Add(WorkersBenefits);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutWorkersBenefit(WorkersBenefits WorkersBenefits)
        {
            try
            {
                WorkersBenefits entity = GetWorkersBenefitById(WorkersBenefits.ID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(WorkersBenefits);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteWorkersBenefit(int id)
        {
            try
            {
                DAL.WorkersBenefits itemToRemove = ManangementEntitiesSingleton.Instance.WorkersBenefits.Where(x => x.ID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.WorkersBenefits.Remove(itemToRemove);
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
