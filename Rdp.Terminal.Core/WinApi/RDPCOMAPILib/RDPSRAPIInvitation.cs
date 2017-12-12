using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("4FAC1D43-FC51-45BB-B1B4-2B53AA562FA3")]
    [CoClass(typeof(RDPSRAPIInvitationClass))]
    [ComImport]
    public interface RDPSRAPIInvitation : IRDPSRAPIInvitation
    {
    }
}