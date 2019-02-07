using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
	[CoClass(typeof(RDPTransportStreamEventsClass))]
	[Guid("EA81C254-F5AF-4E40-982E-3E63BB595276")]
	public interface RDPTransportStreamEvents : IRDPSRAPITransportStreamEvents
	{

	}
}