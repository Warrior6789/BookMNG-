using Accessibility;
using Services;
using Repositories;
using Repositories.Entities;
using System.Linq;
using System.Windows.Forms;
namespace BookMNGWindForm
{
    public partial class BookManagerMainUI : Form
    {
        private BookService service = new BookService();
        private Book _selected = null;
        public BookManagerMainUI()
        {
            InitializeComponent();
        }
        // hàm fill data  vào grid đc gọi nhiều lần ở nút create, update, delete
        private void FillDataGridView()
        {
            dgvList.DataSource = null; // xóa trắng grid 
            dgvList.DataSource = service.GetAllBooks();
            dgvList.Columns["BookCategory"].Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // gọi services để cung cấp data vào lưới/table
            FillDataGridView();

            

        }
        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
        private void grbSerachCriteria_Enter(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // ta sẽ lấy 2 chuỗi trong   txtBookName và txtDescription
            // và where trên book đang có 
            var books = new BookService().GetAllBooks();
            dgvList.DataSource = null;

            dgvList.DataSource = books.Where(delegate (Book x)
            {
                bool name = String.IsNullOrWhiteSpace(txtName.Text) || x.BookName.ToLower().Contains(txtName.Text.ToLower());
                bool description = String.IsNullOrWhiteSpace(txtDescription.Text) || x.Description.ToLower().Contains(txtDescription.Text.ToLower());

                return name && description;
            }).ToList();
            dgvList.Columns["BookCategory"].Visible = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();
            // gọi màn hình  detail lên màn hình bản chất là class bookdetailform khác truyền  thống là render bề mặt 
            // render đi em 
            // f.show() nguy hiểm vì  cứ new là có cửa    sổ mơi 
            f.ShowDialog(); // render màn hình mới
            // f5 lưới 
            //
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();

            if (_selected != null) // ng dung phải chọn 1 dòng trong grid
            {
                f.BookSelect = _selected; // lấy cuốn sách được chọn ở grid đưa qua deltailform bằng set
                f.ShowDialog(); // mở form lên sau khi hoàn thành close formdetail và
                FillDataGridView();// refresh lại grid 
            }
            else
            {
                MessageBox.Show("Please Select a Certain book to edit,", " select  one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvList.SelectedRows.Count > 0)
            {
                _selected = (Book)dgvList.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show("DO YOU WANT TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    service.RemoveBookFromUI(_selected);
                    FillDataGridView();
                    _selected = null;
                }

            }
            else
            {
                MessageBox.Show("PLEASE CHOOSE ROW TO DELETE","NOTICE",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU  WANT TO EXIT", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {

            // có thể chọn 1  dòng hay nhiều dòng - chìm chuột, cho nên t sẽ lấy dòng đầu tiên đc chọn nếu ng dùng thì chọn cái đầu tiên 
            if (dgvList.SelectedRows.Count > 0)
            {
                // nếu  chọn ít nhất 1 dòng thì cứ dòng đầu đc chọn là bốc nó ra đẩy   sang màn hình detail
                _selected = (Book)dgvList.SelectedRows[0].DataBoundItem; // lấy 1  dòng chính là kiểu obj tổng quát  nhưng bản chất là book do ban đầu .datasource = List<Book> của hàm GetAll
                                                                         // đẩy sang form detail
                                                                         // khai biến,new, gán prop, show dialog
                                                                         // form detail: mở lên check seclected khác nulll k  khác nulll  sang mode update fill/show data  đc gơi

            }
            //else
            //{
            //    if(dgvList.CurrentCell != null)
            //    {
            //        MessageBox.Show("Please choose a row.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //    _selected = null;
            //}
            // nếu user chọn cell thay vì chọn nguyên dòng reset biến _selected về null vì 
            // khi ng  dùng chọn cell thì  selectedRow.count  sẽ = 0 và khối lệnh if k thức thi
            // và biến _selected vẫn giữ giá trị cũ trong trường hợp _selected trước đó đã gán 
            // giá trị  và nên reset lại để tránh giữ giá trị cũ k còn hợp lệ


        }
    }
}
