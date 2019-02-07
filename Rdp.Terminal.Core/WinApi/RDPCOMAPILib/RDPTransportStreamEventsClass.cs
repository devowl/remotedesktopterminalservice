using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("31E3AB20-5350-483F-9DC6-6748665EFDEB")]
	public class RDPTransportStreamEventsClass : IRDPSRAPITransportStreamEvents, RDPTransportStreamEvents
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		internal extern RDPTransportStreamEventsClass();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		public virtual extern void OnReadCompleted([In] RDPTransportStreamBuffer pBuffer);

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		public virtual extern void OnStreamClosed([In] int hrReason);

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		public virtual extern void OnWriteCompleted([In] RDPTransportStreamBuffer pBuffer);
	}
}