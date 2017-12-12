using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnSharedRectChangedEventHandler(
        [In] int left,
        [In] int top,
        [In] int right,
        [In] int bottom);
}