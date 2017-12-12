using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(4160)]
    [Guid("C6BFCD38-8CE9-404D-8AE8-F31D00C65CB5")]
    [ComImport]
    internal interface IRDPSRAPIViewer
    {
        [DispId(104)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Connect(
            [MarshalAs(UnmanagedType.BStr), In] string bstrConnectionString,
            [MarshalAs(UnmanagedType.BStr), In] string bstrName,
            [MarshalAs(UnmanagedType.BStr), In] string bstrPassword);

        [DispId(105)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Disconnect();

        [DispId(203)]
        RDPSRAPIAttendeeManager Attendees {
            [DispId(203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(204)]
        RDPSRAPIInvitationManager Invitations {
            [DispId(204), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(215)]
        RDPSRAPIApplicationFilter ApplicationFilter {
            [DispId(215), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(206)]
        IRDPSRAPIVirtualChannelManager VirtualChannelManager {
            [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(238)]
        bool SmartSizing {
            [DispId(238), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set;
            [DispId(238), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(108)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RequestControl([ComAliasName("RDPCOMAPILib.CTRL_LEVEL"), In] CTRL_LEVEL CtrlLevel);

        [DispId(237)]
        string DisconnectedText {
            [DispId(237), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set;
            [DispId(237), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(115)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RequestColorDepthChange([In] int Bpp);

        [DispId(202)]
        RDPSRAPISessionProperties Properties {
            [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(116)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string StartReverseConnectListener(
            [MarshalAs(UnmanagedType.BStr), In] string bstrConnectionString,
            [MarshalAs(UnmanagedType.BStr), In] string bstrUserName,
            [MarshalAs(UnmanagedType.BStr), In] string bstrPassword);
    }
}