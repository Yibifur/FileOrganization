using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENG307_201180077_HW1
{
    internal class QueueData
    {
        //Data class to be used in the queue for breadth first search
        public int keyPlace = 0;
        public int value = 0;
        public int probe = 0;
        //Shows right parent and if does exist it can be used to change places
        public QueueData rightParent = null;

        public int mainValue;
    }
}
