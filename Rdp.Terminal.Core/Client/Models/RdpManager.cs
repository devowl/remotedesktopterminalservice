using System;

using Rdp.Terminal.Core.Client.Data;

namespace Rdp.Terminal.Core.Client.Models
{
    /// <summary>
    /// RDP control manager.
    /// </summary>
    public partial class RdpManager : IRemoteTerminal
    {
        private RemoteTeminalManager _manager;

        /// <inheritdoc/>
        public void Connect(string connectionString, string groupName, string passowrd)
        {
            CheckValid();
            _manager.Connect(connectionString, groupName, passowrd);
        }

        /// <inheritdoc/>
        public string StartReverseConnectListener(string connectionString, string groupName, string passowrd)
        {
            CheckValid();
            return _manager.StartReverseConnectListener(connectionString, groupName, passowrd);
        }

        /// <inheritdoc/>
        public void Disconnect()
        {
            CheckValid();
            _manager.Disconnect();
        }

        internal void Attach(RemoteTeminalManager manager)
        {
            Detach();
            _manager = manager;
        }

        internal void Detach()
        {
            if (_manager != null)
            {
                _manager = null;
            }
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