using System.Windows;

using Rdp.Terminal.Core.Client.Data;
using Rdp.Terminal.Core.Client.Models;

namespace Rdp.Terminal.Core.Client.Controls
{
    /// <summary>
    /// Interaction logic for RemoteTerminal.xaml
    /// </summary>
    public partial class RemoteTerminal
    {
        /// <summary>
        /// RDP session control manager.
        /// </summary>
        public static DependencyProperty RdpManagerProperty;

        internal readonly RemoteTeminalManager Manager;

        static RemoteTerminal()
        {
            RemoteTeminalBehavior.InitializeDependencyProperties();
        }

        /// <summary>
        /// Constructor <see cref="RemoteTerminal"/>.
        /// </summary>
        public RemoteTerminal()
        {
            DataContext = this;
            InitializeComponent();
            Manager = new RemoteTeminalManager(RdpViewer);
        }

        /// <summary>
        /// Manager instance.
        /// </summary>
        public RdpManager RdpManager
        {
            get
            {
                return (RdpManager)GetValue(RdpManagerProperty);
            }

            set
            {
                SetValue(RdpManagerProperty, value);
            }
        }
    }
}