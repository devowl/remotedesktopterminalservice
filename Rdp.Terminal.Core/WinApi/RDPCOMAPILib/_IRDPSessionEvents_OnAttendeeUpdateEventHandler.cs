using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnAttendeeUpdateEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pAttendee);
}