using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnConnectionTerminatedEventHandler(
        [In] int discReason,
        [In] int ExtendedInfo);
}