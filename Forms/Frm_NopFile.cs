using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Pages;
using System.IO;
namespace QuanLyDuAn.Forms
{
    public partial class Frm_NopFile : Form
    {
        NopFileDao nfd = new NopFileDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        public static Panel panelFileCopy;
        public static Panel panel_KeoThaCopy;
        int maNVNho;
        string mode; // Xem Nop
        public Frm_NopFile(string mode, int maNVNho)
        {
            InitializeComponent();
            panelFileCopy = panelFile;
            panel_KeoThaCopy = panel_KeoTha;
            this.maNVNho = maNVNho;
            this.mode = mode;
        }
        public static List<Page_FileAttachment> pfa = new List<Page_FileAttachment>();
        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            string file = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Word Document|*.docx|Word 97 - 2003 Document|*.doc|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    file = ofd.FileName;
                    string fileName = getFileName(file);
                    pfa.Insert(0, new Page_FileAttachment(fileName, file));
                }
                if (pfa.Count > 0)
                {
                    panelFile.Controls.Clear();
                    for (int i = 0; i < pfa.Count; i++)
                    {
                        pfa[i].Location = new Point(10, 10 + (pfa[i].Height + 10) * i);
                        panelFile.Controls.Add(pfa[i]);
                    }
                }
            }
        }
        private string getFileName(string file)
        {
            return Path.GetFileName(file);
        }
        private void btn_XoaTatCa_Click(object sender, EventArgs e)
        {
            panelFile.Controls.Clear();
            pfa.Clear();
            panelFile.Controls.Add(panel_KeoTha);
        }
        byte[] changeFileToByte(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(filename);
                fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return bytes;
            }
        }
        private void panelFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            // Xử lý các file được kéo thả ở đây
            foreach (string file in droppedFiles)
            {
                string filename = getFileName(file);
                pfa.Insert(0, new Page_FileAttachment(filename, file));
            }
            if (pfa.Count > 0)
            {
                panelFile.Controls.Clear();
                for (int i = 0; i < pfa.Count; i++)
                {
                    pfa[i].Location = new Point(10, 10 + (pfa[i].Height + 10) * i);
                    panelFile.Controls.Add(pfa[i]);
                }
            }
        }

        private void panelFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pfa.Count; i++)
            {
                byte[] b = changeFileToByte(pfa[i].fullFileName);
                string filter = Path.GetExtension(pfa[i].fullFileName);
                string fileName = Path.GetFileNameWithoutExtension(pfa[i].fullFileName);
                int maFileMoi = nfd.MaFileNopMax() + 1;
                nfd.ThemFile(new NopFile(maFileMoi, maNVNho, Page_NhiemVu.MaNSH, b, filter, fileName));
            }
            Page_DanhSachNV_2_.btn_NopFileCopy.Text = "Xem File";
            Page_DanhSachNV_2_.btn_SuaCopy.Visible = true;
            mode = "Xem";
            Frm_NopFile_Load(sender, e);
            nvnd.CapNhatTinhTrangTheoMaNVNho(new NhiemVuNho(maNVNho, "In Progress"));
            this.Close();
            Page_ThongTinNhiemVu.cnnv = new Page_CapNhatNV();
            Page_ThongTinNhiemVu.dsnvNV = new Page_DanhSachNV("NV");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Frm_NopFile_Load(object sender, EventArgs e)
        {
            if (mode == "Xem")
            {
                btn_MoFile.Visible = false;
                btn_XoaTatCa.Visible = false;
                btn_Luu.Visible = false;
                var reader = nfd.DocDuLieuNopFileTuMaNVNho(maNVNho);
                int i = 0;
                while (reader.Read())
                {
                    Page_FileAttachment pfa = new Page_FileAttachment(reader["TenFile"].ToString().Trim(), reader["Filter"].ToString().Trim(), (byte[])reader["TaiLieu"]);
                    pfa.Location = new Point(10, 10 + (pfa.Height + 10) * i);
                    panelFile.Controls.Add(pfa);
                }
                nfd.dao.conn.Close();
            }
            else if (mode == "Nop")
            {
                btn_MoFile.Visible = true;
                btn_XoaTatCa.Visible = true;
                btn_Luu.Visible = true;
                var reader = nfd.DocDuLieuNopFileTuMaNVNho(maNVNho);
                int i = 0;
                while (reader.Read())
                {
                    Page_FileAttachment pfa = new Page_FileAttachment(reader["TenFile"].ToString().Trim(), reader["Filter"].ToString().Trim(), (byte[])reader["TaiLieu"]);
                    pfa.Location = new Point(10, 10 + (pfa.Height + 10) * i);
                    panelFile.Controls.Add(pfa);
                }
                nfd.dao.conn.Close();
            }
        }
    }
}
