using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnWindowOpenEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pWindow);
}