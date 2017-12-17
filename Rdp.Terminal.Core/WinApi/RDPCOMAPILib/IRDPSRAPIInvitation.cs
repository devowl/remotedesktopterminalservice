using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(4160)]
    [Guid("4FAC1D43-FC51-45BB-B1B4-2B53AA562FA3")]
    [ComImport]
    public interface IRDPSRAPIInvitation
    {
        [DispId(232)]
        string ConnectionString {
            [DispId(232), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(233)]
        string GroupName {
            [DispId(233), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(234)]
        string Password {
            [DispId(234), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(235)]
        int AttendeeLimit {
            [DispId(235), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(235), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(236)]
        bool Revoked {
            [DispId(236), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(236), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
    }
}