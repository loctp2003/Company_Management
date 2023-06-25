using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using QuanLyDuAn.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_PhongBan : UserControl
    {
        PhongBanDao pbd = new PhongBanDao();
        private string tenPB;
        private string maPB;
        private int soNV;
        private Image[] imgs;
        public Bunifu.UI.WinForms.BunifuCheckBox cb;
        string chucNang; //DA NVTG
        public Page_PhongBan(string chucNang, string maPB, string tenPB, int soNV, params Image[] imgs)
        {
            InitializeComponent();
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.soNV = soNV;
            this.imgs = imgs;
            cb = bunifuCheckBox1;
            this.chucNang = chucNang;
        }

        private void bunifuButton1_MouseHover(object sender, EventArgs e)
        {
           
        }
        private void bunifuButton1_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void bunifuButton1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void CapNhatSoPhongBanTrongDA()
        {
            int count = 0;
            Page_TaoPhongBanDuAn.maPBList.Clear();
            Page_TaoPhongBanDuAn.tenPBList.Clear();
            Page_TaoNhiemVuDuAn.panelMainCopy.Controls.Clear();
           // Page_TaoNhiemVuDuAn.panelList.Clear();
            foreach (var pb in Page_TaoPhongBanDuAn.page_pbList)
            {
                var k = Page_TaoNhiemVuDuAn.panelList.FindAll(x => x.GetType() == typeof(Page_TaoNhiemVuDuAn_1_)).Find(x => {
                    Page_TaoNhiemVuDuAn_1_ tnvda = (Page_TaoNhiemVuDuAn_1_)x;
                    return tnvda.tenPB == pb.tenPB;
                });
                if (pb.cb.Checked == true)
                {
                    count++;
                    Page_TaoPhongBanDuAn.maPBList.Add(pb.maPB);
                    Page_TaoPhongBanDuAn.tenPBList.Add(pb.tenPB);
                    
                    if (k == null)
                    {
                        Page_TaoNhiemVuDuAn_1_ tnvda1 = new Page_TaoNhiemVuDuAn_1_(pb.tenPB, pb.maPB);
                        Page_TaoNhiemVuDuAn.panelList.Add(tnvda1);
                    }
                   
                }
                else
                {
                    int ind = Page_TaoNhiemVuDuAn.panelList.FindIndex(x => x==k);
                    if (ind >= 0)
                    {
                        Page_TaoNhiemVuDuAn.panelList.RemoveAt(ind);
                        while (ind >= 0 && ind < Page_TaoNhiemVuDuAn.panelList.Count)
                        {
                            if (Page_TaoNhiemVuDuAn.panelList[ind].GetType() == typeof(Page_TaoNhiemVuDuAn_2_))
                                Page_TaoNhiemVuDuAn.panelList.RemoveAt(ind);
                            else break;
                        }
                    }
                        
                }
            }
            for (int i = 0; i < Page_TaoNhiemVuDuAn.panelList.Count; i++)
            {
                Control panel = (Control)Page_TaoNhiemVuDuAn.panelList[i];
                panel.Location = new Point(10, 10 + i * (panel.Height + 10));
                Page_TaoNhiemVuDuAn.panelMainCopy.Controls.Add(panel);
            }
            Page_TaoPhongBanDuAn.lbl_CountSelectedCopy.Text = count.ToString();
        }
        private void CapNhatSoPhongBanTrongNVTG()
        {
            int count = 0;
            Page_TaoPhongBanDuAn.maPBList.Clear();
            Page_TaoPhongBanDuAn.tenPBList.Clear();
            foreach (var pb in Page_TaoPhongBanDuAn.page_pbList)
            {
                if (pb.cb.Checked == true)
                {
                    count++;
                    Page_TaoPhongBanDuAn.maPBList.Add(pb.maPB);
                    Page_TaoPhongBanDuAn.tenPBList.Add(pb.tenPB);
                }
            }
            Page_TaoPhongBanDuAn.lbl_CountSelectedCopy.Text = count.ToString();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
        private void bunifuButton1_Load(object sender, EventArgs e)
        {
            lbl_TenPB.Text = tenPB;
            lbl_SoNV.Text = soNV.ToString();

            if (imgs[4] != null) pc_Anh1.Image = imgs[4]; else pc_Anh1.Hide();
            if (imgs[3] != null) pc_Anh2.Image = imgs[3]; else pc_Anh2.Hide();
            if (imgs[2] != null) pc_Anh3.Image = imgs[2]; else pc_Anh3.Hide();
            if (imgs[1] != null) pc_Anh4.Image = imgs[1]; else pc_Anh4.Hide();
            if (imgs[0] != null) pc_Anh5.Image = imgs[0]; else pc_Anh5.Hide();
        }
        
        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chucNang == "DA")
                CapNhatSoPhongBanTrongDA();
            else if (chucNang == "NVTG")
                CapNhatSoPhongBanTrongNVTG();
        }

        private void Page_PhongBan_Load(object sender, EventArgs e)
        {

        }
    }
}
