using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("03CF46DB-CE45-4D36-86ED-ED28B74398BF")]
    [ComImport]
    internal class RDPSRAPIWindowClass : IRDPSRAPIWindow, RDPSRAPIWindow
    {
        [DispId(201)]
        public virtual extern int Id {
            [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(211)]
        public virtual extern RDPSRAPIApplication Application {
            [DispId(211), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(220)]
        public virtual extern bool Shared {
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(213)]
        public virtual extern string Name {
            [DispId(213), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(224)]
        public virtual extern uint Flags {
            [DispId(224), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(114)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Show();
    }
}