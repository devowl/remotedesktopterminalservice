using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("D20F10CA-6637-4F06-B1D5-277EA7E5160D")]
    [CoClass(typeof(RDPSRAPIApplicationFilterClass))]
    [ComImport]
    internal interface RDPSRAPIApplicationFilter : IRDPSRAPIApplicationFilter
    {
    }
}