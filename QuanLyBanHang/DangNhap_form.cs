using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyBanHang
{
    public partial class DangNhap_form : Form
    {
        public DangNhap_form()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;
            if (USER_BUS.CheckLogin(username, password))
            {
                User_form user = new User_form();
                this.Hide();
                user.ShowDialog();
            }
            else {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            DangKy_form dk = new DangKy_form();
            this.Hide();
            dk.ShowDialog();
        }
    }
}
