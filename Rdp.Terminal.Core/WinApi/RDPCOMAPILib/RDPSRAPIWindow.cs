using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [CoClass(typeof(RDPSRAPIWindowClass))]
    [Guid("BEAFE0F9-C77B-4933-BA9F-A24CDDCC27CF")]
    [ComImport]
    public interface RDPSRAPIWindow : IRDPSRAPIWindow
    {
    }
}