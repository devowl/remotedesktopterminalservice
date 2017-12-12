namespace AxRDPCOMAPILib
{
    internal class _IRDPSessionEvents_OnSharedDesktopSettingsChangedEvent
    {
        public int width;

        public int height;

        public int colordepth;

        public _IRDPSessionEvents_OnSharedDesktopSettingsChangedEvent(int width, int height, int colordepth)
        {
            this.width = width;
            this.height = height;
            this.colordepth = colordepth;
        }
    }
}