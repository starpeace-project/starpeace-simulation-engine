using System.Text;
using System.Net.Sockets;

namespace Starpeace.ClientServerProtocol
{
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public int BufferSize { get; }
        // Receive buffer.
        public byte[] buffer;
        // Received data string.
        public StringBuilder sb = new StringBuilder();

        public StateObject(int buffer_size=256)
        {
            BufferSize = buffer_size;
            buffer = new byte[buffer_size];
        }
    }
}
