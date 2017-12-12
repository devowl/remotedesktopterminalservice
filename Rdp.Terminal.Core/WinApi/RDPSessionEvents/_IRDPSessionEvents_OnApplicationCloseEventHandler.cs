using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnApplicationCloseEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pApplication);
}