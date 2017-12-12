using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("F74049A4-3D06-4028-8193-0A8C29BC2452")]
    [TypeLibType(4160)]
    [ComImport]
    internal interface IRDPSRAPITcpConnectionInfo
    {
        [DispId(225)]
        int Protocol {
            [DispId(225), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(226)]
        int LocalPort {
            [DispId(226), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(227)]
        string LocalIP {
            [DispId(227), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(228)]
        int PeerPort {
            [DispId(228), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(229)]
        string PeerIP {
            [DispId(229), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }
    }
}