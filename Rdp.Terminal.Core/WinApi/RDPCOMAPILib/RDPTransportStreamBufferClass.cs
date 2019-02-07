using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[ClassInterface(ClassInterfaceType.None)]
	[ComConversionLoss]
	[Guid("8D4A1C69-F17F-4549-A699-761C6E6B5C0A")]
	public class RDPTransportStreamBufferClass : IRDPSRAPITransportStreamBuffer, RDPTransportStreamBuffer
	{
		[DispId(560)]
		public virtual object Context
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(561)]
		public virtual int Flags
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(559)]
		public virtual int PayloadOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(558)]
		public virtual int PayloadSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(555)]
		public virtual IntPtr Storage
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
		}

		[DispId(562)]
		public virtual int StorageSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		internal extern RDPTransportStreamBufferClass();
	}
}