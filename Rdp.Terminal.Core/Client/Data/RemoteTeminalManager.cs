using System;

using AxRDPCOMAPILib;

using Rdp.Terminal.Core.Client.Controls;

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
    }
}