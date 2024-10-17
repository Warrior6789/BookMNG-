using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        //  CUNG CẤP DATA CHO FORM, THỰC RA LÀ CUNG CẤP DATA CHO CÁI DROPDOWN, BẤM XỔ, COMBOBOX
        // LẼ RA PHẢI LẤY TẤT CẢ CATEGORY TỪ DATABASE - HARDCODE TRC

        CategoryRepository categoryRepo = new CategoryRepository();
        public List<BookCategory> GetAllCategory()
        {
            return categoryRepo.GetCategories();
        }
        
    }
}
