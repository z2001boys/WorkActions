using Egg.Editor;
using Egg.Interfaces;
using Egg.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Egg
{
    [DefaultEvent("EnterState")]
    [ToolboxItemFilter("Egg.ProcessState", ToolboxItemFilterType.Require)]
    public partial class ProcessState : UserControl, IStateBase, IHaveNextProcess, IHaveFailProcess, ICanProcess
    {


        public ProcessState()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Paint += AWork_Paint;
        }

        public event EventHandler<IHaveFlowData> EnterState;

        private void AWork_Paint(object sender, PaintEventArgs e)
        {
            this.PaintName(e.Graphics);
        }

        [Category("WorkFlow"),
            Description("Select the next state"),
            Editor(typeof(NextActionEditor), typeof(UITypeEditor))]
        public Control NextAction { get; set; }


    }
}
