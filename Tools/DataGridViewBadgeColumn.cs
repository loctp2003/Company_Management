using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Tools
{
    internal class DataGridViewBadgeColumn : DataGridViewImageColumn
    {
        public DataGridViewBadgeColumn()
        {
            CellTemplate = new DataGridViewBadgeCell();
        }
    }
}
