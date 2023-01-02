using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg.Interfaces
{
    internal interface IStateBase
    {

    }

    public interface IHaveFlowData
    {
        object UserData { get; }
    }

    public class WorkFlowEventBase : IHaveFlowData
    {
        public object UserData { get; internal set; }
    }
}
