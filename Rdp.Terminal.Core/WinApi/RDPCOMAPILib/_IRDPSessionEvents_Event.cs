using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ComVisible(false)]
    [TypeLibType(TypeLibTypeFlags.FHidden)]
    [ComEventInterface(typeof(_IRDPSessionEvents), typeof(_IRDPSessionEvents_EventProvider))]
    internal interface _IRDPSessionEvents_Event
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnAttendeeConnected([In] _IRDPSessionEvents_OnAttendeeConnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnAttendeeConnected([In] _IRDPSessionEvents_OnAttendeeConnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnAttendeeDisconnected([In] _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnAttendeeDisconnected([In] _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnAttendeeUpdate([In] _IRDPSessionEvents_OnAttendeeUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnAttendeeUpdate([In] _IRDPSessionEvents_OnAttendeeUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnConnectionEstablished([In] _IRDPSessionEvents_OnConnectionEstablishedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnConnectionEstablished([In] _IRDPSessionEvents_OnConnectionEstablishedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnConnectionFailed([In] _IRDPSessionEvents_OnConnectionFailedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnConnectionFailed([In] _IRDPSessionEvents_OnConnectionFailedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnConnectionTerminated([In] _IRDPSessionEvents_OnConnectionTerminatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnConnectionTerminated([In] _IRDPSessionEvents_OnConnectionTerminatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnConnectionAuthenticated([In] _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnConnectionAuthenticated([In] _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnError([In] _IRDPSessionEvents_OnErrorEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnError([In] _IRDPSessionEvents_OnErrorEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnApplicationOpen([In] _IRDPSessionEvents_OnApplicationOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnApplicationOpen([In] _IRDPSessionEvents_OnApplicationOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnApplicationClose([In] _IRDPSessionEvents_OnApplicationCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnApplicationClose([In] _IRDPSessionEvents_OnApplicationCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnApplicationUpdate([In] _IRDPSessionEvents_OnApplicationUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnApplicationUpdate([In] _IRDPSessionEvents_OnApplicationUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnWindowOpen([In] _IRDPSessionEvents_OnWindowOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnWindowOpen([In] _IRDPSessionEvents_OnWindowOpenEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnWindowClose([In] _IRDPSessionEvents_OnWindowCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnWindowClose([In] _IRDPSessionEvents_OnWindowCloseEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnWindowUpdate([In] _IRDPSessionEvents_OnWindowUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnWindowUpdate([In] _IRDPSessionEvents_OnWindowUpdateEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnControlLevelChangeRequest([In] _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnControlLevelChangeRequest([In] _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnGraphicsStreamPaused([In] _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnGraphicsStreamPaused([In] _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnGraphicsStreamResumed([In] _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnGraphicsStreamResumed([In] _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnChannelDataReceived([In] _IRDPSessionEvents_OnChannelDataReceivedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnChannelDataReceived([In] _IRDPSessionEvents_OnChannelDataReceivedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnChannelDataSent([In] _IRDPSessionEvents_OnChannelDataSentEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnChannelDataSent([In] _IRDPSessionEvents_OnChannelDataSentEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnSharedRectChanged([In] _IRDPSessionEvents_OnSharedRectChangedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnSharedRectChanged([In] _IRDPSessionEvents_OnSharedRectChangedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnFocusReleased([In] _IRDPSessionEvents_OnFocusReleasedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnFocusReleased([In] _IRDPSessionEvents_OnFocusReleasedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_OnSharedDesktopSettingsChanged([In] _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler obj0);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_OnSharedDesktopSettingsChanged(
            [In] _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler obj0);
    }
}