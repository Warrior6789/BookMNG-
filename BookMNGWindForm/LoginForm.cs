using Repositories.Entities;
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

namespace BookMNGWindForm
{
    public partial class LoginForm : Form
    {
        AccountService service = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // UI --- services --- repo --- DB
            // UI 
            UserAccount? acc = service.CheckLogin(txtEmail.Text, txtPass.Text);
            if(acc == null)
            {
                MessageBox.Show("LOGIN FAIL. CHECK EMAIL OR PASSWORD ","NOTICE",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(acc.Role != 1)
            {
                MessageBox.Show("YOU HAVE NO PERMISSION TO ACCESS THIS FUNCTION", "WRONG PRIVILEGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // NGON VỚI ĐÚNG ROLE 
            // MỞ MAINFORM
            BookManagerMainUI ui = new BookManagerMainUI();
            ui.Show(); // k dùng showdialog
            this.Hide(); // k close vì windown new login khi close loginform là  close app 
            
            


            
        }
    }
}
