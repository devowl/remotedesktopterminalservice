using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("05E12F95-28B3-4C9A-8780-D0248574A1E0")]
    [TypeLibType(4160)]
    [ComImport]
    internal interface IRDPSRAPIVirtualChannel
    {
        [DispId(110)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SendData(
            [MarshalAs(UnmanagedType.BStr), In] string bstrData,
            [In] int lAttendeeId,
            [In] uint ChannelSendFlags);

        [DispId(111)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetAccess(
            [In] int lAttendeeId,
            [ComAliasName("RDPCOMAPILib.CHANNEL_ACCESS_ENUM"), In] CHANNEL_ACCESS_ENUM AccessType);

        [DispId(207)]
        string Name {
            [DispId(207), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(208)]
        int Flags {
            [DispId(208), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [ComAliasName("RDPCOMAPILib.CHANNEL_PRIORITY")]
        [DispId(209)]
        CHANNEL_PRIORITY Priority {
            [DispId(209), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("RDPCOMAPILib.CHANNEL_PRIORITY")] get; }
    }
}