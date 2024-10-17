using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public  class CategoryRepository
    {
        private BookManagementDbContext _context;

        public List<BookCategory> GetCategories()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
