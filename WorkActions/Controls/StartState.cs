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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egg
{
    [DefaultEvent("DoubleClick")]
    [ToolboxItemFilter("Egg.StartState", ToolboxItemFilterType.Require)]
    public partial class StartState : UserControl, IStateBase, IHaveNextProcess
    {
        public StartState()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            this.Paint += AStart_Paint;
        }

        private void AStart_Paint(object sender, PaintEventArgs e)
        {
            this.PaintName(e.Graphics);

        }

        [Category("WorkAction"),
            Description("Select the next state"),
            Editor(typeof(NextActionEditor), typeof(UITypeEditor))]
        public Control NextAction { get; set; }

        public string GetNextWorkItem()
        {
            throw new NotImplementedException();
        }
    }
}
