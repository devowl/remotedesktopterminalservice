using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("D4B4AEB3-22DC-4837-B3B6-42EA2517849A")]
    [CoClass(typeof(RDPSRAPIApplicationListClass))]
    [ComImport]
    public interface RDPSRAPIApplicationList : IRDPSRAPIApplicationList
    {
    }
}