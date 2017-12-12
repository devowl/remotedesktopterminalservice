using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [CoClass(typeof(RDPSRAPITcpConnectionInfoClass))]
    [Guid("F74049A4-3D06-4028-8193-0A8C29BC2452")]
    [ComImport]
    internal interface RDPSRAPITcpConnectionInfo : IRDPSRAPITcpConnectionInfo
    {
    }
}