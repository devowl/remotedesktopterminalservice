using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("4722B049-92C3-4C2D-8A65-F7348F644DCF")]
    [CoClass(typeof(RDPSRAPIInvitationManagerClass))]
    [ComImport]
    internal interface RDPSRAPIInvitationManager : IRDPSRAPIInvitationManager
    {
    }
}