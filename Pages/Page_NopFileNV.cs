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
using QuanLyDuAn.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_NopFileNV : UserControl
    {
        NopFileDao nfd = new NopFileDao();
        public static Panel panelFileCopy;
        public static Panel panel2Copy;
        int maNVNho;
        public Page_NopFileNV(int maNVNho)
        {
            InitializeComponent();
            panelFileCopy = panelFile;
            panel2Copy = panel2;
            this.maNVNho = maNVNho;
        }


        public static List<Page_FileAttachment> pfa = new List<Page_FileAttachment>();
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            // Xử lý các file được kéo thả ở đây
            foreach(string file in droppedFiles)
            {
                string filename = getFileName(file);
                pfa.Add(new Page_FileAttachment(filename, file)); 
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
        private string getFileName(string file)
        {
            return Path.GetFileName(file);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void btn_NopFile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pfa.Count; i++)
            {
                byte[] b = changeFileToByte(pfa[i].fullFileName);
                string filter = Path.GetExtension(pfa[i].fullFileName);
                string fileName = Path.GetFileNameWithoutExtension(pfa[i].fullFileName);
                int maFileMoi = nfd.MaFileNopMax() + 1;
                nfd.ThemFile(new NopFile(maFileMoi, maNVNho, Page_NhiemVu.MaNSH, b, filter, fileName));
            }
        }

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
                    pfa.Add(new Page_FileAttachment(fileName, file));
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

        private void btn_XoaTatCa_Click(object sender, EventArgs e)
        {
            panelFile.Controls.Clear();
            pfa.Clear();
            panelFile.Controls.Add(panel2);
        }
    }
}
