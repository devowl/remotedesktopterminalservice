using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace RDPCOMAPILib
{
    internal sealed class _IRDPSessionEvents_EventProvider : _IRDPSessionEvents_Event, IDisposable
    {
        private IConnectionPointContainer m_ConnectionPointContainer;

        private ArrayList m_aEventSinkHelpers;

        private IConnectionPoint m_ConnectionPoint;

        public _IRDPSessionEvents_EventProvider(object obj)
        {
            this.m_ConnectionPointContainer = (IConnectionPointContainer)obj;
        }

        public void add_OnAttendeeConnected([In] _IRDPSessionEvents_OnAttendeeConnectedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnAttendeeConnectedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnAttendeeConnected([In] _IRDPSessionEvents_OnAttendeeConnectedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnAttendeeConnectedDelegate != null &&
                        ((aEventSinkHelper.m_OnAttendeeConnectedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnAttendeeDisconnected([In] _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnAttendeeDisconnectedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnAttendeeDisconnected([In] _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnAttendeeDisconnectedDelegate != null &&
                        ((aEventSinkHelper.m_OnAttendeeDisconnectedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnAttendeeUpdate([In] _IRDPSessionEvents_OnAttendeeUpdateEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnAttendeeUpdateDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnAttendeeUpdate([In] _IRDPSessionEvents_OnAttendeeUpdateEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnAttendeeUpdateDelegate != null &&
                        ((aEventSinkHelper.m_OnAttendeeUpdateDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) !=
                        0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnConnectionEstablished([In] _IRDPSessionEvents_OnConnectionEstablishedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnConnectionEstablishedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnConnectionEstablished([In] _IRDPSessionEvents_OnConnectionEstablishedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnConnectionEstablishedDelegate != null &&
                        ((aEventSinkHelper.m_OnConnectionEstablishedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnConnectionFailed([In] _IRDPSessionEvents_OnConnectionFailedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnConnectionFailedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnConnectionFailed([In] _IRDPSessionEvents_OnConnectionFailedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnConnectionFailedDelegate != null &&
                        ((aEventSinkHelper.m_OnConnectionFailedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnConnectionTerminated([In] _IRDPSessionEvents_OnConnectionTerminatedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnConnectionTerminatedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnConnectionTerminated([In] _IRDPSessionEvents_OnConnectionTerminatedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnConnectionTerminatedDelegate != null &&
                        ((aEventSinkHelper.m_OnConnectionTerminatedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnConnectionAuthenticated([In] _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnConnectionAuthenticatedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnConnectionAuthenticated([In] _IRDPSessionEvents_OnConnectionAuthenticatedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnConnectionAuthenticatedDelegate != null &&
                        ((aEventSinkHelper.m_OnConnectionAuthenticatedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnError([In] _IRDPSessionEvents_OnErrorEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnErrorDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnError([In] _IRDPSessionEvents_OnErrorEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnErrorDelegate != null &&
                        ((aEventSinkHelper.m_OnErrorDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnApplicationOpen([In] _IRDPSessionEvents_OnApplicationOpenEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnApplicationOpenDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnApplicationOpen([In] _IRDPSessionEvents_OnApplicationOpenEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnApplicationOpenDelegate != null &&
                        ((aEventSinkHelper.m_OnApplicationOpenDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnApplicationClose([In] _IRDPSessionEvents_OnApplicationCloseEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnApplicationCloseDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnApplicationClose([In] _IRDPSessionEvents_OnApplicationCloseEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnApplicationCloseDelegate != null &&
                        ((aEventSinkHelper.m_OnApplicationCloseDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnApplicationUpdate([In] _IRDPSessionEvents_OnApplicationUpdateEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnApplicationUpdateDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnApplicationUpdate([In] _IRDPSessionEvents_OnApplicationUpdateEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnApplicationUpdateDelegate != null &&
                        ((aEventSinkHelper.m_OnApplicationUpdateDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnWindowOpen([In] _IRDPSessionEvents_OnWindowOpenEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnWindowOpenDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnWindowOpen([In] _IRDPSessionEvents_OnWindowOpenEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnWindowOpenDelegate != null &&
                        ((aEventSinkHelper.m_OnWindowOpenDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) !=
                        0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnWindowClose([In] _IRDPSessionEvents_OnWindowCloseEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnWindowCloseDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnWindowClose([In] _IRDPSessionEvents_OnWindowCloseEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnWindowCloseDelegate != null &&
                        ((aEventSinkHelper.m_OnWindowCloseDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) !=
                        0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnWindowUpdate([In] _IRDPSessionEvents_OnWindowUpdateEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnWindowUpdateDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnWindowUpdate([In] _IRDPSessionEvents_OnWindowUpdateEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnWindowUpdateDelegate != null &&
                        ((aEventSinkHelper.m_OnWindowUpdateDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) !=
                        0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnControlLevelChangeRequest(
            [In] _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnControlLevelChangeRequestDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnControlLevelChangeRequest(
            [In] _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnControlLevelChangeRequestDelegate != null &&
                        ((aEventSinkHelper.m_OnControlLevelChangeRequestDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnGraphicsStreamPaused([In] _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnGraphicsStreamPausedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnGraphicsStreamPaused([In] _IRDPSessionEvents_OnGraphicsStreamPausedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnGraphicsStreamPausedDelegate != null &&
                        ((aEventSinkHelper.m_OnGraphicsStreamPausedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnGraphicsStreamResumed([In] _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnGraphicsStreamResumedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnGraphicsStreamResumed([In] _IRDPSessionEvents_OnGraphicsStreamResumedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnGraphicsStreamResumedDelegate != null &&
                        ((aEventSinkHelper.m_OnGraphicsStreamResumedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnChannelDataReceived([In] _IRDPSessionEvents_OnChannelDataReceivedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnChannelDataReceivedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnChannelDataReceived([In] _IRDPSessionEvents_OnChannelDataReceivedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnChannelDataReceivedDelegate != null &&
                        ((aEventSinkHelper.m_OnChannelDataReceivedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnChannelDataSent([In] _IRDPSessionEvents_OnChannelDataSentEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnChannelDataSentDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnChannelDataSent([In] _IRDPSessionEvents_OnChannelDataSentEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnChannelDataSentDelegate != null &&
                        ((aEventSinkHelper.m_OnChannelDataSentDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnSharedRectChanged([In] _IRDPSessionEvents_OnSharedRectChangedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnSharedRectChangedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnSharedRectChanged([In] _IRDPSessionEvents_OnSharedRectChangedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnSharedRectChangedDelegate != null &&
                        ((aEventSinkHelper.m_OnSharedRectChangedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnFocusReleased([In] _IRDPSessionEvents_OnFocusReleasedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnFocusReleasedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnFocusReleased([In] _IRDPSessionEvents_OnFocusReleasedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnFocusReleasedDelegate != null &&
                        ((aEventSinkHelper.m_OnFocusReleasedDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) !=
                        0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_OnSharedDesktopSettingsChanged(
            [In] _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                _IRDPSessionEvents_SinkHelper eventsSinkHelper = new _IRDPSessionEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_OnSharedDesktopSettingsChangedDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_OnSharedDesktopSettingsChanged(
            [In] _IRDPSessionEvents_OnSharedDesktopSettingsChangedEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                {
                    return;
                }
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                {
                    return;
                }
                do
                {
                    _IRDPSessionEvents_SinkHelper aEventSinkHelper =
                        (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (aEventSinkHelper.m_OnSharedDesktopSettingsChangedDelegate != null &&
                        ((aEventSinkHelper.m_OnSharedDesktopSettingsChangedDelegate.Equals((object)obj0) ? 1 : 0) &
                         (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                    {
                        ++index;
                    }
                } while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:
                ;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void Finalize()
        {
            lock (this)
            {
                try
                {
                    if (this.m_ConnectionPoint != null)
                    {
                        int count = this.m_aEventSinkHelpers.Count;
                        int num = 0;
                        if (0 < count)
                        {
                            do
                            {
                                _IRDPSessionEvents_SinkHelper iRDPSessionEvents_SinkHelper =
                                    (_IRDPSessionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
                                this.m_ConnectionPoint.Unadvise(iRDPSessionEvents_SinkHelper.m_dwCookie);
                                num++;
                            } while (num < count);
                        }
                        Marshal.ReleaseComObject(this.m_ConnectionPoint);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public void Dispose()
        {
            this.Finalize();
            GC.SuppressFinalize(this);
        }

        private void Init()
        {
            IConnectionPoint connectionPoint = null;
            Guid guid = new Guid(
                new byte[]
                {
                    66,
                    112,
                    169,
                    152,
                    152,
                    102,
                    233,
                    64,
                    142,
                    253,
                    179,
                    32,
                    9,
                    144,
                    0,
                    75
                });
            m_ConnectionPointContainer.FindConnectionPoint(ref guid, out connectionPoint);
            m_ConnectionPoint = (IConnectionPoint)connectionPoint;
            m_aEventSinkHelpers = new ArrayList();
        }
    }
}