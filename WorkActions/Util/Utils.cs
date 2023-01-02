using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egg.Util
{
    internal static class Utils
    {
        public static void PaintName(this Control ctrl,Graphics graphic)
        {
            // Create a StringFormat object with the each line of text, and the block
            // of text centered on the page.
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Draw the text and the surrounding rectangle.
            graphic.DrawString(
                ctrl.Name, 
                ctrl.Font, 
                new SolidBrush(ctrl.ForeColor),
                new Rectangle(0,0, ctrl.Width,ctrl.Height), 
                stringFormat);
        }
    }
}
