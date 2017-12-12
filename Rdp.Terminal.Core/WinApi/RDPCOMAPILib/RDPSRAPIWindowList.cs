using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("8A05CE44-715A-4116-A189-A118F30A07BD")]
    [CoClass(typeof(RDPSRAPIWindowListClass))]
    [ComImport]
    public interface RDPSRAPIWindowList : IRDPSRAPIWindowList
    {
    }
}