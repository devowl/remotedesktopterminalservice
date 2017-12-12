using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnErrorEventHandler([MarshalAs(UnmanagedType.Struct), In] object ErrorInfo);
}