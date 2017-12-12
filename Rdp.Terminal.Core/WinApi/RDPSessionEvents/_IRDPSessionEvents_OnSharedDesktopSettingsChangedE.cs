using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    public delegate void _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler(
        [In] int width,
        [In] int height,
        [In] int colordepth);
}