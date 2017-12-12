using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(4160)]
    [Guid("4722B049-92C3-4C2D-8A65-F7348F644DCF")]
    [ComImport]
    internal interface IRDPSRAPIInvitationManager : IEnumerable
    {
        [DispId(-4), TypeLibFunc(1)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        IEnumerator GetEnumerator();

        [DispId(0)]
        RDPSRAPIInvitation this[[MarshalAs(UnmanagedType.Struct), In] object Item] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(244)]
        int Count {
            [DispId(244), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(107)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        RDPSRAPIInvitation CreateInvitation(
            [MarshalAs(UnmanagedType.BStr), In] string bstrAuthString,
            [MarshalAs(UnmanagedType.BStr), In] string bstrGroupName,
            [MarshalAs(UnmanagedType.BStr), In] string bstrPassword,
            [In] int AttendeeLimit);
    }
}