using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("BEAFE0F9-C77B-4933-BA9F-A24CDDCC27CF")]
    [TypeLibType(4160)]
    [ComImport]
    public interface IRDPSRAPIWindow
    {
        [DispId(201)]
        int Id { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
        }

        [DispId(211)]
        RDPSRAPIApplication Application {
            [DispId(211), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(220)]
        bool Shared {
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get;
            [DispId(220), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(213)]
        string Name {
            [DispId(213), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        [DispId(114)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Show();

        [DispId(224)]
        uint Flags {
            [DispId(224), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
    }
}