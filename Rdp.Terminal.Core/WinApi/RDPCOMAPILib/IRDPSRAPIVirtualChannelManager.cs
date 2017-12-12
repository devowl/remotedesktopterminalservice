using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("0D11C661-5D0D-4EE4-89DF-2166AE1FDFED")]
    [TypeLibType(4160)]
    [ComImport]
    internal interface IRDPSRAPIVirtualChannelManager : IEnumerable
    {
        [DispId(-4), TypeLibFunc(1)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return:
            MarshalAs(UnmanagedType.CustomMarshaler,
                MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler")]
        IEnumerator GetEnumerator();

        [DispId(0)]
        IRDPSRAPIVirtualChannel this[[MarshalAs(UnmanagedType.Struct), In] object Item] {
            [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(109)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        IRDPSRAPIVirtualChannel CreateVirtualChannel(
            [MarshalAs(UnmanagedType.BStr), In] string bstrChannelName,
            [ComAliasName("RDPCOMAPILib.CHANNEL_PRIORITY"), In] CHANNEL_PRIORITY Priority,
            [In] uint ChannelFlags);
    }
}