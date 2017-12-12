using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("D4B4AEB3-22DC-4837-B3B6-42EA2517849A")]
    [TypeLibType(4160)]
    [ComImport]
    public interface IRDPSRAPIApplicationList : IEnumerable
    {
        [DispId(-4), TypeLibFunc(1)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        IEnumerator GetEnumerator();

        [DispId(0)]
        RDPSRAPIApplication this[[In] int Item] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
    }
}