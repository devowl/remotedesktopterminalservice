using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[Guid("36CFA065-43BB-4EF7-AED7-9B88A5053036")]
	[InterfaceType(1)]
	public interface IRDPSRAPITransportStream
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RDPTransportStreamBuffer AllocBuffer([In] int maxPayload);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FreeBuffer([In] RDPTransportStreamBuffer pBuffer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([In] RDPTransportStreamEvents pCallbacks);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadBuffer([In] RDPTransportStreamBuffer pBuffer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteBuffer([In] RDPTransportStreamBuffer pBuffer);
	}
}