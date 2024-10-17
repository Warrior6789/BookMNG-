using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{ 
    // 3 - layer architechture 
    // UI -form --- services --- repository --- DB 
    // MAINUI --- BOOKSERVICES --- BOOKREPOSITORY (ENTITY BOOK)  --- DB(BOOK TABLE) 
    // request/response
    // lây data xuống db
    // lấy data từ db show 

     public class BookService
    {
        // class  này   trung chuyển dữ liệu giữa form ui và csdl
        //  nó chứa data trong ram xử lí mọi thứ  thuật toán nêus cần ròi đẩy lên UI 
        //  hoặc cất vào db 
        //  chứa list các book đọc từ db 
        // chứa info từ màn  hình ui dự định cập  nhật xuống db 
        // thường sẽ chứa hàm crud nhưng chỉ trong ram - linq có thể nhảy vào 
        //  giả bộ đọc data từ db lên ròi giờ show ra màn  hình ui tạm thời hard code các danh sách cuốn sách 
        // gọi repo để lấy data từ DB 
        BookRepository repository = new BookRepository();
        public List<Book> GetAllBooks()
        {
            repository = new();
            return repository.GetBooks();
        }

        public void AddBookFromUI(Book book)
        {
            repository.AddBook(book);
            // ĐIỀU  GÌ XẢY RA NẾU NHẬP TRÙNG KEY
            // CHALLENGE: CHAT GPT -> HOW TO HANDLE DUPLICATE OF PRIMARY KEY EXCEPTION  DURING CREATING A BOOK IN BOOK MANAGEMENT APP USING ENTITY FRAMEWORK CORE IN C# 
            
        }

        public void UpdateBookFromUI(Book book)
        {
            repository.UpdateBook(book);
        }

        public void RemoveBookFromUI(Book book)
        {
            repository.DeleteBook(book);
        }
        
          
    }
}
