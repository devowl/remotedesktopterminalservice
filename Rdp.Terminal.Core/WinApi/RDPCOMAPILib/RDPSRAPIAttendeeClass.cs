using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("74F93BB5-755F-488E-8A29-2390108AEF55")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class RDPSRAPIAttendeeClass : IRDPSRAPIAttendee, RDPSRAPIAttendee
    {
        [DispId(201)]
        public virtual extern int Id {
            [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(243)]
        public virtual extern string RemoteName {
            [DispId(243), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(242)]
        [ComAliasName("RDPCOMAPILib.CTRL_LEVEL")]
        public virtual extern CTRL_LEVEL ControlLevel {
            [DispId(242), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("RDPCOMAPILib.CTRL_LEVEL")] get;
            [DispId(242), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("RDPCOMAPILib.CTRL_LEVEL"), In] set; }

        [DispId(205)]
        public virtual extern RDPSRAPIInvitation Invitation {
            [DispId(205), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(230)]
        public virtual extern int Flags {
            [DispId(230), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(231)]
        public virtual extern object ConnectivityInfo {
            [DispId(231), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; }

        [DispId(106)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void TerminateConnection();
    }
}