using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnAttendeeConnectedEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pAttendee);
}