using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComSourceInterfaces("RDPCOMAPILib._IRDPSessionEvents")]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("32BE5ED2-5C86-480F-A914-0FF8885A1B3F")]
    [TypeLibType(2)]
    [ComImport]
    internal class RDPViewerClass : IRDPSRAPIViewer, RDPViewer, _IRDPSessionEvents_Event
    {
        [DispId(203)]
        public virtual extern RDPSRAPIAttendeeManager Attendees {
            [DispId(203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(204)]
        public virtual extern RDPSRAPIInvitationManager Invitations {
            [DispId(204), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(215)]
        public virtual extern RDPSRAPIApplicationFilter ApplicationFilter {
            [DispId(215), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(206)]
        public virtual extern IRDPSRAPIVirtualChannelManager VirtualChannelManager {
            [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(238)]
        public virtual extern bool SmartSizing {
            [DispId(238), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set;
            [DispId(238), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(237)]
        public virtual extern string DisconnectedText {
            [DispId(237), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set;
            [DispId(237), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(202)]
        public virtual extern RDPSRAPISessionProperties Properties {
            [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        // [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        // public extern RDPViewerClass();

        [DispId(104)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Connect(
            [MarshalAs(UnmanagedType.BStr), In] string bstrConnectionString,
            [MarshalAs(UnmanagedType.BStr), In] string bstrName,
            [MarshalAs(UnmanagedType.BStr), In] string bstrPassword);

        [DispId(105)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Disconnect();

        [DispId(108)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RequestControl([ComAliasName("RDPCOMAPILib.CTRL_LEVEL"), In] CTRL_LEVEL CtrlLevel);

        [DispId(115)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RequestColorDepthChange([In] int Bpp);

        [DispId(116)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public virtual extern string StartReverseConnectListener(
            [MarshalAs(UnmanagedType.BStr), In] string bstrConnectionString,
            [MarshalAs(UnmanagedType.BStr), In] string bstrUserName,
            [MarshalAs(UnmanagedType.BStr), In] string bstrPassword);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnAttendeeConnected([In] _IRDPSessionEvents_OnAttendeeConnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnAttendeeConnected(
            [In] _IRDPSessionEvents_OnAttendeeConnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnAttendeeDisconnected(
            [In] _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnAttendeeDisconnected(
            [In] _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnAttendeeUpdate([In] _IRDPSessionEvents_OnAttendeeUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnAttendeeUpdate([In] _IRDPSessionEvents_OnAttendeeUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnConnectionEstablished(
            [In] _IRDPSessionEvents_OnConnectionEstablishedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnConnectionEstablished(
            [In] _IRDPSessionEvents_OnConnectionEstablishedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnConnectionFailed([In] _IRDPSessionEvents_OnConnectionFailedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnConnectionFailed(
            [In] _IRDPSessionEvents_OnConnectionFailedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnConnectionTerminated(
            [In] _IRDPSessionEvents_OnConnectionTerminatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnConnectionTerminated(
            [In] _IRDPSessionEvents_OnConnectionTerminatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnConnectionAuthenticated(
            [In] _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnConnectionAuthenticated(
            [In] _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnError([In] _IRDPSessionEvents_OnErrorEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnError([In] _IRDPSessionEvents_OnErrorEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnApplicationOpen([In] _IRDPSessionEvents_OnApplicationOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnApplicationOpen([In] _IRDPSessionEvents_OnApplicationOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnApplicationClose([In] _IRDPSessionEvents_OnApplicationCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnApplicationClose(
            [In] _IRDPSessionEvents_OnApplicationCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnApplicationUpdate([In] _IRDPSessionEvents_OnApplicationUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnApplicationUpdate(
            [In] _IRDPSessionEvents_OnApplicationUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnWindowOpen([In] _IRDPSessionEvents_OnWindowOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnWindowOpen([In] _IRDPSessionEvents_OnWindowOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnWindowClose([In] _IRDPSessionEvents_OnWindowCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnWindowClose([In] _IRDPSessionEvents_OnWindowCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnWindowUpdate([In] _IRDPSessionEvents_OnWindowUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnWindowUpdate([In] _IRDPSessionEvents_OnWindowUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnControlLevelChangeRequest(
            [In] _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnControlLevelChangeRequest(
            [In] _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnGraphicsStreamPaused(
            [In] _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnGraphicsStreamPaused(
            [In] _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnGraphicsStreamResumed(
            [In] _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnGraphicsStreamResumed(
            [In] _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnChannelDataReceived(
            [In] _IRDPSessionEvents_OnChannelDataReceivedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnChannelDataReceived(
            [In] _IRDPSessionEvents_OnChannelDataReceivedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnChannelDataSent([In] _IRDPSessionEvents_OnChannelDataSentEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnChannelDataSent([In] _IRDPSessionEvents_OnChannelDataSentEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnSharedRectChanged([In] _IRDPSessionEvents_OnSharedRectChangedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnSharedRectChanged(
            [In] _IRDPSessionEvents_OnSharedRectChangedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnFocusReleased([In] _IRDPSessionEvents_OnFocusReleasedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnFocusReleased([In] _IRDPSessionEvents_OnFocusReleasedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void add_OnSharedDesktopSettingsChanged(
            [In] _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void remove_OnSharedDesktopSettingsChanged(
            [In] _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler obj0);
    }
}