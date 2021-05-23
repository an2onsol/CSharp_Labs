using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLab {
    interface IOverhaul {
        int LastOverhaul { get; set; }
        bool NeedForRepair();
    }
}
