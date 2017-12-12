using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AxRDPCOMAPILib;

using RDPCOMAPILib;

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
        public event _IRDPSessionEvents_OnApplicationCloseEventHandler OnApplicationClose
        {
            add
            {
                _manager.RdpViewer.OnApplicationClose += value;
            }

            remove
            {
                _manager.RdpViewer.OnApplicationClose -= value;
            }
        }

        /// <summary>
        /// Called when a new application is created.
        /// </summary>
        public event _IRDPSessionEvents_OnApplicationOpenEventHandler OnApplicationOpen
        {
            add
            {
                _manager.RdpViewer.OnApplicationOpen += value;
            }

            remove
            {
                _manager.RdpViewer.OnApplicationOpen -= value;
            }
        }

        /// <summary>
        /// Called when the shared property on the application object is changed.
        /// </summary>
        public event _IRDPSessionEvents_OnApplicationUpdateEventHandler OnApplicationUpdate
        {
            add
            {
                _manager.RdpViewer.OnApplicationUpdate += value;
            }

            remove
            {
                _manager.RdpViewer.OnApplicationUpdate -= value;
            }
        }

        /// <summary>
        /// Called when an attendee connects to the session.
        /// </summary>
        public event _IRDPSessionEvents_OnAttendeeConnectedEventHandler OnAttendeeConnected
        {
            add
            {
                _manager.RdpViewer.OnAttendeeConnected += value;
            }

            remove
            {
                _manager.RdpViewer.OnAttendeeConnected -= value;
            }
        }

        /// <summary>
        /// Called when an attendee disconnects from the session.
        /// </summary>
        public event _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler OnAttendeeDisconnected
        {
            add
            {
                _manager.RdpViewer.OnAttendeeDisconnected += value;
            }

            remove
            {
                _manager.RdpViewer.OnAttendeeDisconnected -= value;
            }
        }

        /// <summary>
        /// Called when one of the property values for an attendee changes.
        /// </summary>
        public event _IRDPSessionEvents_OnAttendeeUpdateEventHandler OnAttendeeUpdate
        {
            add
            {
                _manager.RdpViewer.OnAttendeeUpdate += value;
            }

            remove
            {
                _manager.RdpViewer.OnAttendeeUpdate -= value;
            }
        }

        /// <summary>
        /// Called when data is received from an attendee.
        /// </summary>
        public event _IRDPSessionEvents_OnChannelDataReceivedEventHandler OnChannelDataReceived
        {
            add
            {
                _manager.RdpViewer.OnChannelDataReceived += value;
            }

            remove
            {
                _manager.RdpViewer.OnChannelDataReceived -= value;
            }
        }

        /// <summary>
        /// Called when data is sent to the client.
        /// </summary>
        public event _IRDPSessionEvents_OnChannelDataSentEventHandler OnChannelDataSent
        {
            add
            {
                _manager.RdpViewer.OnChannelDataSent += value;
            }

            remove
            {
                _manager.RdpViewer.OnChannelDataSent -= value;
            }
        }

        /// <summary>
        /// Called when the connection is authenticated.
        /// </summary>
        public event EventHandler OnConnectionAuthenticated
        {
            add
            {
                _manager.RdpViewer.OnConnectionAuthenticated += value;
            }

            remove
            {
                _manager.RdpViewer.OnConnectionAuthenticated -= value;
            }
        }

        /// <summary>
        /// Called when a connection to the server is established.
        /// </summary>
        public event EventHandler OnConnectionEstablished
        {
            add
            {
                _manager.RdpViewer.OnConnectionEstablished += value;
            }

            remove
            {
                _manager.RdpViewer.OnConnectionEstablished -= value;
            }
        }

        /// <summary>
        /// Called when the client fails to connect to the server.
        /// </summary>
        public event EventHandler OnConnectionFailed
        {
            add
            {
                _manager.RdpViewer.OnConnectionFailed += value;
            }

            remove
            {
                _manager.RdpViewer.OnConnectionFailed -= value;
            }
        }

        /// <summary>
        /// Called when the client's connection to the server is closed.
        /// </summary>
        public event _IRDPSessionEvents_OnConnectionTerminatedEventHandler OnConnectionTerminated
        {
            add
            {
                _manager.RdpViewer.OnConnectionTerminated += value;
            }

            remove
            {
                _manager.RdpViewer.OnConnectionTerminated -= value;
            }
        }

        /// <summary>
        /// Called when a viewer requests control.
        /// </summary>
        public event _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler OnControlLevelChangeRequest
        {
            add
            {
                _manager.RdpViewer.OnControlLevelChangeRequest += value;
            }

            remove
            {
                _manager.RdpViewer.OnControlLevelChangeRequest -= value;
            }
        }

        /// <summary>
        /// Called when a critical error occurs in the session.
        /// </summary>
        public event _IRDPSessionEvents_OnErrorEventHandler OnError
        {
            add
            {
                _manager.RdpViewer.OnError += value;
            }

            remove
            {
                _manager.RdpViewer.OnError -= value;
            }
        }

        /// <summary>
        /// Called when the shared top-level window has gained or lost focus.
        /// </summary>
        public event _IRDPSessionEvents_OnFocusReleasedEventHandler OnFocusReleased
        {
            add
            {
                _manager.RdpViewer.OnFocusReleased += value;
            }

            remove
            {
                _manager.RdpViewer.OnFocusReleased -= value;
            }
        }

        /// <summary>
        /// Called when the graphics stream has been paused.
        /// </summary>
        public event EventHandler OnGraphicsStreamPaused
        {
            add
            {
                _manager.RdpViewer.OnGraphicsStreamPaused += value;
            }

            remove
            {
                _manager.RdpViewer.OnGraphicsStreamPaused -= value;
            }
        }

        /// <summary>
        /// Called when the graphics stream has been resumed.
        /// </summary>
        public event EventHandler OnGraphicsStreamResumed
        {
            add
            {
                _manager.RdpViewer.OnGraphicsStreamResumed += value;
            }

            remove
            {
                _manager.RdpViewer.OnGraphicsStreamResumed -= value;
            }
        }

        /// <summary>
        /// Called when a shared desktop setting changes.
        /// </summary>
        public event _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler OnSharedDesktopSettingsChanged
        {
            add
            {
                _manager.RdpViewer.OnSharedDesktopSettingsChanged += value;
            }

            remove
            {
                _manager.RdpViewer.OnSharedDesktopSettingsChanged -= value;
            }
        }

        /// <summary>
        /// Called when the size of the shared top-level window of the application changes.
        /// </summary>
        public event _IRDPSessionEvents_OnSharedRectChangedEventHandler OnSharedRectChanged
        {
            add
            {
                _manager.RdpViewer.OnSharedRectChanged += value;
            }

            remove
            {
                _manager.RdpViewer.OnSharedRectChanged -= value;
            }
        }

        /// <summary>
        /// Called when a sharable top-level window is closed.
        /// </summary>
        public event _IRDPSessionEvents_OnWindowCloseEventHandler OnWindowClose
        {
            add
            {
                _manager.RdpViewer.OnWindowClose += value;
            }

            remove
            {
                _manager.RdpViewer.OnWindowClose -= value;
            }
        }

        /// <summary>
        /// Called when a sharable top-level window is created by an application.
        /// </summary>
        public event _IRDPSessionEvents_OnWindowOpenEventHandler OnWindowOpen
        {
            add
            {
                _manager.RdpViewer.OnWindowOpen += value;
            }

            remove
            {
                _manager.RdpViewer.OnWindowOpen -= value;
            }
        }

        /// <summary>
        /// Called when one of the properties on the Window object changes.
        /// </summary>
        public event _IRDPSessionEvents_OnWindowUpdateEventHandler OnWindowUpdate
        {
            add
            {
                _manager.RdpViewer.OnWindowUpdate += value;
            }

            remove
            {
                _manager.RdpViewer.OnWindowUpdate -= value;
            }
        }

    }
}
