using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("D20F10CA-6637-4F06-B1D5-277EA7E5160D")]
    [TypeLibType(4160)]
    [ComImport]
    internal interface IRDPSRAPIApplicationFilter
    {
        [DispId(217)]
        RDPSRAPIApplicationList Applications {
            [DispId(217), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(216)]
        RDPSRAPIWindowList Windows {
            [DispId(216), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(219)]
        bool Enabled {
            [DispId(219), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(219), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
    }
}