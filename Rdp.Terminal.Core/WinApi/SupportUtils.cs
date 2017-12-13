using System;

namespace Rdp.Terminal.Core.WinApi
{
    /// <summary>
    /// RDP support methods.
    /// </summary>
    public static class SupportUtils
    {
        /// <summary>
        /// Check operation system support.
        /// </summary>
        /// <returns>Support state..</returns>
        public static bool CheckOperationSytem()
        {
            var osVersion = Environment.OSVersion;
            int major = osVersion.Version.Major;

            return osVersion.Platform == PlatformID.Win32NT && major >= 6;
        }
    }
}