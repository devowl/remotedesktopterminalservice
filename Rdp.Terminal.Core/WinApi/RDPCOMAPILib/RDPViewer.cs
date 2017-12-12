using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [Guid("C6BFCD38-8CE9-404D-8AE8-F31D00C65CB5")]
    [CoClass(typeof(RDPViewerClass))]
    [ComImport]
    internal interface RDPViewer : IRDPSRAPIViewer, _IRDPSessionEvents_Event
    {
    }
}