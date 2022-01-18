using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoriesBL
    {
        public static List<DTO.CategoriesDTO> GetAllCategories()
        {
            List<DAL.Categories> listCategories = DAL.CategoriesDAL.GetAllCategories();
            return DTO.Convert.CategoriesConvert.ConvertDalEntityToDto(listCategories);
        }

        public static DTO.CategoriesDTO GetCategoryById(int id)
        {
            DAL.Categories category = DAL.CategoriesDAL.GetCategoryById(id);
            return DTO.Convert.CategoriesConvert.ConvertDalEntityToDto(category);
        }

        public static void PostCategory(DTO.CategoriesDTO categoryDTO)
        {
            DAL.Categories category = DTO.Convert.CategoriesConvert.ConvertDalDtoToEntity(categoryDTO);
            DAL.CategoriesDAL.PostCategory(category);
        }

        public static void PutCategory(DTO.CategoriesDTO categoryDTO)
        {
            DAL.Categories category = DTO.Convert.CategoriesConvert.ConvertDalDtoToEntity(categoryDTO);
            DAL.CategoriesDAL.PutCategory(category);
        }

        public static void DeleteCategory(int id)
        {
            DAL.CategoriesDAL.DeleteCategory(id);
        }
    }
}

