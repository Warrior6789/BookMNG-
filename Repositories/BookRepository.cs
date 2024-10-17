using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
     public class BookRepository
    {
        // class này chơi trực tiếp với sql server qua DbContext(có sẵn cs) 
        // class này sẽ bị gọi bởi class BookService
        // UI ---- bookservice ---- bookrepo --- dbcontext --- table 

        // ta cung cấp crud cơ bản 
        private BookManagementDbContext _context; // k new, new ở từng hàm trong repo 

        public List<Book> GetBooks()
        {
            //_context = new BookManagementDbContext();
            _context = new();
            return _context.Books.ToList(); 
        }
        // hàm này cập  nhật 1 cuốn sách có sẵn 
        // cuốn sách đưa  cho hàm  này từ trên ui đẩy xuống serivce --- repo --- gọi dbcontext đưa xuống database 
        public void UpdateBook(Book book)
        {
            //_context = new BookManagementDbContext();
            _context = new();
            _context.Books.Update(book); // sql: update book set ....
            _context.SaveChanges(); // run câu sql 
        }
        public void AddBook(Book book)
        {
            //_context = new BookManagementDbContext();
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context = new();
            _context.Remove(book);
            _context.SaveChanges();
        }
    }
}
