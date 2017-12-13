using System;
using RDPCOMAPILib;

// ReSharper disable DelegateSubtraction
namespace Rdp.Terminal.Core.Client.Models
{
    
    /// <summary>
    /// <see cref="RDPCOMAPILib._IRDPSessionEvents"/>_IRDPSessionEvents RdpViewer events.
    /// </summary>
    /// <remarks>https://msdn.microsoft.com/en-us/library/aa373879(v=vs.85).aspx</remarks>
    public partial class RdpManager
    {
        /// <summary>
        /// Called when an application closes.
        /// </summary>
        public event _IRDPSessionEvents_OnApplicationCloseEventHandler OnApplicationClose;

        /// <summary>
        /// Called when a new application is created.
        /// </summary>
        public event _IRDPSessionEvents_OnApplicationOpenEventHandler OnApplicationOpen;

        /// <summary>
        /// Called when the shared property on the application object is changed.
        /// </summary>
        public event _IRDPSessionEvents_OnApplicationUpdateEventHandler OnApplicationUpdate;

        /// <summary>
        /// Called when an attendee connects to the session.
        /// </summary>
        public event _IRDPSessionEvents_OnAttendeeConnectedEventHandler OnAttendeeConnected;

        /// <summary>
        /// Called when an attendee disconnects from the session.
        /// </summary>
        public event _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler OnAttendeeDisconnected;

        /// <summary>
        /// Called when one of the property values for an attendee changes.
        /// </summary>
        public event _IRDPSessionEvents_OnAttendeeUpdateEventHandler OnAttendeeUpdate;

        /// <summary>
        /// Called when data is received from an attendee.
        /// </summary>
        public event _IRDPSessionEvents_OnChannelDataReceivedEventHandler OnChannelDataReceived;

        /// <summary>
        /// Called when data is sent to the client.
        /// </summary>
        public event _IRDPSessionEvents_OnChannelDataSentEventHandler OnChannelDataSent;

        /// <summary>
        /// Called when the connection is authenticated.
        /// </summary>
        public event EventHandler OnConnectionAuthenticated;

        /// <summary>
        /// Called when a connection to the server is established.
        /// </summary>
        public event EventHandler OnConnectionEstablished;

        /// <summary>
        /// Called when the client fails to connect to the server.
        /// </summary>
        public event EventHandler OnConnectionFailed;

        /// <summary>
        /// Called when the client's connection to the server is closed.
        /// </summary>
        public event _IRDPSessionEvents_OnConnectionTerminatedEventHandler OnConnectionTerminated;

        /// <summary>
        /// Called when a viewer requests control.
        /// </summary>
        public event _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler OnControlLevelChangeRequest;

        /// <summary>
        /// Called when a critical error occurs in the session.
        /// </summary>
        public event _IRDPSessionEvents_OnErrorEventHandler OnError;

        /// <summary>
        /// Called when the shared top-level window has gained or lost focus.
        /// </summary>
        public event _IRDPSessionEvents_OnFocusReleasedEventHandler OnFocusReleased;

        /// <summary>
        /// Called when the graphics stream has been paused.
        /// </summary>
        public event EventHandler OnGraphicsStreamPaused;

        /// <summary>
        /// Called when the graphics stream has been resumed.
        /// </summary>
        public event EventHandler OnGraphicsStreamResumed;

        /// <summary>
        /// Called when a shared desktop setting changes.
        /// </summary>
        public event _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler OnSharedDesktopSettingsChanged;

        /// <summary>
        /// Called when the size of the shared top-level window of the application changes.
        /// </summary>
        public event _IRDPSessionEvents_OnSharedRectChangedEventHandler OnSharedRectChanged;

        /// <summary>
        /// Called when a sharable top-level window is closed.
        /// </summary>
        public event _IRDPSessionEvents_OnWindowCloseEventHandler OnWindowClose;

        /// <summary>
        /// Called when a sharable top-level window is created by an application.
        /// </summary>
        public event _IRDPSessionEvents_OnWindowOpenEventHandler OnWindowOpen;

        /// <summary>
        /// Called when one of the properties on the Window object changes.
        /// </summary>
        public event _IRDPSessionEvents_OnWindowUpdateEventHandler OnWindowUpdate;

        private void Subsribe()
        {
            _manager.RdpViewer.OnApplicationClose += delegate(object application) { OnApplicationClose?.Invoke(application); };
            _manager.RdpViewer.OnApplicationOpen += delegate(object application) { OnApplicationOpen?.Invoke(application); };
            _manager.RdpViewer.OnApplicationUpdate += delegate(object application) { OnApplicationUpdate?.Invoke(application); };
            _manager.RdpViewer.OnAttendeeConnected += delegate(object attendee) { OnAttendeeConnected?.Invoke(attendee); };
            _manager.RdpViewer.OnAttendeeDisconnected += delegate(object info) { OnAttendeeDisconnected?.Invoke(info); };
            _manager.RdpViewer.OnAttendeeUpdate += delegate(object attendee) { OnAttendeeUpdate?.Invoke(attendee); };
            _manager.RdpViewer.OnChannelDataReceived += delegate(object channel, int id, string data) { OnChannelDataReceived?.Invoke(channel, id, data); };
            _manager.RdpViewer.OnChannelDataSent += delegate(object channel, int id, int sent) { OnChannelDataSent?.Invoke(channel, id, sent); };
            _manager.RdpViewer.OnConnectionAuthenticated += delegate(object sender, EventArgs args) { OnConnectionAuthenticated?.Invoke(sender, args); };
            _manager.RdpViewer.OnConnectionEstablished += delegate(object sender, EventArgs args) { OnConnectionEstablished?.Invoke(sender, args); };
            _manager.RdpViewer.OnConnectionFailed += delegate(object sender, EventArgs args) { OnConnectionFailed?.Invoke(sender, args); };
            _manager.RdpViewer.OnConnectionTerminated += delegate(int reason, int info) { OnConnectionTerminated?.Invoke(reason, info); };
            _manager.RdpViewer.OnControlLevelChangeRequest += delegate(object attendee, CTRL_LEVEL level) { OnControlLevelChangeRequest?.Invoke(attendee, level); };
            _manager.RdpViewer.OnError += delegate(object info) { OnError?.Invoke(info); };
            _manager.RdpViewer.OnFocusReleased += delegate(int direction) { OnFocusReleased?.Invoke(direction); };
            _manager.RdpViewer.OnGraphicsStreamPaused += delegate(object sender, EventArgs args) { OnGraphicsStreamPaused?.Invoke(sender, args); };
            _manager.RdpViewer.OnGraphicsStreamResumed += delegate(object sender, EventArgs args) { OnGraphicsStreamResumed?.Invoke(sender, args); };
            _manager.RdpViewer.OnSharedDesktopSettingsChanged += delegate(int width, int height, int colordepth) { OnSharedDesktopSettingsChanged?.Invoke(width, height, colordepth); };
            _manager.RdpViewer.OnSharedRectChanged += delegate(int left, int top, int right, int bottom) { OnSharedRectChanged?.Invoke(left, top, right, bottom); };
            _manager.RdpViewer.OnWindowClose += delegate(object window) { OnWindowClose?.Invoke(window); };
            _manager.RdpViewer.OnWindowOpen += delegate(object window) { OnWindowOpen?.Invoke(window); };
            _manager.RdpViewer.OnWindowUpdate += delegate(object window) { OnWindowUpdate?.Invoke(window); };
        }
    }
}