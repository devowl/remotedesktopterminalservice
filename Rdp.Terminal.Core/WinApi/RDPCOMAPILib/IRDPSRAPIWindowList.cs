using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(4160)]
    [Guid("8A05CE44-715A-4116-A189-A118F30A07BD")]
    [ComImport]
    public interface IRDPSRAPIWindowList : IEnumerable
    {
        [DispId(-4)]
        [TypeLibFunc(1)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        new IEnumerator GetEnumerator();

        [DispId(0)]
        RDPSRAPIWindow this[[In] int Item] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
    }
}