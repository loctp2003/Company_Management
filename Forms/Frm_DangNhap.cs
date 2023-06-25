using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_DangNhap : Form
    {
        DangNhapDao dndao = new DangNhapDao();
        public static BunifuTextBox txt_UsernameCopy;
        public static BunifuTextBox txt_PasswordCopy;
        public Frm_DangNhap()
        {
            InitializeComponent();
            txt_UsernameCopy = txt_Username;
            txt_PasswordCopy = txt_Password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            LoaiTaiKhoan = "TkNhanVien";
            if (Properties.Settings.Default.userName != string.Empty)
            {
                txt_Username.Text = Properties.Settings.Default.userName;
                txt_Password.Text = Properties.Settings.Default.passUser;
            }
            this.Size = new Size(Width, Height - 87);
            panel4.Hide();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_OnIconRightClick(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
            if (txt_Password.UseSystemPasswordChar)
                txt_Password.PasswordChar = '●';
            else txt_Password.PasswordChar = '\0';
            Image img = Image.FromFile("../../Images/" + (txt_Password.UseSystemPasswordChar ? "hide" : "show") + ".png");
            txt_Password.RightIcon.Image = new System.Drawing.Bitmap(img);
        }
        public static string LoaiTaiKhoan;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Username FROM " + LoaiTaiKhoan + " WHERE Username = @usernameLogIn AND Pass_word = @pass_word";
                dndao.KiemTraDangNhap(txt_Username.Text, txt_Password.Text, query);

                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.userName = txt_Username.Text;
                    Properties.Settings.Default.passUser = txt_Password.Text;
                    Properties.Settings.Default.Save();
                }
                if (!checkBox1.Checked && Properties.Settings.Default.userName == string.Empty)
                {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.passUser = "";
                    Properties.Settings.Default.Save();
                }
                Frm_Main m = new Frm_Main();
                m.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                /*MessageBox.Show("Đăng nhập thất bại \n" + ex.Message);*/
                this.Size = new Size(Width, Height + 87);
                panel4.Show();
            }
        }
        private void rb_NhanVien_CheckedChanged(object sender, EventArgs e)
        {
            LoaiTaiKhoan = "TkNhanVien";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LoaiTaiKhoan = "TkGiamDoc";
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_InvalidPwd_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            this.Size = new Size(Width, Height - 87);
        }
    }
}
