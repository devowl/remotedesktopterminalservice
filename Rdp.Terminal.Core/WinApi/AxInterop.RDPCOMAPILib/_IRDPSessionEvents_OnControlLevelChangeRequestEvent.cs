using RDPCOMAPILib;

namespace AxRDPCOMAPILib
{
    internal class _IRDPSessionEvents_OnControlLevelChangeRequestEvent
    {
        public object pAttendee;

        public CTRL_LEVEL requestedLevel;

        public _IRDPSessionEvents_OnControlLevelChangeRequestEvent(object pAttendee, CTRL_LEVEL requestedLevel)
        {
            this.pAttendee = pAttendee;
            this.requestedLevel = requestedLevel;
        }
    }
}