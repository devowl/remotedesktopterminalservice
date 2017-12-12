using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using RDPCOMAPILib;

namespace AxRDPCOMAPILib
{
    [Clsid("{32be5ed2-5c86-480f-a914-0ff8885a1b3f}")]
    [DesignTimeVisible(true)]
    internal class AxRDPViewer : AxHost
    {
        private IRDPSRAPIViewer ocx;

        private AxRDPViewerEventMulticaster eventMulticaster;

        private AxHost.ConnectionPointCookie cookie;

        public AxRDPViewer() : base("32be5ed2-5c86-480f-a914-0ff8885a1b3f")
        {
        }

        public event _IRDPSessionEvents_OnApplicationCloseEventHandler OnApplicationClose;

        public event _IRDPSessionEvents_OnApplicationOpenEventHandler OnApplicationOpen;

        public event _IRDPSessionEvents_OnApplicationUpdateEventHandler OnApplicationUpdate;

        public event _IRDPSessionEvents_OnAttendeeConnectedEventHandler OnAttendeeConnected;

        public event _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler OnAttendeeDisconnected;

        public event _IRDPSessionEvents_OnAttendeeUpdateEventHandler OnAttendeeUpdate;

        public event _IRDPSessionEvents_OnChannelDataReceivedEventHandler OnChannelDataReceived;

        public event _IRDPSessionEvents_OnChannelDataSentEventHandler OnChannelDataSent;

        public event EventHandler OnConnectionAuthenticated;

        public event EventHandler OnConnectionEstablished;

        public event EventHandler OnConnectionFailed;

        public event _IRDPSessionEvents_OnConnectionTerminatedEventHandler OnConnectionTerminated;

        public event _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler OnControlLevelChangeRequest;

        public event _IRDPSessionEvents_OnErrorEventHandler OnError;

        public event _IRDPSessionEvents_OnFocusReleasedEventHandler OnFocusReleased;

        public event EventHandler OnGraphicsStreamPaused;

        public event EventHandler OnGraphicsStreamResumed;

        public event _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler OnSharedDesktopSettingsChanged;

        public event _IRDPSessionEvents_OnSharedRectChangedEventHandler OnSharedRectChanged;

        public event _IRDPSessionEvents_OnWindowCloseEventHandler OnWindowClose;

        public event _IRDPSessionEvents_OnWindowOpenEventHandler OnWindowOpen;

        public event _IRDPSessionEvents_OnWindowUpdateEventHandler OnWindowUpdate;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(215)]
        public virtual RDPSRAPIApplicationFilter ApplicationFilter
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException(
                        "ApplicationFilter",
                        AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ApplicationFilter;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(203)]
        public virtual RDPSRAPIAttendeeManager Attendees
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Attendees", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Attendees;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(237)]
        public virtual string DisconnectedText
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException(
                        "DisconnectedText",
                        AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.DisconnectedText;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException(
                        "DisconnectedText",
                        AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.DisconnectedText = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(204)]
        public virtual RDPSRAPIInvitationManager Invitations
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Invitations", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Invitations;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(202)]
        public new virtual RDPSRAPISessionProperties Properties
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Properties", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Properties;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(238)]
        public virtual bool SmartSizing
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SmartSizing", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.SmartSizing;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SmartSizing", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.SmartSizing = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(206)]
        public virtual IRDPSRAPIVirtualChannelManager VirtualChannelManager
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException(
                        "VirtualChannelManager",
                        AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.VirtualChannelManager;
            }
        }

        public virtual void Connect(string bstrConnectionString, string bstrName, string bstrPassword)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Connect", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Connect(bstrConnectionString, bstrName, bstrPassword);
        }

        public virtual void Disconnect()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Disconnect", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Disconnect();
        }

        public virtual void RequestColorDepthChange(int bpp)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException(
                    "RequestColorDepthChange",
                    AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.RequestColorDepthChange(bpp);
        }

        public virtual void RequestControl(CTRL_LEVEL ctrlLevel)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("RequestControl", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.RequestControl(ctrlLevel);
        }

        public virtual string StartReverseConnectListener(
            string bstrConnectionString,
            string bstrUserName,
            string bstrPassword)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException(
                    "StartReverseConnectListener",
                    AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.StartReverseConnectListener(bstrConnectionString, bstrUserName, bstrPassword);
        }

        internal void RaiseOnOnApplicationClose(object sender, _IRDPSessionEvents_OnApplicationCloseEvent e)
        {
            if (this.OnApplicationClose != null)
            {
                this.OnApplicationClose(e);
            }
        }

        internal void RaiseOnOnApplicationOpen(object sender, _IRDPSessionEvents_OnApplicationOpenEvent e)
        {
            if (this.OnApplicationOpen != null)
            {
                this.OnApplicationOpen(e);
            }
        }

        internal void RaiseOnOnApplicationUpdate(object sender, _IRDPSessionEvents_OnApplicationUpdateEvent e)
        {
            if (this.OnApplicationUpdate != null)
            {
                this.OnApplicationUpdate(e);
            }
        }

        internal void RaiseOnOnAttendeeConnected(object sender, _IRDPSessionEvents_OnAttendeeConnectedEvent e)
        {
            if (this.OnAttendeeConnected != null)
            {
                this.OnAttendeeConnected(e);
            }
        }

        internal void RaiseOnOnAttendeeDisconnected(object sender, _IRDPSessionEvents_OnAttendeeDisconnectedEvent e)
        {
            if (this.OnAttendeeDisconnected != null)
            {
                this.OnAttendeeDisconnected(e);
            }
        }

        internal void RaiseOnOnAttendeeUpdate(object sender, _IRDPSessionEvents_OnAttendeeUpdateEvent e)
        {
            if (this.OnAttendeeUpdate != null)
            {
                this.OnAttendeeUpdate(e);
            }
        }

        internal void RaiseOnOnChannelDataReceived(object sender, _IRDPSessionEvents_OnChannelDataReceivedEvent e)
        {
            if (this.OnChannelDataReceived != null)
            {
                this.OnChannelDataReceived(e.pChannel, e.lAttendeeId, e.bstrData);
            }
        }

        internal void RaiseOnOnChannelDataSent(object sender, _IRDPSessionEvents_OnChannelDataSentEvent e)
        {
            if (this.OnChannelDataSent != null)
            {
                this.OnChannelDataSent(e.pChannel, e.lAttendeeId, e.bytesSent);
            }
        }

        internal void RaiseOnOnConnectionAuthenticated(object sender, EventArgs e)
        {
            if (this.OnConnectionAuthenticated != null)
            {
                this.OnConnectionAuthenticated(sender, e);
            }
        }

        internal void RaiseOnOnConnectionEstablished(object sender, EventArgs e)
        {
            if (this.OnConnectionEstablished != null)
            {
                this.OnConnectionEstablished(sender, e);
            }
        }

        internal void RaiseOnOnConnectionFailed(object sender, EventArgs e)
        {
            if (this.OnConnectionFailed != null)
            {
                this.OnConnectionFailed(sender, e);
            }
        }

        internal void RaiseOnOnConnectionTerminated(object sender, _IRDPSessionEvents_OnConnectionTerminatedEvent e)
        {
            if (this.OnConnectionTerminated != null)
            {
                this.OnConnectionTerminated(e.discReason, e.extendedInfo);
            }
        }

        internal void RaiseOnOnControlLevelChangeRequest(
            object sender,
            _IRDPSessionEvents_OnControlLevelChangeRequestEvent e)
        {
            if (this.OnControlLevelChangeRequest != null)
            {
                this.OnControlLevelChangeRequest(e.pAttendee, e.requestedLevel);
            }
        }

        internal void RaiseOnOnError(object sender, _IRDPSessionEvents_OnErrorEvent e)
        {
            if (this.OnError != null)
            {
                this.OnError(e);
            }
        }

        internal void RaiseOnOnFocusReleased(object sender, _IRDPSessionEvents_OnFocusReleasedEvent e)
        {
            if (this.OnFocusReleased != null)
            {
                this.OnFocusReleased(e.iDirection);
            }
        }

        internal void RaiseOnOnGraphicsStreamPaused(object sender, EventArgs e)
        {
            if (this.OnGraphicsStreamPaused != null)
            {
                this.OnGraphicsStreamPaused(sender, e);
            }
        }

        internal void RaiseOnOnGraphicsStreamResumed(object sender, EventArgs e)
        {
            if (this.OnGraphicsStreamResumed != null)
            {
                this.OnGraphicsStreamResumed(sender, e);
            }
        }

        internal void RaiseOnOnSharedDesktopSettingsChanged(
            object sender,
            _IRDPSessionEvents_OnSharedDesktopSettingsChangedEvent e)
        {
            if (this.OnSharedDesktopSettingsChanged != null)
            {
                this.OnSharedDesktopSettingsChanged(e.width, e.height, e.colordepth);
            }
        }

        internal void RaiseOnOnSharedRectChanged(object sender, _IRDPSessionEvents_OnSharedRectChangedEvent e)
        {
            if (this.OnSharedRectChanged != null)
            {
                this.OnSharedRectChanged(e.left, e.top, e.right, e.bottom);
            }
        }

        internal void RaiseOnOnWindowClose(object sender, _IRDPSessionEvents_OnWindowCloseEvent e)
        {
            if (this.OnWindowClose != null)
            {
                this.OnWindowClose(e.pWindow);
            }
        }

        internal void RaiseOnOnWindowOpen(object sender, _IRDPSessionEvents_OnWindowOpenEvent e)
        {
            if (this.OnWindowOpen != null)
            {
                this.OnWindowOpen(e);
            }
        }

        internal void RaiseOnOnWindowUpdate(object sender, _IRDPSessionEvents_OnWindowUpdateEvent e)
        {
            if (this.OnWindowUpdate != null)
            {
                this.OnWindowUpdate(e);
            }
        }

        protected override void AttachInterfaces()
        {
            try
            {
                this.ocx = (IRDPSRAPIViewer)base.GetOcx();
            }
            catch (Exception exception)
            {
            }
        }

        protected override void CreateSink()
        {
            try
            {
                this.eventMulticaster = new AxRDPViewerEventMulticaster(this);
                this.cookie = new AxHost.ConnectionPointCookie(
                    this.ocx,
                    this.eventMulticaster,
                    typeof(_IRDPSessionEvents));
            }
            catch (Exception exception)
            {
            }
        }

        protected override void DetachSink()
        {
            try
            {
                this.cookie.Disconnect();
            }
            catch (Exception exception)
            {
            }
        }
    }
}