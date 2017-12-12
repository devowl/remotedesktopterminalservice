using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComSourceInterfaces("RDPCOMAPILib._IRDPSessionEvents")]
    [TypeLibType(2)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("9B78F0E6-3E05-4A5B-B2E8-E743A8956B65")]
    [ComImport]
    internal class RDPSessionClass : IRDPSRAPISharingSession, RDPSession, _IRDPSessionEvents_Event
    {
        [DispId(239)]
        public virtual extern int colordepth {
            [DispId(239), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set;
            [DispId(239), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(202)]
        public virtual extern RDPSRAPISessionProperties Properties {
            [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

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

        [DispId(100)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Open();

        [DispId(101)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Close();

        [DispId(112)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Pause();

        [DispId(113)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Resume();

        [DispId(117)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConnectToClient([MarshalAs(UnmanagedType.BStr), In] string bstrConnectionString);

        [DispId(102)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetDesktopSharedRect([In] int left, [In] int top, [In] int right, [In] int bottom);

        [DispId(103)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetDesktopSharedRect(out int pleft, out int ptop, out int pright, out int pbottom);

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