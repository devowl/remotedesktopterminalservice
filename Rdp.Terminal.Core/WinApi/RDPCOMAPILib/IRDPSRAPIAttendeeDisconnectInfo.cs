using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("C187689F-447C-44A1-9C14-FFFBB3B7EC17")]
    [TypeLibType(4160)]
    [ComImport]
    internal interface IRDPSRAPIAttendeeDisconnectInfo
    {
        [DispId(0)]
        RDPSRAPIAttendee Attendee {
            [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [ComAliasName("RDPCOMAPILib.ATTENDEE_DISCONNECT_REASON")]
        [DispId(240)]
        ATTENDEE_DISCONNECT_REASON Reason {
            [DispId(240), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("RDPCOMAPILib.ATTENDEE_DISCONNECT_REASON")] get; }

        [DispId(241)]
        int Code {
            [DispId(241), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
    }
}