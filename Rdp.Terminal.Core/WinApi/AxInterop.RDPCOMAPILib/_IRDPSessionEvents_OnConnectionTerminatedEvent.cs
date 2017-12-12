namespace AxRDPCOMAPILib
{
    internal class _IRDPSessionEvents_OnConnectionTerminatedEvent
    {
        public int discReason;

        public int extendedInfo;

        public _IRDPSessionEvents_OnConnectionTerminatedEvent(int discReason, int extendedInfo)
        {
            this.discReason = discReason;
            this.extendedInfo = extendedInfo;
        }
    }
}