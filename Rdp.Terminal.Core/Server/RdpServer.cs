using RDPCOMAPILib;

namespace Rdp.Terminal.Core.Server
{
    /// <summary>
    /// RDP server hosting provider.
    /// </summary>
    public class RdpServer
    {
        private RDPSession _rdpSession;
        
        /// <summary>
        /// Start server hosting.
        /// </summary>
        public void Open()
        {
            if (_rdpSession == null)
            {
                _rdpSession = new RDPSession { colordepth = 8 };
                _rdpSession.add_OnAttendeeConnected(OnAttendeeConnected);
                _rdpSession.Open();
            }
            else
            {
                _rdpSession.Resume();
            }
        }

        /// <summary>
        /// Create remote invitation.
        /// </summary>
        /// <param name="groupName">
        /// The name of the group. The string must be unique for the session. Applications typically 
        /// use the group name to separate attendees into groups that can be granted different authorization levels.
        /// </param>
        /// <param name="passowrd">
        /// Password to use for authentication. The password is limited to 255 characters. You must provide the password 
        /// to the viewer out-of-band from the ticket.
        /// </param>
        /// <returns>Client connection string.</returns>
        public string CreateInvitation(string groupName, string passowrd)
        {
            var invitation = _rdpSession.Invitations.CreateInvitation(null, groupName, passowrd, 1);
            return invitation.ConnectionString;
        }

        private void OnAttendeeConnected(object pAttendee)
        {
            var attendee = (IRDPSRAPIAttendee)pAttendee;
            attendee.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }
    }
}