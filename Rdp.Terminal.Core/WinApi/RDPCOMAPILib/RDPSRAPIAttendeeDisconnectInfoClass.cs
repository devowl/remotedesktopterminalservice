using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("B47D7250-5BDB-405D-B487-CAAD9C56F4F8")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class RDPSRAPIAttendeeDisconnectInfoClass : IRDPSRAPIAttendeeDisconnectInfo, RDPSRAPIAttendeeDisconnectInfo
    {
        [DispId(0)]
        public virtual extern RDPSRAPIAttendee Attendee {
            [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(240)]
        [ComAliasName("RDPCOMAPILib.ATTENDEE_DISCONNECT_REASON")]
        public virtual extern ATTENDEE_DISCONNECT_REASON Reason {
            [DispId(240), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("RDPCOMAPILib.ATTENDEE_DISCONNECT_REASON")] get; }

        [DispId(241)]
        public virtual extern int Code {
            [DispId(241), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
    }
}