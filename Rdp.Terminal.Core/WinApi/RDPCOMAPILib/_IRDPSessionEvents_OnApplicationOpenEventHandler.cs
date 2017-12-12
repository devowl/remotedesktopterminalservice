using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnApplicationOpenEventHandler(
        [MarshalAs(UnmanagedType.IDispatch), In] object pApplication);
}