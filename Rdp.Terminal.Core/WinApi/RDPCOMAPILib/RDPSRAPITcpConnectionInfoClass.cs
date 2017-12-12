using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("BE49DB3F-EBB6-4278-8CE0-D5455833EAEE")]
    [ComImport]
    internal class RDPSRAPITcpConnectionInfoClass : IRDPSRAPITcpConnectionInfo, RDPSRAPITcpConnectionInfo
    {
        [DispId(225)]
        public virtual extern int Protocol {
            [DispId(225), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(226)]
        public virtual extern int LocalPort {
            [DispId(226), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(227)]
        public virtual extern string LocalIP {
            [DispId(227), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(228)]
        public virtual extern int PeerPort {
            [DispId(228), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(229)]
        public virtual extern string PeerIP {
            [DispId(229), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }
    }
}