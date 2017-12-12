using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pDisconnectInfo);
}