using System;
using System.IO;

using AxRDPCOMAPILib;

using Rdp.Terminal.Core.Client.Controls;

using RDPCOMAPILib;

namespace Rdp.Terminal.Core.Client.Data
{
    /// <summary>
    /// <see cref="RemoteTerminal"/> view model logic.
    /// </summary>
    internal class RemoteTeminalManager : IRemoteTerminal
    {
        private readonly AxRDPViewer _axRdpViewer;

        /// <summary>
        /// Constructor <see cref="RemoteTeminalManager"/>.
        /// </summary>
        /// <param name="axRdpViewer"><see cref="AxRDPViewer"/> instance.</param>
        public RemoteTeminalManager(AxRDPViewer axRdpViewer)
        {
            if (axRdpViewer == null)
            {
                throw new ArgumentNullException(nameof(axRdpViewer));
            }

            _axRdpViewer = axRdpViewer;
        }

        /// <inheritdoc/>
        public bool SmartSizing
        {
            get
            {
                return _axRdpViewer.SmartSizing;
            }

            set
            {
                _axRdpViewer.SmartSizing = value;
            }
        }

        /// <summary>
        /// <see cref="AxRDPViewer"/> instance reference.
        /// </summary>
        internal AxRDPViewer RdpViewer
        {
            get
            {
                return _axRdpViewer;
            }
        }

        /// <inheritdoc/>
        public void Connect(string connectionString, string groupName, string passowrd)
        {
            _axRdpViewer.Connect(connectionString, groupName, passowrd);
        }

        /// <inheritdoc/>
        public string StartReverseConnectListener(string connectionString, string groupName, string passowrd)
        {
            return _axRdpViewer.StartReverseConnectListener(connectionString, groupName, passowrd);
        }

        /// <inheritdoc/>
        public void Disconnect()
        {
            _axRdpViewer.Disconnect();
        }

        /// <inheritdoc/>
        public void SendFile(byte[] file)
        {
            var fileBase64 = Convert.ToBase64String(file);
            var channel = _axRdpViewer.VirtualChannelManager.CreateVirtualChannel(
                "File",
                CHANNEL_PRIORITY.CHANNEL_PRIORITY_HI,
                (uint)CHANNEL_FLAGS.CHANNEL_FLAGS_LEGACY);
            
            channel.SendData(fileBase64, (int)RDPENCOMAPI_CONSTANTS.CONST_ATTENDEE_ID_EVERYONE, (uint)CHANNEL_FLAGS.CHANNEL_FLAGS_LEGACY);
        }
    }
}