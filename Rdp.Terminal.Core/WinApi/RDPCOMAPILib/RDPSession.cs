using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [CoClass(typeof(RDPSessionClass))]
    [Guid("EEB20886-E470-4CF6-842B-2739C0EC5CFB")]
    [ComImport]
    internal interface RDPSession : IRDPSRAPISharingSession, _IRDPSessionEvents_Event
    {
    }
}