namespace AxRDPCOMAPILib
{
    internal class _IRDPSessionEvents_OnChannelDataReceivedEvent
    {
        public object pChannel;

        public int lAttendeeId;

        public string bstrData;

        public _IRDPSessionEvents_OnChannelDataReceivedEvent(object pChannel, int lAttendeeId, string bstrData)
        {
            this.pChannel = pChannel;
            this.lAttendeeId = lAttendeeId;
            this.bstrData = bstrData;
        }
    }
}