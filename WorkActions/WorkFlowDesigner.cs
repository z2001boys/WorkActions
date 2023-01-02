using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace Egg
{
    [ToolboxItemFilter("Egg.StartState", ToolboxItemFilterType.Require)]
    [ToolboxItemFilter("Egg.ProcessState", ToolboxItemFilterType.Require)]
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    internal class WorkFlowDesigner : DocumentDesigner
    {

        public WorkFlowDesigner()
        {
            Trace.WriteLine("WorkFlowDesigner ctor");



        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);


            //------------------------------------
            //  component changed
            //------------------------------------
            IComponentChangeService cs =
                GetService(typeof(IComponentChangeService))
                as IComponentChangeService;

            if (cs != null)
            {
                cs.ComponentChanged +=
                    new ComponentChangedEventHandler(OnComponentChanged);
            }



            //add verbs
            //this.Verbs.Add(
            //    new DesignerVerb("Run Test",
            //    new EventHandler(OnVerbRunTest))
            //    );


        }

        /// <summary>
        /// 當元件被修改的時候發生
        /// 任何移動或者改變的動作都會在此處發
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnComponentChanged(
            object sender,
            ComponentChangedEventArgs e)
        {            

            if (this.Component is WorkFlow ctrl)
            {
                ctrl.Refresh();
            }
        }

    }
}
