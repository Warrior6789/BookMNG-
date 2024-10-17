using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
namespace BookMNGWindForm
{
    public partial class BookDetailForm : Form
    {
        // vì detailform là 1 class, nên nó có prop  như bt hơn  bt là nó là class có thể render 
        public Book BookSelect { get; set; } = null; // mặc định  mở leen k có book nào  cả ,  nếu  muốn có thì phải chấm       .BookSelect =  cuốn muốn gán vào  
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            // mở màn hình detail thì ta sẽ:
            //1. fill đầy category dropdown - lấy data từ table category 
            //2. nếu là edit cuốn sách thì fill data cuốn sách muốn edit vào các ô tương ứng 
            //3. nếu là tạo mới chẵn làm gì nữa 


            BookCategoryService bookCategory = new BookCategoryService();
            // đổ full data cb
            cbCatagory.DataSource = bookCategory.GetAllCategory(); //fill vào cb khi add book 
            // chọn cột hiển thị trên cbo 
            cbCatagory.DisplayMember = "BookGenreType";
            // chọn cột để lấy value thực sự cần dùng 
            // chọn self help dễ cho user => coder map  sang value 5 của cột bookcategoryid  dùng làm pk đẩy vào table book
            cbCatagory.ValueMember = "BookCategoryId";
            // nhảy đến giá trị bất kì mình thích trong combo
            //cbCatagory.SelectedValue = 2; // default  với  mình là self - help 
            // check có phải edit hay k 
            // check bookselect coi có đc set  khác null hay k
            // nếu có sách thì fill vào các ô
            if (BookSelect != null)
            {   //K CHO EDIT BOOKID
                lblHeader.Text = "Update selected book";
                txtBookID.Enabled = false;
                txtBookID.Text = BookSelect.BookId.ToString();
                txtBookName.Text = BookSelect.BookName.ToString();
                txtBookDescription.Text = BookSelect.Description.ToString();
                cbCatagory.SelectedValue = BookSelect.BookCategoryId;
                txtAuthor.Text = BookSelect.Author.ToString();
                txtQuantity.Text = BookSelect.Quantity.ToString();
                txtPrice.Text = BookSelect.Price.ToString();
                dtpDate.Text = BookSelect.PublicationDate.ToString();
                lblHeader.Text = "Update selected book";
            }
            else
                lblHeader.Text = "Create a book";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // new cuốn sách với các info lấy từ ô text để update hoặc tạo  mới thì phải đưa ô text vào một cuốn sách k quan tâm sách mới hay cũ 
            // nếu là sách cũ edit  mode, thì cuốn sách new có id của book đã có (selected)
            // nếu là sách mới add mode, thì cuốn sách  này có id mới và  nó k đc trùng đám sách cũ và mình insert xuống DB 
            Book book = new Book()
            {
                BookId = int.Parse(txtBookID.Text),
                BookName = txtBookName.Text,
                Description = txtBookDescription.Text,
                PublicationDate = dtpDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cbCatagory.SelectedValue.ToString())
            };// obj initalization
            // gưi xuống DB qua book services
            BookService service = new();
            // làm sao biết mode nào add hay update
            // check mode , dùng selected để check 
            if (BookSelect != null)
            {
                service.UpdateBookFromUI(book);
            }
            else
                service.AddBookFromUI(book);
            // CHO DÙ NEW HAY EDIT XONG PHẢI TẮT CAI MÀN HÌNH DETAIL
            Close();
            // sau khi làm xong thì phải refresh cái lưới sau mõi hành động add,update,delete...
            // bên main form phải refresh lưới ở ngay sau chổ gọi detail 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
