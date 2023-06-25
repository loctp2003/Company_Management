using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace QuanLyDuAn.Models
{
    internal class User
    {
        public Image Photo { get; set; }
        public string Name { get; set; }
        public int Progress { get; set; }
        public double Amount { get; set; }
        public DateTime Deadline { get; set; }
    }
}
