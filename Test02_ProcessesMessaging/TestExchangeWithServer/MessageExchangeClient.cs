using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestExchangeWithServer
{
    class MessageExchangeClient
    {
        // We use TCP network protocol. Used namespaces System.Net.Sockets from .NET Framework
        TcpClient m_client;
        String IpServer = "127.0.0.1";
        int port = 666;

        public MessageExchangeClient()
        {
            // Wrap for exceptions
            try
            {
                // Create new TCP client and connect to server
                m_client = new TcpClient(IpServer, port);

                Console.WriteLine("[INFO] Successful connection to the server.");
                Console.WriteLine("___________________________");

                // Create new Thread for server listening
                Thread thread = new Thread(new ParameterizedThreadStart(ServerThreadListener));
                // Thread parameter - network stream
                thread.Start(m_client.GetStream());                

                // A cycle for closing the client. You must press the ESC button to close the streams and stop the broadcast.
                bool isClientRuning = true;
                while (isClientRuning)
                {
                    var command = Console.ReadLine();
                    if (command.Equals("q"))
                    {
                        isClientRuning = false;
                        Console.WriteLine("[INFO] Close services on client.");
                        
                        // Stop listening thread
                        thread.Abort();
                        // close TCP connection
                        m_client.Close();
                    } else
                    {
                        // Translate the identifier to bytes. Preparation for sending to the server.
                        Byte[] data = System.Text.Encoding.ASCII.GetBytes("Knock-knock");
                        // Get network stream for write bytes
                        NetworkStream stream = m_client.GetStream();
                        // Write data
                        stream.Write(data, 0, data.Length);                        
                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("[ERROR] Client not running. SocketException: {0}", e.Message);
                return;
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("[WARNING] Most likely the server has disconnected. Error reading data: {0}.", e.Message);
                return;
            }
            
        }

        // Start server listener
        static void ServerThreadListener(Object _obj)
        {
            new ServerListener((NetworkStream)_obj);
        }
    }

    // Class for server listener
    class ServerListener
    {
        public ServerListener(NetworkStream _stream)
        {
            // init arrays for messages
            Byte[] bytes = new Byte[256];
            String data = null;
            int i;
            // try read stream
            try
            {
                while ((i = _stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("{0}", data);
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("[WARNING] Most likely the server has disconnected. Error reading data: {0}.", e.Message);
                return;
            }
        }
    }
}
