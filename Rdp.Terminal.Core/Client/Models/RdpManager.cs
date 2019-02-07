using System;
using System.IO;

using Rdp.Terminal.Core.Client.Data;

namespace Rdp.Terminal.Core.Client.Models
{
    /// <summary>
    /// RDP control manager.
    /// </summary>
    public partial class RdpManager : IRemoteTerminal
    {
        private RemoteTeminalManager _manager;

        /// <summary>
        /// Enable view scaling.
        /// </summary>
        public bool SmartSizing { get; set; }

        /// <inheritdoc/>
        public void Connect(string connectionString, string groupName, string passowrd)
        {
            CheckValid();
            _manager.SmartSizing = SmartSizing;
            _manager.Connect(connectionString, groupName, passowrd);
        }

        /// <inheritdoc/>
        public string StartReverseConnectListener(string connectionString, string groupName, string passowrd)
        {
            CheckValid();
            _manager.SmartSizing = SmartSizing;
            return _manager.StartReverseConnectListener(connectionString, groupName, passowrd);
        }

        /// <inheritdoc/>
        public void Disconnect()
        {
            CheckValid();
            _manager.Disconnect();
        }

        /// <inheritdoc/>
        public void SendFile(byte[] file)
        {
            _manager.SendFile(file);
        }
        
        internal void Attach(RemoteTeminalManager manager)
        {
            Detach();
            _manager = manager;
            Subsribe();
        }

        internal void Detach()
        {
            _manager = null;
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