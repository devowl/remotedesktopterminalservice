using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("339B24F2-9BC0-4F16-9AAC-F165433D13D4")]
    [TypeLibType(4160)]
    [ComImport]
    internal interface IRDPSRAPISessionProperties
    {
        [DispId(0)]
        [IndexerName("Property")]
        object this[[MarshalAs(UnmanagedType.BStr), In] string PropertyName] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get;
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }
    }
}