using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(4160)]
    [Guid("EC0671B3-1B78-4B80-A464-9132247543E3")]
    [ComImport]
    public interface IRDPSRAPIAttendee
    {
        [DispId(201)]
        int Id { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
        }

        [DispId(243)]
        string RemoteName {
            [DispId(243), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(242)]
        [ComAliasName("RDPCOMAPILib.CTRL_LEVEL")]
        CTRL_LEVEL ControlLevel {
            [DispId(242), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("RDPCOMAPILib.CTRL_LEVEL")] get;
            [DispId(242), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("RDPCOMAPILib.CTRL_LEVEL"), In] set; }

        [DispId(205)]
        RDPSRAPIInvitation Invitation {
            [DispId(205), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(106)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void TerminateConnection();

        [DispId(230)]
        int Flags {
            [DispId(230), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(231)]
        object ConnectivityInfo {
            [DispId(231), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; }
    }
}