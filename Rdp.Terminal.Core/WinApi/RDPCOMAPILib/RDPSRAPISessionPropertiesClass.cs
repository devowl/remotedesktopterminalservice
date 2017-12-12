using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("DD7594FF-EA2A-4C06-8FDF-132DE48B6510")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class RDPSRAPISessionPropertiesClass : IRDPSRAPISessionProperties, RDPSRAPISessionProperties
    {
        [DispId(0)]
        [IndexerName("Property")]
        public virtual extern object this[[MarshalAs(UnmanagedType.BStr), In] string PropertyName] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get;
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }
    }
}