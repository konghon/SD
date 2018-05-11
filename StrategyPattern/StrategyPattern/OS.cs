using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class OS
    {
        private Dictionary<int, int> storageBlocks;
        private List<DiskSystem> disks;
        private IScheduler FIFOScheduler;
        private IScheduler SSTFScheduler;
        private IScheduler SCANScheduler;

        public OS()
        {

        }

        public Dictionary<int, int> ReadFromDisk(IScheduler scheduler, int block, int size)
        {
            throw new NotImplementedException();
        }

        public void WriteTodisk(IScheduler scheduler, int block )
        { }
    }
}
