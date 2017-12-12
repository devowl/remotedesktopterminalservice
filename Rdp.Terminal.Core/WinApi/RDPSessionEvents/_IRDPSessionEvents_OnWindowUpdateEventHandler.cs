using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnWindowUpdateEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pWindow);
}