using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Convert
{
    public class CategoriesConvert
    {
        public static List<CategoriesDTO> ConvertDalEntityToDto(List<Categories> category)
        {
            if (category == null)
                return null;
            List<CategoriesDTO> listCategory = category.Select(c => ConvertDalEntityToDto(c)).ToList();
            return listCategory;
        }

        public static CategoriesDTO ConvertDalEntityToDto(Categories c)
        {
            if (c is null)
                return null;
            CategoriesDTO category = new CategoriesDTO()
            {
                ID = c.ID,
                category = c.category
            };
            return category;
        }

        public static Categories ConvertDalDtoToEntity(CategoriesDTO c)
        {
            try
            {
                Categories category = new Categories()
                {
                    ID = c.ID,
                    category = c.category
                };
                return category;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}

