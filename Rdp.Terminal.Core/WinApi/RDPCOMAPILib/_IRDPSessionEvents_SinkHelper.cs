using System.Runtime.InteropServices;

namespace RDPCOMAPILib
{
    [TypeLibType(TypeLibTypeFlags.FHidden)]
    [ClassInterface(ClassInterfaceType.None)]
    internal sealed class _IRDPSessionEvents_SinkHelper : _IRDPSessionEvents
    {
        public _IRDPSessionEvents_OnAttendeeConnectedEventHandler m_OnAttendeeConnectedDelegate;

        public _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler m_OnAttendeeDisconnectedDelegate;

        public _IRDPSessionEvents_OnAttendeeUpdateEventHandler m_OnAttendeeUpdateDelegate;

        public _IRDPSessionEvents_OnConnectionEstablishedEventHandler m_OnConnectionEstablishedDelegate;

        public _IRDPSessionEvents_OnConnectionFailedEventHandler m_OnConnectionFailedDelegate;

        public _IRDPSessionEvents_OnConnectionTerminatedEventHandler m_OnConnectionTerminatedDelegate;

        public _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler m_OnConnectionAuthenticatedDelegate;

        public _IRDPSessionEvents_OnErrorEventHandler m_OnErrorDelegate;

        public _IRDPSessionEvents_OnApplicationOpenEventHandler m_OnApplicationOpenDelegate;

        public _IRDPSessionEvents_OnApplicationCloseEventHandler m_OnApplicationCloseDelegate;

        public _IRDPSessionEvents_OnApplicationUpdateEventHandler m_OnApplicationUpdateDelegate;

        public _IRDPSessionEvents_OnWindowOpenEventHandler m_OnWindowOpenDelegate;

        public _IRDPSessionEvents_OnWindowCloseEventHandler m_OnWindowCloseDelegate;

        public _IRDPSessionEvents_OnWindowUpdateEventHandler m_OnWindowUpdateDelegate;

        public _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler m_OnControlLevelChangeRequestDelegate;

        public _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler m_OnGraphicsStreamPausedDelegate;

        public _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler m_OnGraphicsStreamResumedDelegate;

        public _IRDPSessionEvents_OnChannelDataReceivedEventHandler m_OnChannelDataReceivedDelegate;

        public _IRDPSessionEvents_OnChannelDataSentEventHandler m_OnChannelDataSentDelegate;

        public _IRDPSessionEvents_OnSharedRectChangedEventHandler m_OnSharedRectChangedDelegate;

        public _IRDPSessionEvents_OnFocusReleasedEventHandler m_OnFocusReleasedDelegate;

        public _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler m_OnSharedDesktopSettingsChangedDelegate;

        public int m_dwCookie;

        internal _IRDPSessionEvents_SinkHelper()
        {
            this.m_dwCookie = 0;
            this.m_OnAttendeeConnectedDelegate = (_IRDPSessionEvents_OnAttendeeConnectedEventHandler)null;
            this.m_OnAttendeeDisconnectedDelegate = (_IRDPSessionEvents_OnAttendeeDisconnectedEventHandler)null;
            this.m_OnAttendeeUpdateDelegate = (_IRDPSessionEvents_OnAttendeeUpdateEventHandler)null;
            this.m_OnConnectionEstablishedDelegate = (_IRDPSessionEvents_OnConnectionEstablishedEventHandler)null;
            this.m_OnConnectionFailedDelegate = (_IRDPSessionEvents_OnConnectionFailedEventHandler)null;
            this.m_OnConnectionTerminatedDelegate = (_IRDPSessionEvents_OnConnectionTerminatedEventHandler)null;
            this.m_OnConnectionAuthenticatedDelegate = (_IRDPSessionEvents_OnConnectionAuthenticatedEventHandler)null;
            this.m_OnErrorDelegate = (_IRDPSessionEvents_OnErrorEventHandler)null;
            this.m_OnApplicationOpenDelegate = (_IRDPSessionEvents_OnApplicationOpenEventHandler)null;
            this.m_OnApplicationCloseDelegate = (_IRDPSessionEvents_OnApplicationCloseEventHandler)null;
            this.m_OnApplicationUpdateDelegate = (_IRDPSessionEvents_OnApplicationUpdateEventHandler)null;
            this.m_OnWindowOpenDelegate = (_IRDPSessionEvents_OnWindowOpenEventHandler)null;
            this.m_OnWindowCloseDelegate = (_IRDPSessionEvents_OnWindowCloseEventHandler)null;
            this.m_OnWindowUpdateDelegate = (_IRDPSessionEvents_OnWindowUpdateEventHandler)null;
            this.m_OnControlLevelChangeRequestDelegate =
                (_IRDPSessionEvents_OnControlLevelChangeRequestEventHandler)null;
            this.m_OnGraphicsStreamPausedDelegate = (_IRDPSessionEvents_OnGraphicsStreamPausedEventHandler)null;
            this.m_OnGraphicsStreamResumedDelegate = (_IRDPSessionEvents_OnGraphicsStreamResumedEventHandler)null;
            this.m_OnChannelDataReceivedDelegate = (_IRDPSessionEvents_OnChannelDataReceivedEventHandler)null;
            this.m_OnChannelDataSentDelegate = (_IRDPSessionEvents_OnChannelDataSentEventHandler)null;
            this.m_OnSharedRectChangedDelegate = (_IRDPSessionEvents_OnSharedRectChangedEventHandler)null;
            this.m_OnFocusReleasedDelegate = (_IRDPSessionEvents_OnFocusReleasedEventHandler)null;
            this.m_OnSharedDesktopSettingsChangedDelegate =
                (_IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler)null;
        }

        public void OnAttendeeConnected([In] object obj0)
        {
            if (this.m_OnAttendeeConnectedDelegate == null)
            {
                return;
            }
            this.m_OnAttendeeConnectedDelegate(obj0);
        }

        public void OnAttendeeDisconnected([In] object obj0)
        {
            if (this.m_OnAttendeeDisconnectedDelegate == null)
            {
                return;
            }
            this.m_OnAttendeeDisconnectedDelegate(obj0);
        }

        public void OnAttendeeUpdate([In] object obj0)
        {
            if (this.m_OnAttendeeUpdateDelegate == null)
            {
                return;
            }
            this.m_OnAttendeeUpdateDelegate(obj0);
        }

        public void OnConnectionEstablished()
        {
            if (this.m_OnConnectionEstablishedDelegate == null)
            {
                return;
            }
            this.m_OnConnectionEstablishedDelegate();
        }

        public void OnConnectionFailed()
        {
            if (this.m_OnConnectionFailedDelegate == null)
            {
                return;
            }
            this.m_OnConnectionFailedDelegate();
        }

        public void OnConnectionTerminated([In] int obj0, [In] int obj1)
        {
            if (this.m_OnConnectionTerminatedDelegate == null)
            {
                return;
            }
            this.m_OnConnectionTerminatedDelegate(obj0, obj1);
        }

        public void OnConnectionAuthenticated()
        {
            if (this.m_OnConnectionAuthenticatedDelegate == null)
            {
                return;
            }
            this.m_OnConnectionAuthenticatedDelegate();
        }

        public void OnError([In] object obj0)
        {
            if (this.m_OnErrorDelegate == null)
            {
                return;
            }
            this.m_OnErrorDelegate(obj0);
        }

        public void OnApplicationOpen([In] object obj0)
        {
            if (this.m_OnApplicationOpenDelegate == null)
            {
                return;
            }
            this.m_OnApplicationOpenDelegate(obj0);
        }

        public void OnApplicationClose([In] object obj0)
        {
            if (this.m_OnApplicationCloseDelegate == null)
            {
                return;
            }
            this.m_OnApplicationCloseDelegate(obj0);
        }

        public void OnApplicationUpdate([In] object obj0)
        {
            if (this.m_OnApplicationUpdateDelegate == null)
            {
                return;
            }
            this.m_OnApplicationUpdateDelegate(obj0);
        }

        public void OnWindowOpen([In] object obj0)
        {
            if (this.m_OnWindowOpenDelegate == null)
            {
                return;
            }
            this.m_OnWindowOpenDelegate(obj0);
        }

        public void OnWindowClose([In] object obj0)
        {
            if (this.m_OnWindowCloseDelegate == null)
            {
                return;
            }
            this.m_OnWindowCloseDelegate(obj0);
        }

        public void OnWindowUpdate([In] object obj0)
        {
            if (this.m_OnWindowUpdateDelegate == null)
            {
                return;
            }
            this.m_OnWindowUpdateDelegate(obj0);
        }

        public void OnControlLevelChangeRequest([In] object obj0, [In] CTRL_LEVEL obj1)
        {
            if (this.m_OnControlLevelChangeRequestDelegate == null)
            {
                return;
            }
            this.m_OnControlLevelChangeRequestDelegate(obj0, obj1);
        }

        public void OnGraphicsStreamPaused()
        {
            if (this.m_OnGraphicsStreamPausedDelegate == null)
            {
                return;
            }
            this.m_OnGraphicsStreamPausedDelegate();
        }

        public void OnGraphicsStreamResumed()
        {
            if (this.m_OnGraphicsStreamResumedDelegate == null)
            {
                return;
            }
            this.m_OnGraphicsStreamResumedDelegate();
        }

        public void OnChannelDataReceived([In] object obj0, [In] int obj1, [In] string obj2)
        {
            if (this.m_OnChannelDataReceivedDelegate == null)
            {
                return;
            }
            this.m_OnChannelDataReceivedDelegate(obj0, obj1, obj2);
        }

        public void OnChannelDataSent([In] object obj0, [In] int obj1, [In] int obj2)
        {
            if (this.m_OnChannelDataSentDelegate == null)
            {
                return;
            }
            this.m_OnChannelDataSentDelegate(obj0, obj1, obj2);
        }

        public void OnSharedRectChanged([In] int obj0, [In] int obj1, [In] int obj2, [In] int obj3)
        {
            if (this.m_OnSharedRectChangedDelegate == null)
            {
                return;
            }
            this.m_OnSharedRectChangedDelegate(obj0, obj1, obj2, obj3);
        }

        public void OnFocusReleased([In] int obj0)
        {
            if (this.m_OnFocusReleasedDelegate == null)
            {
                return;
            }
            this.m_OnFocusReleasedDelegate(obj0);
        }

        public void OnSharedDesktopSettingsChanged([In] int obj0, [In] int obj1, [In] int obj2)
        {
            if (this.m_OnSharedDesktopSettingsChangedDelegate == null)
            {
                return;
            }
            this.m_OnSharedDesktopSettingsChangedDelegate(obj0, obj1, obj2);
        }
    }
}