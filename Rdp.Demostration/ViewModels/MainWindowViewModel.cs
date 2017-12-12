using System;
using System.Diagnostics;
using System.Windows;

using Rdp.Demostration.Prism;
using Rdp.Demostration.Views;
using Rdp.Terminal.Core.Client.Models;
using Rdp.Terminal.Core.Server;

using RDPCOMAPILib;

namespace Rdp.Demostration.ViewModels
{
    /// <summary>
    /// <see cref="MainWindow"/> view model.
    /// </summary>
    public class MainWindowViewModel : NotificationObject
    {
        private string _serverConnectionText;

        private string _teminalEventText;

        /// <summary>
        /// Constructor <see cref="MainWindowViewModel"/>.
        /// </summary>
        public MainWindowViewModel()
        {
            RdpManager = new RdpManager() { SmartSizing = true };

            // RdpManager.OnConnectionTerminated += (reason, info) => SessionTerminated();
            // RdpManager.OnGraphicsStreamPaused += (sender, args) => SessionTerminated();
            // RdpManager.OnAttendeeDisconnected += info => SessionTerminated();

            SingleStartCommand = new DelegateCommand(SingleStart);
            ConnectCommand = new DelegateCommand(Connect);
            ServerStartCommand = new DelegateCommand(ServerStart);
            CopyCommand = new DelegateCommand(Copy);
        }

        private void SingleStart(object obj)
        {
            var server = new RdpSessionServer();
            server.Open();

            server.ApplicationFilterEnabled = true;
            foreach (RDPSRAPIApplication application in server.ApplicationList)
            {
                application.Shared = application.Name == AppDomain.CurrentDomain.FriendlyName;
            }

            ServerConnectionText = server.CreateInvitation(GroupName, Password);
        }

        private void SessionTerminated()
        {
            MessageBox.Show("Session terminated");
        }

        /// <summary>
        /// Remote connection string.
        /// </summary>
        public string ConnectionText { get; set; }

        /// <summary>
        /// Server connection string.
        /// </summary>
        /// <remarks>For client in use.</remarks>
        public string ServerConnectionText
        {
            get
            {
                return _serverConnectionText;
            }

            set
            {
                _serverConnectionText = value;
                RaisePropertyChanged(() => ServerConnectionText);
            }
        }

        /// <summary>
        /// RDP session manager.
        /// </summary>
        public RdpManager RdpManager { get; set; }

        /// <summary>
        /// Server start command.
        /// </summary>
        public DelegateCommand ServerStartCommand { get; private set; }

        /// <summary>
        /// Copy text command.
        /// </summary>
        public DelegateCommand CopyCommand { get; private set; }

        /// <summary>
        /// Start single window sharing.
        /// </summary>
        public DelegateCommand SingleStartCommand { get; private set; }

        /// <summary>
        /// Connect command.
        /// </summary>
        public DelegateCommand ConnectCommand { get; private set; }

        /// <summary>
        /// Terminal events text.
        /// </summary>
        public string TeminalEventText
        {
            get
            {
                return _teminalEventText;
            }

            set
            {
                _teminalEventText = value;
                RaisePropertyChanged(() => TeminalEventText);
            }
        }

        private string GroupName
        {
            get
            {
                return Environment.UserName;
            }
        }

        private string Password
        {
            get
            {
                return "Pa$$w0rrrd";
            }
        }

        private void Copy(object obj)
        {
            Clipboard.SetText(ServerConnectionText);
        }

        private void ServerStart(object obj)
        {
            var server = new RdpSessionServer();
            server.Open();

            ServerConnectionText = server.CreateInvitation(GroupName, Password);
        }

        private void Connect(object obj)
        {
            RdpManager.Connect(ConnectionText, GroupName, Password);
        }
    }
}