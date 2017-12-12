using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("53D9C9DB-75AB-4271-948A-4C4EB36A8F2B")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class RDPSRAPIInvitationManagerClass : IRDPSRAPIInvitationManager, RDPSRAPIInvitationManager, IEnumerable
    {
        [DispId(244)]
        public virtual extern int Count {
            [DispId(244), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(0)]
        public virtual extern RDPSRAPIInvitation this[[MarshalAs(UnmanagedType.Struct), In] object Item] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [TypeLibFunc(1)]
        [DispId(-4)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        public virtual extern IEnumerator GetEnumerator();

        [DispId(107)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public virtual extern RDPSRAPIInvitation CreateInvitation(
            [MarshalAs(UnmanagedType.BStr), In] string bstrAuthString,
            [MarshalAs(UnmanagedType.BStr), In] string bstrGroupName,
            [MarshalAs(UnmanagedType.BStr), In] string bstrPassword,
            [In] int AttendeeLimit);
    }
}