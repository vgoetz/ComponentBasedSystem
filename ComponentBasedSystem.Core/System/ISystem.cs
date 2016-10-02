using System;
using System.Collections.Generic;
using ComponentBasedSystem.Core.Nodes;

namespace ComponentBasedSystem.Core.System {

    interface ISystem {
        void Update(int time, List<Tuple<long, INode>> nodes);
    }
}
