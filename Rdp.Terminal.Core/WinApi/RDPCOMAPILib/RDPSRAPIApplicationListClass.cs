using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("9E31C815-7433-4876-97FB-ED59FE2BAA22")]
    [ComImport]
    internal class RDPSRAPIApplicationListClass : IRDPSRAPIApplicationList, RDPSRAPIApplicationList, IEnumerable
    {
        [DispId(0)]
        public virtual extern RDPSRAPIApplication this[[In] int Item] {
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