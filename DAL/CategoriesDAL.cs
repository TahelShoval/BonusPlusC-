using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDAL
    {
        public static List<Categories> GetAllCategories()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Categories.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Categories GetCategoryById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Categories.Where(c => c.ID == id).ToList()[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostCategory(Categories category)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Categories.Add(category);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void PutCategory(Categories category)
        {
            try
            {
                Categories entity = GetCategoryById(category.ID);
                if (entity == null)
                {
                    return;
                }
                ManangementEntitiesSingleton.Instance.Entry(entity).CurrentValues.SetValues(category);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteCategory(int id)
        {
            try
            {
                DAL.Categories itemToRemove = ManangementEntitiesSingleton.Instance.Categories.Where(x => x.ID == id).ToList()[0];
                if (itemToRemove != null)
                {
                    ManangementEntitiesSingleton.Instance.Categories.Remove(itemToRemove);
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
