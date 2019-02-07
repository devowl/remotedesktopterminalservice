using System;
using System.Windows;

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

        private readonly IRDPSRAPIVirtualChannel _fileChannel;
         
        /// <summary>
        /// Constructor <see cref="RdpSessionServer"/>.
        /// </summary>
        public RdpSessionServer()
        {
            _rdpSession = new RDPSession { colordepth = 8 };
            _fileChannel = _rdpSession.VirtualChannelManager.CreateVirtualChannel(
                "File",
                CHANNEL_PRIORITY.CHANNEL_PRIORITY_HI,
                (uint)CHANNEL_FLAGS.CHANNEL_FLAGS_LEGACY);
            _fileChannel.SendData("Some data", -1, (uint)CHANNEL_FLAGS.CHANNEL_FLAGS_LEGACY);
            _rdpSession.add_OnAttendeeConnected(OnAttendeeConnected);
            _rdpSession.add_OnChannelDataReceived(OnDataRecieved);
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
                _rdpSession?.Close();
            }
            catch
            {
            }
        }
        
        private void OnDataRecieved(object pchannel, int lattendeeid, string bstrdata)
        {
            MessageBox.Show(bstrdata);
        }

        private void OnAttendeeConnected(object pAttendee)
        {
            // TODO Make overridable
            var attendee = (IRDPSRAPIAttendee)pAttendee;
            attendee.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }
    }
}