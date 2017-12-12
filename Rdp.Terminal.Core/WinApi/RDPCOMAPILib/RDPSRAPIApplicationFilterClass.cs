using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("E35ACE89-C7E8-427E-A4F9-B9DA072826BD")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class RDPSRAPIApplicationFilterClass : IRDPSRAPIApplicationFilter, RDPSRAPIApplicationFilter
    {
        [DispId(217)]
        public virtual extern RDPSRAPIApplicationList Applications {
            [DispId(217), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(216)]
        public virtual extern RDPSRAPIWindowList Windows {
            [DispId(216), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(219)]
        public virtual extern bool Enabled {
            [DispId(219), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(219), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
    }
}