using System;

using Rdp.Terminal.Core.Client.Data;
using Rdp.Terminal.Core.Common;

namespace Rdp.Terminal.Core.Client.Models
{
    /// <summary>
    /// RDP control manager.
    /// </summary>
    public class RdpManager
    {
        private RemoteTeminalManager _manager;

        /// <summary>
        /// Message status updated.
        /// </summary>
        public event EventHandler<MessageArgs> OnMessageStatusUpdated;

        /// <summary>
        /// Connect to remote computer.
        /// </summary>
        /// <param name="connectionString">Connection string.</param>
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
            CheckValid();
            _manager.Connect(connectionString, groupName, passowrd);
        }

        internal void Attach(RemoteTeminalManager manager)
        {
            Detach();
            _manager = manager;
            _manager.OnMessageStatusUpdated += ManagerOnOnMessageStatusUpdated;
        }

        internal void Detach()
        {
            if (_manager != null)
            {
                _manager.OnMessageStatusUpdated -= ManagerOnOnMessageStatusUpdated;
                _manager = null;
            }
        }

        private void ManagerOnOnMessageStatusUpdated(object sender, MessageArgs messageArgs)
        {
            OnMessageStatusUpdated?.Invoke(this, messageArgs);
        }

        private void CheckValid()
        {
            if (_manager == null)
            {
                throw new NotSupportedException("RdpManager still not attached");
            }
        }
    }
}