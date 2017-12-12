using System;

namespace Rdp.Terminal.Core.Common
{
    /// <summary>
    /// Message arguments.
    /// </summary>
    public class MessageArgs : EventArgs
    {
        /// <summary>
        /// Constructor <see cref="MessageArgs"/>.
        /// </summary>
        public MessageArgs(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Message text.
        /// </summary>
        public string Text { get; private set; }
    }
}