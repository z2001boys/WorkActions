using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egg
{
       
    [Designer(typeof(WorkFlowDesigner),typeof(IRootDesigner))]
    public partial class WorkFlow : UserControl
    {
        public static readonly string WorkFlowName = "WorkFlow"; 
        public WorkFlow()
        {
            InitializeComponent();
            BackColor = Color.CadetBlue;

            // Minimize flickering during animation by enabling  
            // double buffering.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //掛載繪圖事件
            this.Paint += WorkAction_Paint;
            
        }

        private void WorkAction_Paint(object sender, PaintEventArgs e)
        {

               
        }

        public void ForcePaint()
        {
            this.OnPaintBackground(null);
        }
    }
}
