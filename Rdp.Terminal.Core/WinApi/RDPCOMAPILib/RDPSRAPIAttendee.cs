using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("EC0671B3-1B78-4B80-A464-9132247543E3")]
    [CoClass(typeof(RDPSRAPIAttendeeClass))]
    [ComImport]
    internal interface RDPSRAPIAttendee : IRDPSRAPIAttendee
    {
    }
}