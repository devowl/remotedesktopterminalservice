using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[ComConversionLoss]
	[Guid("81C80290-5085-44B0-B460-F865C39CB4A9")]
	[InterfaceType(1)]
	public interface IRDPSRAPITransportStreamBuffer
	{
		[DispId(560)]
		object Context
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(561)]
		int Flags
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(559)]
		int PayloadOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(558)]
		int PayloadSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			set;
		}

		[DispId(555)]
		IntPtr Storage
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
		}

		[DispId(562)]
		int StorageSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
		}
	}
}