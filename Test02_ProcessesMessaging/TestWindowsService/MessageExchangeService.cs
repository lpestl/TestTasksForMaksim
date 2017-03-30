using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsService
{
    public partial class MessageExchangeService : ServiceBase
    {
        public MessageExchangeService()
        {
            InitializeComponent();
        }

        private MessageExchangeServer server;

        protected override void OnStart(string[] args)
        {
            // Create the Server Object ans Start it.
            server = new MessageExchangeServer();
            server.StartServer();
        }

        protected override void OnStop()
        {
            // Stop the Server. Release it.
            server.StopServer();
            server = null;
        }
    }
}
