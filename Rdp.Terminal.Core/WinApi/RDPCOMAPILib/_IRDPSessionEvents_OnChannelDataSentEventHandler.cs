using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnChannelDataSentEventHandler(
        [MarshalAs(UnmanagedType.IUnknown), In] object pChannel,
        [In] int lAttendeeId,
        [In] int BytesSent);
}