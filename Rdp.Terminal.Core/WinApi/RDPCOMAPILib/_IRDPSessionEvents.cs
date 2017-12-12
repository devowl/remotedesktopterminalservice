using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("98A97042-6698-40E9-8EFD-B3200990004B")]
    [TypeLibType(4096)]
    [InterfaceType(2)]
    [ComImport]
    internal interface _IRDPSessionEvents
    {
        [DispId(301)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnAttendeeConnected([MarshalAs(UnmanagedType.IDispatch), In] object pAttendee);

        [DispId(302)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnAttendeeDisconnected([MarshalAs(UnmanagedType.IDispatch), In] object pDisconnectInfo);

        [DispId(303)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnAttendeeUpdate([MarshalAs(UnmanagedType.IDispatch), In] object pAttendee);

        [DispId(305)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnConnectionEstablished();

        [DispId(308)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnConnectionFailed();

        [DispId(306)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnConnectionTerminated([In] int discReason, [In] int ExtendedInfo);

        [DispId(307)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnConnectionAuthenticated();

        [DispId(304)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnError([MarshalAs(UnmanagedType.Struct), In] object ErrorInfo);

        [DispId(316)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnApplicationOpen([MarshalAs(UnmanagedType.IDispatch), In] object pApplication);

        [DispId(317)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnApplicationClose([MarshalAs(UnmanagedType.IDispatch), In] object pApplication);

        [DispId(318)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnApplicationUpdate([MarshalAs(UnmanagedType.IDispatch), In] object pApplication);

        [DispId(319)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnWindowOpen([MarshalAs(UnmanagedType.IDispatch), In] object pWindow);

        [DispId(320)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnWindowClose([MarshalAs(UnmanagedType.IDispatch), In] object pWindow);

        [DispId(321)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnWindowUpdate([MarshalAs(UnmanagedType.IDispatch), In] object pWindow);

        [DispId(309)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnControlLevelChangeRequest(
            [MarshalAs(UnmanagedType.IDispatch), In] object pAttendee,
            [ComAliasName("RDPCOMAPILib.CTRL_LEVEL"), In] CTRL_LEVEL RequestedLevel);

        [DispId(310)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnGraphicsStreamPaused();

        [DispId(311)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnGraphicsStreamResumed();

        [DispId(314)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnChannelDataReceived(
            [MarshalAs(UnmanagedType.IUnknown), In] object pChannel,
            [In] int lAttendeeId,
            [MarshalAs(UnmanagedType.BStr), In] string bstrData);

        [DispId(315)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnChannelDataSent(
            [MarshalAs(UnmanagedType.IUnknown), In] object pChannel,
            [In] int lAttendeeId,
            [In] int BytesSent);

        [DispId(323)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnSharedRectChanged([In] int left, [In] int top, [In] int right, [In] int bottom);

        [DispId(324)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnFocusReleased([In] int iDirection);

        [DispId(325)]
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
            MethodCodeType = MethodCodeType.Runtime)]
        void OnSharedDesktopSettingsChanged([In] int width, [In] int height, [In] int colordepth);
    }
}