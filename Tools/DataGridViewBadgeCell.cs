using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Tools
{
    internal class DataGridViewBadgeCell: DataGridViewImageCell
    {
        static Image emptyImage;
        static DataGridViewBadgeCell()
        {
            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewBadgeCell()
        {
            this.ValueType = typeof(int);
        }
        // Method required to make the Progress Cell consistent with the default Image Cell. 
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
        protected override object GetFormattedValue(object value,
                            int rowIndex, ref DataGridViewCellStyle cellStyle,
                            TypeConverter valueTypeConverter,
                            TypeConverter formattedValueTypeConverter,
                            DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }
        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            try
            {
                string s = value.ToString();
                Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
                Brush foreColorBrush = new SolidBrush(Color.White);
                // Draws the cell grid
                base.Paint(g, clipBounds, cellBounds,
                 rowIndex, cellState, value, formattedValue, errorText,
                 cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));
                // Draw the progress bar and the text
                cellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                var color = Color.FromArgb(0, 0, 0);
                if (s == "In Progress")
                    color = Color.FromArgb(0, 0, 255);
                else if (s == "Completed")
                    color = Color.FromArgb(0, 100, 0);
                else if (s == "On Hold")
                    color = Color.FromArgb(255, 165, 0);
                else if (s == "Cancelled")
                    color = Color.Red;
                else if (s == "Not Started")
                    color = Color.DarkGray;
                g.FillRectangle(new SolidBrush(color), cellBounds.X + 40, cellBounds.Y + 15, Convert.ToInt32((cellBounds.Width - 80)), cellBounds.Height - 30);
                g.DrawString(s, cellStyle.Font, foreColorBrush, cellBounds.X + (Convert.ToInt32((cellBounds.Width - 80)) - s.Length*2) / 2, cellBounds.Y + 18);
            }
            catch (Exception e) { }

        }
    }
}
