using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(4160)]
    [Guid("41E7A09D-EB7A-436E-935D-780CA2628324")]
    [ComImport]
    public interface IRDPSRAPIApplication
    {
        [DispId(0)]
        RDPSRAPIWindowList Windows {
            [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(201)]
        int Id { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
        }

        [DispId(220)]
        bool Shared {
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(214)]
        string Name {
            [DispId(214), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(223)]
        uint Flags {
            [DispId(223), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
    }
}