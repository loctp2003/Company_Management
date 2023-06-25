using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_FileAttachment : UserControl
    {
        private string fileName;
        public string fullFileName;
        public string filter;
        public byte[] taiLieu = null;
        public Page_FileAttachment(string fileName, string fullFileName)
        {
            InitializeComponent();
            this.fileName = fileName;
            this.fullFileName = fullFileName;
        }

        public Page_FileAttachment(string fileName, string filter, byte[] taiLieu)
        {
            InitializeComponent();
            this.fileName = fileName;
            this.filter = filter;
            this.taiLieu = taiLieu;
        }

        private void lbl_TenFile_Click(object sender, EventArgs e)
        {

        }

        private void Page_FileAttachment_Load(object sender, EventArgs e)
        {
            lbl_TenFile.Text = fileName + " " + filter;
            if (taiLieu != null)
            {
                btn_Download.Visible = true;
                btn_Exit.Visible = false;
            }
            else
            {
                btn_Download.Visible = false;
                btn_Exit.Visible = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Frm_NopFile.pfa.Remove(this);
            if (Frm_NopFile.pfa.Count > 0)
            {
                Frm_NopFile.panelFileCopy.Controls.Clear();
                for (int i = 0; i < Frm_NopFile.pfa.Count; i++)
                {
                    Frm_NopFile.pfa[i].Location = new Point(10, 10 + (Frm_NopFile.pfa[i].Height + 10) * i);
                    Frm_NopFile.panelFileCopy.Controls.Add(Frm_NopFile.pfa[i]);
                }
            }
            else
            {
                Frm_NopFile.panelFileCopy.Controls.Clear();
                Frm_NopFile.panelFileCopy.Controls.Add(Frm_NopFile.panel_KeoThaCopy);
            }
        }

        private void Page_FileAttachment_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if (taiLieu != null)
            {
                using (Stream file = File.OpenWrite($@"C:\Users\HP\Downloads\{fileName}.{filter}"))
                {
                    file.Write(taiLieu, 0, taiLieu.Length);
                }
                MessageBox.Show("Tải về thành công");
            }
        }
    }
}
