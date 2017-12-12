using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("41E7A09D-EB7A-436E-935D-780CA2628324")]
    [CoClass(typeof(RDPSRAPIApplicationClass))]
    [ComImport]
    public interface RDPSRAPIApplication : IRDPSRAPIApplication
    {
    }
}