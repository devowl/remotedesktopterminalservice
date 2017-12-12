using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [CoClass(typeof(RDPSRAPIAttendeeDisconnectInfoClass))]
    [Guid("C187689F-447C-44A1-9C14-FFFBB3B7EC17")]
    [ComImport]
    internal interface RDPSRAPIAttendeeDisconnectInfo : IRDPSRAPIAttendeeDisconnectInfo
    {
    }
}