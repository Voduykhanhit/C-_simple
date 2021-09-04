using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyBanHang
{
    public partial class DangKy_form : Form
    {
        public DangKy_form()
        {
            InitializeComponent();
        }

        private void btn_RegisterF_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string passwordAgain = txt_passwordAgain.Text;
            if (password != passwordAgain)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                USER_BUS.Register(username,password);
                MessageBox.Show("Đăng ký thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap_form dn = new DangNhap_form();
            this.Hide();
            dn.ShowDialog();
        }
    }
}
