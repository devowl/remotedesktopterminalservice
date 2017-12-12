using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("BA3A37E8-33DA-4749-8DA0-07FA34DA7944")]
    [CoClass(typeof(RDPSRAPIAttendeeManagerClass))]
    [ComImport]
    internal interface RDPSRAPIAttendeeManager : IRDPSRAPIAttendeeManager
    {
    }
}