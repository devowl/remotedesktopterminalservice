using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("C116A484-4B25-4B9F-8A54-B934B06E57FA")]
    [ComImport]
    internal class RDPSRAPIApplicationClass : IRDPSRAPIApplication, RDPSRAPIApplication
    {
        [DispId(0)]
        public virtual extern RDPSRAPIWindowList Windows {
            [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(201)]
        public virtual extern int Id {
            [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(220)]
        public virtual extern bool Shared {
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(214)]
        public virtual extern string Name {
            [DispId(214), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(223)]
        public virtual extern uint Flags {
            [DispId(223), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
    }
}