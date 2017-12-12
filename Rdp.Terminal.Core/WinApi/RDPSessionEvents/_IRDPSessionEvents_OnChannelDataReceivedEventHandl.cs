using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnChannelDataReceivedEventHandler(
        [MarshalAs(UnmanagedType.IUnknown), In] object pChannel,
        [In] int lAttendeeId,
        [MarshalAs(UnmanagedType.BStr), In] string bstrData);
}