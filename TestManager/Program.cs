using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManagementDbContext context = new BookManagementDbContext(); // đây là lớp chịu trách nhiệm tương tác với cơ sở dữ liệu trong ứng dụng sử dụng entity framework core 
            List<Book> arr =  context.Books.ToList();
            arr.ForEach(x => Console.WriteLine(x.BookId + " | " + x.BookName ));
            // in ra tất cả sách thuộc chủ đề 5 
            arr.ForEach(x => {if(x.BookCategoryId == 5) Console.WriteLine(x.BookName + " | " + x.BookCategoryId); });
        }
    }
}
