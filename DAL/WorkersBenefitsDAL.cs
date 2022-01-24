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
                List<SuppliersBenefits> suppliersBenefits = SuppliersBenefitsDAL.GetAllSuppliersBenefits();
                List<Benefits> benefits = BenefitsDAL.GetAllBenefits();
                List<Suppliers> suppliers = SuppliersDAL.GetAllSuppliers();
                foreach (var item in WorkersBenefits)
                {
                    WorkerBenefits w = new WorkerBenefits();
                    w.ID = item.ID;
                    w.SupplierBenefitID = item.SupplierBenefitID;
                    SuppliersBenefits sb = SuppliersBenefitsDAL.GetSuppliersBenefitById((int)item.SupplierBenefitID);
                    foreach (var item2 in suppliers)
                        if (item2.SupplierID == sb.SupplierId)
                        {
                            w.SupplierName = item2.SupplierName;
                            w.Supplierlogo = item2.logo;
                        }

                    foreach (var item2 in benefits)
                        if (item2.BenefitID == sb.BenefitId)
                        {
                            w.BenefitDetails = item2.Details;
                            w.BenefitImage = item2.Image;
                        }

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

        public static bool AddWorkersBenefits(List<WorkersBenefits> listWB)
        {
            try
            {
                List<SuppliersBenefits> suppliersBenefits = SuppliersBenefitsDAL.GetAllSuppliersBenefits();
                foreach (var item in listWB)
                {
                    foreach (var sb in suppliersBenefits)
                    {
                        if (item.SupplierBenefitID == sb.ID)
                        {
                            string couponString = "";

                            if (item.WorkerID / 10 == 0)
                                couponString = "00" + item.WorkerID.ToString();
                            else if (item.WorkerID / 100 == 0)
                                couponString = "0" + item.WorkerID.ToString();
                            else
                                couponString = item.WorkerID.ToString();

                            if (sb.SupplierId / 10 == 0)
                                couponString += "00" + sb.SupplierId.ToString();
                            else if (sb.SupplierId / 100 == 0)
                                couponString += "0" + sb.SupplierId.ToString();
                            else
                                couponString += sb.SupplierId.ToString();

                            if (sb.BenefitId / 10 == 0)
                                couponString += "00" + sb.BenefitId.ToString();
                            else if (sb.BenefitId / 100 == 0)
                                couponString += "0" + sb.BenefitId.ToString();
                            else
                                couponString += sb.BenefitId.ToString();


                            item.Coupon = couponString;
                            break;
                        }
                    }
                    ManangementEntitiesSingleton.Instance.WorkersBenefits.Add(item);
                    ManangementEntitiesSingleton.Instance.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
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
