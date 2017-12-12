using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rdp.Terminal.Core.Client.Data
{
    /// <summary>
    /// Rdp viewer interaction methods.
    /// </summary>
    public interface IRemoteTerminal
    {
        /// <summary>
        /// Starts the actual connection to the sharer.
        /// </summary>
        /// <param name="connectionString">The connection string used to connect to the sharer and authenticate the viewer.</param>
        /// <param name="groupName">Name for the viewer. The name is sent to the sharer and other viewers. The string is limited to 255 characters.</param>
        /// <param name="passowrd">Password used for authentication. The password is sent out-of-band from the sharer.</param>
        void Connect(string connectionString, string groupName, string passowrd);

        /// <summary>
        /// Initiates a listener for accepting reverse connections from the sharer to the viewer, or obtains the 
        /// connection string that the sharer uses to reverse connect to the viewer.
        /// </summary>
        /// <param name="connectionString">The connection string that the sharer will use to start the listener.</param>
        /// <param name="groupName">The user name to use for authentication.</param>
        /// <param name="passowrd">The password to use for authentication.</param>
        /// <returns>
        /// A pointer to a BSTR that receives the connection string that the sharer can use to reverse connect to the viewer 
        /// by using the IRDPSRAPISharingSession::ConnectToClient method.
        /// </returns>
        /// <remarks>https://msdn.microsoft.com/en-us/library/aa373359(v=vs.85).aspx</remarks>
        string StartReverseConnectListener(string connectionString, string groupName, string passowrd);

        /// <summary>
        /// Initiates a disconnect of the viewer from the sharer.
        /// </summary>
        void Disconnect();
    }
}
