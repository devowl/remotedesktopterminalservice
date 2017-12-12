using System;
using System.Diagnostics;

using AxRDPCOMAPILib;

using Rdp.Terminal.Core.Client.Controls;
using Rdp.Terminal.Core.Common;

namespace Rdp.Terminal.Core.Client.Data
{
    /// <summary>
    /// <see cref="RemoteTerminal"/> view model logic.
    /// </summary>
    internal class RemoteTeminalManager
    {
        private readonly AxRDPViewer _axRdpViewer;

        /// <summary>
        /// Constructor <see cref="RemoteTeminalManager"/>.
        /// </summary>
        /// <param name="axRdpViewer"><see cref="AxRDPViewer"/> instance.</param>
        public RemoteTeminalManager(AxRDPViewer axRdpViewer)
        {
            _axRdpViewer = axRdpViewer;
            Initialize();
        }

        /// <summary>
        /// Message status updated.
        /// </summary>
        public event EventHandler<MessageArgs> OnMessageStatusUpdated;

        /// <summary>
        /// InitializeDependencyProperties host control.
        /// </summary>
        public void Initialize()
        {
            _axRdpViewer.OnGraphicsStreamPaused += (sender, @event) => SessionTerminated();
            _axRdpViewer.OnAttendeeDisconnected += (sender, @event) => SessionTerminated();
            _axRdpViewer.OnConnectionTerminated += (sender, @event) => SessionTerminated();
        }

        private void SessionTerminated()
        {
            
        }

        /// <summary>
        /// Connect to remote computer.
        /// </summary>
        /// <param name="connectionString">Remote connection string.</param>
        /// <param name="groupName">
        /// The name of the group. The string must be unique for the session. Applications typically 
        /// use the group name to separate attendees into groups that can be granted different authorization levels.
        /// </param>
        /// <param name="passowrd">
        /// Password to use for authentication. The password is limited to 255 characters. You must provide the password 
        /// to the viewer out-of-band from the ticket.
        /// </param>
        public void Connect(string connectionString, string groupName, string passowrd)
        {
            try
            {
                _axRdpViewer.SmartSizing = true;
                _axRdpViewer.Connect(connectionString, groupName, passowrd);
            }
            catch (Exception ex)
            {
                MessageStatusUpdated(ex);
                throw;
            }
        }

        private void MessageStatusUpdated<TException>(TException exception) where TException : Exception
        {
            MessageStatusUpdated(exception.Message);
        }

        private void MessageStatusUpdated(string text)
        {
            if (OnMessageStatusUpdated != null && !string.IsNullOrEmpty(text))
            {
                OnMessageStatusUpdated(this, new MessageArgs(text));
            }
        }
    }
}