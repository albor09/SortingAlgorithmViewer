using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src
{
    class SortingSyncContoller
    {
        private bool isPaused;
        private TaskCompletionSource<bool> tcs;

        public bool IsPaused { get { return isPaused; } set { isPaused = value; } }
        public TaskCompletionSource<bool> Tcs { get { return tcs; } }

        public SortingSyncContoller()
        {
            this.tcs = new TaskCompletionSource<bool>();
        }

        public void WaitForStep()
        {
            tcs.Task.Wait();
            tcs = new TaskCompletionSource<bool>();
        }

        public void DoStep() 
        {
            if (IsPaused)
                Tcs.SetResult(true);
        }

        public void Refresh()
        {
            this.tcs = new TaskCompletionSource<bool>();
        }
    }
}
