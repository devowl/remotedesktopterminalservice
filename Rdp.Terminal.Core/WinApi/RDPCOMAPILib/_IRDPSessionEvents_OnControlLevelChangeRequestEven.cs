using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pAttendee,
        [ComAliasName("RDPCOMAPILib.CTRL_LEVEL"), In] CTRL_LEVEL RequestedLevel);
}