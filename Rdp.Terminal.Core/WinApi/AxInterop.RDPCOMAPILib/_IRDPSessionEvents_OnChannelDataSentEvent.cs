namespace AxRDPCOMAPILib
{
    internal class _IRDPSessionEvents_OnChannelDataSentEvent
    {
        public object pChannel;

        public int lAttendeeId;

        public int bytesSent;

        public _IRDPSessionEvents_OnChannelDataSentEvent(object pChannel, int lAttendeeId, int bytesSent)
        {
            this.pChannel = pChannel;
            this.lAttendeeId = lAttendeeId;
            this.bytesSent = bytesSent;
        }
    }
}