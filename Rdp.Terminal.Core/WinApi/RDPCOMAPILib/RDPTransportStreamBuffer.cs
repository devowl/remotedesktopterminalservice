using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[CoClass(typeof(RDPTransportStreamBufferClass))]
	[Guid("81C80290-5085-44B0-B460-F865C39CB4A9")]
	public interface RDPTransportStreamBuffer : IRDPSRAPITransportStreamBuffer
	{

	}
}