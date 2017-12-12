using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RDPCOMAPILib;

namespace Rdp.Terminal.Core.Server
{
    /// <summary>
    /// Application process callback.
    /// </summary>
    /// <param name="application">
    /// Groups the sharable windows within a process. Each application object contains 
    /// a list of window objects. If an application object is shared, all its windows are shared.
    /// </param>
    public delegate void ApplicationFilterCallback(IRDPSRAPIApplication application);
}
