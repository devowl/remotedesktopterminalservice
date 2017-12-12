using System;
using System.Runtime.InteropServices;

using RDPCOMAPILib;

namespace AxRDPCOMAPILib
{
    [ClassInterface(ClassInterfaceType.None)]
    internal class AxRDPViewerEventMulticaster : _IRDPSessionEvents
    {
        private AxRDPViewer parent;

        public AxRDPViewerEventMulticaster(AxRDPViewer parent)
        {
            this.parent = parent;
        }

        public virtual void OnApplicationClose(object pApplication)
        {
            _IRDPSessionEvents_OnApplicationCloseEvent _IRDPSessionEventsOnApplicationCloseEvent =
                new _IRDPSessionEvents_OnApplicationCloseEvent(pApplication);
            this.parent.RaiseOnOnApplicationClose(this.parent, _IRDPSessionEventsOnApplicationCloseEvent);
        }

        public virtual void OnApplicationOpen(object pApplication)
        {
            _IRDPSessionEvents_OnApplicationOpenEvent _IRDPSessionEventsOnApplicationOpenEvent =
                new _IRDPSessionEvents_OnApplicationOpenEvent(pApplication);
            this.parent.RaiseOnOnApplicationOpen(this.parent, _IRDPSessionEventsOnApplicationOpenEvent);
        }

        public virtual void OnApplicationUpdate(object pApplication)
        {
            _IRDPSessionEvents_OnApplicationUpdateEvent _IRDPSessionEventsOnApplicationUpdateEvent =
                new _IRDPSessionEvents_OnApplicationUpdateEvent(pApplication);
            this.parent.RaiseOnOnApplicationUpdate(this.parent, _IRDPSessionEventsOnApplicationUpdateEvent);
        }

        public virtual void OnAttendeeConnected(object pAttendee)
        {
            _IRDPSessionEvents_OnAttendeeConnectedEvent _IRDPSessionEventsOnAttendeeConnectedEvent =
                new _IRDPSessionEvents_OnAttendeeConnectedEvent(pAttendee);
            this.parent.RaiseOnOnAttendeeConnected(this.parent, _IRDPSessionEventsOnAttendeeConnectedEvent);
        }

        public virtual void OnAttendeeDisconnected(object pDisconnectInfo)
        {
            _IRDPSessionEvents_OnAttendeeDisconnectedEvent _IRDPSessionEventsOnAttendeeDisconnectedEvent =
                new _IRDPSessionEvents_OnAttendeeDisconnectedEvent(pDisconnectInfo);
            this.parent.RaiseOnOnAttendeeDisconnected(this.parent, _IRDPSessionEventsOnAttendeeDisconnectedEvent);
        }

        public virtual void OnAttendeeUpdate(object pAttendee)
        {
            _IRDPSessionEvents_OnAttendeeUpdateEvent _IRDPSessionEventsOnAttendeeUpdateEvent =
                new _IRDPSessionEvents_OnAttendeeUpdateEvent(pAttendee);
            this.parent.RaiseOnOnAttendeeUpdate(this.parent, _IRDPSessionEventsOnAttendeeUpdateEvent);
        }

        public virtual void OnChannelDataReceived(object pChannel, int lAttendeeId, string bstrData)
        {
            _IRDPSessionEvents_OnChannelDataReceivedEvent _IRDPSessionEventsOnChannelDataReceivedEvent =
                new _IRDPSessionEvents_OnChannelDataReceivedEvent(pChannel, lAttendeeId, bstrData);
            this.parent.RaiseOnOnChannelDataReceived(this.parent, _IRDPSessionEventsOnChannelDataReceivedEvent);
        }

        public virtual void OnChannelDataSent(object pChannel, int lAttendeeId, int bytesSent)
        {
            _IRDPSessionEvents_OnChannelDataSentEvent _IRDPSessionEventsOnChannelDataSentEvent =
                new _IRDPSessionEvents_OnChannelDataSentEvent(pChannel, lAttendeeId, bytesSent);
            this.parent.RaiseOnOnChannelDataSent(this.parent, _IRDPSessionEventsOnChannelDataSentEvent);
        }

        public virtual void OnConnectionAuthenticated()
        {
            EventArgs eventArg = new EventArgs();
            this.parent.RaiseOnOnConnectionAuthenticated(this.parent, eventArg);
        }

        public virtual void OnConnectionEstablished()
        {
            EventArgs eventArg = new EventArgs();
            this.parent.RaiseOnOnConnectionEstablished(this.parent, eventArg);
        }

        public virtual void OnConnectionFailed()
        {
            EventArgs eventArg = new EventArgs();
            this.parent.RaiseOnOnConnectionFailed(this.parent, eventArg);
        }

        public virtual void OnConnectionTerminated(int discReason, int extendedInfo)
        {
            _IRDPSessionEvents_OnConnectionTerminatedEvent _IRDPSessionEventsOnConnectionTerminatedEvent =
                new _IRDPSessionEvents_OnConnectionTerminatedEvent(discReason, extendedInfo);
            this.parent.RaiseOnOnConnectionTerminated(this.parent, _IRDPSessionEventsOnConnectionTerminatedEvent);
        }

        public virtual void OnControlLevelChangeRequest(object pAttendee, CTRL_LEVEL requestedLevel)
        {
            _IRDPSessionEvents_OnControlLevelChangeRequestEvent _IRDPSessionEventsOnControlLevelChangeRequestEvent =
                new _IRDPSessionEvents_OnControlLevelChangeRequestEvent(pAttendee, requestedLevel);
            this.parent.RaiseOnOnControlLevelChangeRequest(
                this.parent,
                _IRDPSessionEventsOnControlLevelChangeRequestEvent);
        }

        public virtual void OnError(object errorInfo)
        {
            _IRDPSessionEvents_OnErrorEvent _IRDPSessionEventsOnErrorEvent =
                new _IRDPSessionEvents_OnErrorEvent(errorInfo);
            this.parent.RaiseOnOnError(this.parent, _IRDPSessionEventsOnErrorEvent);
        }

        public virtual void OnFocusReleased(int iDirection)
        {
            _IRDPSessionEvents_OnFocusReleasedEvent _IRDPSessionEventsOnFocusReleasedEvent =
                new _IRDPSessionEvents_OnFocusReleasedEvent(iDirection);
            this.parent.RaiseOnOnFocusReleased(this.parent, _IRDPSessionEventsOnFocusReleasedEvent);
        }

        public virtual void OnGraphicsStreamPaused()
        {
            EventArgs eventArg = new EventArgs();
            this.parent.RaiseOnOnGraphicsStreamPaused(this.parent, eventArg);
        }

        public virtual void OnGraphicsStreamResumed()
        {
            EventArgs eventArg = new EventArgs();
            this.parent.RaiseOnOnGraphicsStreamResumed(this.parent, eventArg);
        }

        public virtual void OnSharedDesktopSettingsChanged(int width, int height, int colordepth)
        {
            _IRDPSessionEvents_OnSharedDesktopSettingsChangedEvent _IRDPSessionEventsOnSharedDesktopSettingsChangedEvent
                = new _IRDPSessionEvents_OnSharedDesktopSettingsChangedEvent(width, height, colordepth);
            this.parent.RaiseOnOnSharedDesktopSettingsChanged(
                this.parent,
                _IRDPSessionEventsOnSharedDesktopSettingsChangedEvent);
        }

        public virtual void OnSharedRectChanged(int left, int top, int right, int bottom)
        {
            _IRDPSessionEvents_OnSharedRectChangedEvent _IRDPSessionEventsOnSharedRectChangedEvent =
                new _IRDPSessionEvents_OnSharedRectChangedEvent(left, top, right, bottom);
            this.parent.RaiseOnOnSharedRectChanged(this.parent, _IRDPSessionEventsOnSharedRectChangedEvent);
        }

        public virtual void OnWindowClose(object pWindow)
        {
            _IRDPSessionEvents_OnWindowCloseEvent _IRDPSessionEventsOnWindowCloseEvent =
                new _IRDPSessionEvents_OnWindowCloseEvent(pWindow);
            this.parent.RaiseOnOnWindowClose(this.parent, _IRDPSessionEventsOnWindowCloseEvent);
        }

        public virtual void OnWindowOpen(object pWindow)
        {
            _IRDPSessionEvents_OnWindowOpenEvent _IRDPSessionEventsOnWindowOpenEvent =
                new _IRDPSessionEvents_OnWindowOpenEvent(pWindow);
            this.parent.RaiseOnOnWindowOpen(this.parent, _IRDPSessionEventsOnWindowOpenEvent);
        }

        public virtual void OnWindowUpdate(object pWindow)
        {
            _IRDPSessionEvents_OnWindowUpdateEvent _IRDPSessionEventsOnWindowUpdateEvent =
                new _IRDPSessionEvents_OnWindowUpdateEvent(pWindow);
            this.parent.RaiseOnOnWindowUpdate(this.parent, _IRDPSessionEventsOnWindowUpdateEvent);
        }
    }
}