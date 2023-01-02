using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Egg.Interfaces
{

    

    

    internal interface IHaveNextProcess
    {

        System.Windows.Forms.Control NextAction { get; set; }

    }

    internal interface IHaveFailProcess
    {

    }

    internal interface ICanIfElse
    {

    }

    internal interface IBranch
    {

    }

    internal interface ICanFire
    {

    }

    internal interface ICanCollect
    {

    }
}
