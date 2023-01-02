using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg.Interfaces
{
    public interface IWorker
    {
        void Start();
        void Stop();
        void Initial();
        void Abort();

        event EventHandler<WorkerState> StateChanged;
        WorkerState State { get; }


    }

    public enum WorkerState
    {
        Runing,
        Idle,
    }
}
