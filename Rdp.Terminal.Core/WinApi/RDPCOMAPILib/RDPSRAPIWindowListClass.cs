using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("9C21E2B8-5DD4-42CC-81BA-1C099852E6FA")]
    [ComImport]
    internal class RDPSRAPIWindowListClass : IRDPSRAPIWindowList, RDPSRAPIWindowList, IEnumerable
    {
        [DispId(0)]
        public virtual extern RDPSRAPIWindow this[[In] int Item] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [TypeLibFunc(1)]
        [DispId(-4)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        public virtual extern IEnumerator GetEnumerator();
    }
}