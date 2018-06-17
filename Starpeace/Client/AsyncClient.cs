using System;
using System.Net.Sockets;
namespace Starpeace.Client
{
    /**
     * The client is needed for communication with
     * the main database, we may also decide to push
     * data into cache for example new building data.
     * 
     * We should be dual mode to support both ipv4 and 6
     * again as with the server this ensures we are
     * capable of backwards compatiability but fully
     * geared for future changes to ipv6.
     * 
     * The client will need to run on its own thread
     */


    public class AsyncClient
    {
        public AsyncClient()
        {
        }


    }
}
