using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestWindowsService
{
    class MessageExchangeServer
    {
        // We use TCP network protocol. Used namespaces System.Net.Sockets from .NET Framework
        private TcpListener m_server;
        private const int port = 666;
        private Thread thread;

        public MessageExchangeServer()
        {
            //m_server = new TcpListener(IPAddress.Any, port);
        }

        public void StartServer()
        {
            try
            {
                m_server = new TcpListener(IPAddress.Any, port);
                m_server.Start();

                Console.WriteLine("[INFO] Server is runing. Waiting for a connection...");

                thread = new Thread(new ThreadStart(ExchangeThread));
                thread.Start();

            } catch (SocketException e) {
                Console.WriteLine("[ERROR] Server not runing. SocketException: {0}", e);
            } catch (System.IO.IOException e) {
                Console.WriteLine("[WARNING] Most likely the client has disconnected. Error reading data: {0}.", e.Message);
            } 
        }

        public void StopServer()
        {
            if (thread != null)
            {
                thread.Abort();
            }

            if (m_server != null)
            {
                m_server.Stop();
            }
        }

        public void ExchangeThread()
        {
            // endless cycle. main thread
            // Accept conection client
            TcpClient client = m_server.AcceptTcpClient();
            NetworkStream stream = client.GetStream();

            try
            {
                while (true)
                {
                    Byte[] bytes = new Byte[256];

                    // Receive message from client
                    int i = stream.Read(bytes, 0, bytes.Length);
                    string receiveMessage = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("[INFO] Received message from client: {0}", receiveMessage);

                    // Send responce
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(String.Format("MessageExchangeService: I got your messge"));
                    stream.Write(msg, 0, msg.Length);
                }
            } catch(System.IO.IOException e) {
                Console.WriteLine("[WARNING] Most likely the client has disconnected. Error reading data: {0}.", e.Message);
                client.Close();
            } finally
            {
                ExchangeThread();
            }
        }
    }
}
