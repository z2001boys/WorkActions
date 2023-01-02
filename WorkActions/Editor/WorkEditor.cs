using Egg.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Control = System.Windows.Forms.Control;
using ListBox = System.Windows.Forms.ListBox;

namespace Egg.Editor
{
    internal class NextActionEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            //**************Prepare state***********************************
            //get the control item
            var targetControl = (Control)context.Instance;
            //use IWindowsFormsEditorService object to display a control in the dropdown area
            IWindowsFormsEditorService frmsvr = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            //return if no service
            if (frmsvr == null) return null;
            //return if control has no parent
            if (targetControl.Parent == null) return null;
            if (!(targetControl.Parent is WorkFlow parrentFlow)) return null;


            //**************Scan item***************************************
            var list = new ListBox();
            foreach (Control sameLevelControl in parrentFlow.Controls)
            {
                if (!(sameLevelControl is IStateBase)) continue;
                list.Items.Add(sameLevelControl);
            }

            //add empty item            
            list.Items.Add("");

            list.SelectedValueChanged += (ss, ee) =>
            {
                frmsvr.CloseDropDown();
            };

            //**************Show drop box**********************************
            frmsvr.DropDownControl(list);

            if ((string)list.SelectedItem == "") return null;


            return list.SelectedItem;

        }


    }
}
