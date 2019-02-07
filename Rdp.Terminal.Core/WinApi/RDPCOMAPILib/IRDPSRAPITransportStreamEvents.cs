using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[Guid("EA81C254-F5AF-4E40-982E-3E63BB595276")]
	[InterfaceType(1)]
	public interface IRDPSRAPITransportStreamEvents
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnReadCompleted([In] RDPTransportStreamBuffer pBuffer);

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStreamClosed([In] int hrReason);

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnWriteCompleted([In] RDPTransportStreamBuffer pBuffer);
	}
}