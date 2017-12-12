using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("339B24F2-9BC0-4F16-9AAC-F165433D13D4")]
    [CoClass(typeof(RDPSRAPISessionPropertiesClass))]
    [ComImport]
    internal interface RDPSRAPISessionProperties : IRDPSRAPISessionProperties
    {
    }
}