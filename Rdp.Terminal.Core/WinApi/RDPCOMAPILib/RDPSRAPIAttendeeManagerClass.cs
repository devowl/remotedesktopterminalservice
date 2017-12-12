using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("D7B13A01-F7D4-42A6-8595-12FC8C24E851")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class RDPSRAPIAttendeeManagerClass : IRDPSRAPIAttendeeManager, RDPSRAPIAttendeeManager, IEnumerable
    {
        [DispId(0)]
        public virtual extern RDPSRAPIAttendee this[[In] int Id] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(-4)]
        [TypeLibFunc(1)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        public virtual extern IEnumerator GetEnumerator();
    }
}