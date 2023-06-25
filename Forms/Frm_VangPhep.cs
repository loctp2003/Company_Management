using QuanLyDuAn.Dao;
using QuanLyDuAn.Models;
using QuanLyDuAn.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_VangPhep : Form
    {
        ChamCongDao ccd = new ChamCongDao();
        public Frm_VangPhep(DateTime date,string ma)
        {
            InitializeComponent();
            startDate.Value = date;
            endDate.Value = date;
            txt_MaNV.Text = ma;
        }

        private void Frm_VangPhep_Load(object sender, EventArgs e)
        {
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XinNghi_Click(object sender, EventArgs e)
        {
            if (startDate.Value.Month == endDate.Value.Month)
            {
                int ngay = endDate.Value.Day - startDate.Value.Day;
                addNghi(ngay);
            }
            else
            {
                int ngay = DateTime.DaysInMonth(startDate.Value.Year, startDate.Value.Month) - startDate.Value.Day;
                addNghi(ngay);
                for (int i = 1; i <= endDate.Value.Day; i++)
                {
                    DateTime dt = new DateTime(endDate.Value.Year, endDate.Value.Month, i);
                    ChamCong cc = new ChamCong(txt_MaNV.Text, null, null, cb_LyDo.Text, txt_ChuThich.Text, dt);
                    ccd.InsertNghi(cc);
                }
            }
            this.Close();
        }
        void addNghi(int ngay)
        {
            for (int i = 0; i <= ngay; i++)
            {
                DateTime dt = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day + i);
                ChamCong cc = new ChamCong(txt_MaNV.Text, null, null, cb_LyDo.Text, txt_ChuThich.Text, dt);
                ccd.InsertNghi(cc);
            }
        }

        private void cb_LyDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_LyDo.SelectedItem.ToString() == "Khác")
            {
                txt_ChuThich.Enabled = true;
            }
        }
    }
}
