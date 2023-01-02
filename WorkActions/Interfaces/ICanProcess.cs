using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg.Interfaces
{
    internal interface ICanProcess
    {
        event EventHandler<IHaveFlowData> EnterState;
    }

    
}
