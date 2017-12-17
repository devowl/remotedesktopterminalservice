using System;

using RDPCOMAPILib;

namespace Rdp.Terminal.Core.Server
{
    /// <summary>
    /// RDP server hosting provider.
    /// </summary>
    public class RdpSessionServer : IDisposable
    {
        /// <summary>
        /// https://msdn.microsoft.com/en-us/library/aa373307(v=vs.85).aspx.
        /// </summary>
        private readonly RDPSession _rdpSession;
        
        /// <summary>
        /// Constructor <see cref="RdpSessionServer"/>.
        /// </summary>
        public RdpSessionServer()
        {
            // Specifies the color depth of the session in bits per pixel (bpp). The color depth is always 32. If you specify any other value, the color depth is set to 32 bpp.
            // Windows Server 2008 R2: Possible values are 16 and 24.If you specify a value of 8, the color depth is set to 16 bpp.
            // Windows Server 2008 and Windows Vista: Possible values are 8, 16, and 24 bpp.
            _rdpSession = new RDPSession { colordepth = 8 };
            _rdpSession.add_OnAttendeeConnected(OnAttendeeConnected);
        }
        
        /// <summary>
        /// The enabled state of the application filter.
        /// </summary>
        public bool ApplicationFilterEnabled
        {
            get
            {
                return _rdpSession.ApplicationFilter.Enabled;
            }

            set
            {
                _rdpSession.ApplicationFilter.Enabled = value;
            }
        }

        /// <summary>
        /// The list of sharable applications.
        /// </summary>
        /// <remarks>
        /// Attention! <see cref="ApplicationFilterEnabled"/> should be TRUE.
        /// </remarks>
        public RDPSRAPIApplicationList ApplicationList
        {
            get
            {
                return _rdpSession.ApplicationFilter.Applications;
            }
        }

        /// <summary>
        /// Puts the session in an active state and starts listening to incoming connections.
        /// </summary>
        public void Open()
        {
            _rdpSession.Open();
        }

        /// <summary>
        /// Puts the session in an inactive state, closes all attendees, and stops listening to new incoming connections.
        /// </summary>
        public void Close()
        {
            _rdpSession.Close();
        }

        /// <summary>
        /// Pauses the encoding of the sharer's desktop to pause sending graphics updates to all viewers.
        /// </summary>
        public void Pause()
        {
            _rdpSession.Pause();
        }

        /// <summary>
        /// Resumes the encoding of the sharer's desktop to resume sending graphics updates to all viewers.
        /// </summary>
        public void Resume()
        {
            _rdpSession.Resume();
        }

        /// <summary>
        /// Connects the viewer from the sharer in reverse connect mode if the viewer cannot connect to the sharer because 
        /// of a network issue. For example, the viewer may not be able to connect to the sharer because of network address translation (NAT).
        /// </summary>
        /// <param name="connectionString">Connection string that the viewer sends to the sharer out-of-band through IM or email.</param>
        public void ConnectToClient(string connectionString)
        {
            _rdpSession.ConnectToClient(connectionString);
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

        /// <inheritdoc/>
        public void Dispose()
        {
            try
            {
                if (_rdpSession != null)
                {
                    foreach (IRDPSRAPIAttendee attendees in _rdpSession.Attendees)
                    {
                        attendees.TerminateConnection();
                    }

                    _rdpSession.Close();
                }
            }
            catch
            {
            }
        }

        private void OnAttendeeConnected(object pAttendee)
        {
            // TODO Make overridable
            var attendee = (IRDPSRAPIAttendee)pAttendee;
            attendee.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }
    }
}