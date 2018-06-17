using System;
namespace Starpeace.Server
{
    /**
     * The Async nature of this server is needed to enable
     * expansion of caching services should it be needed.
     * 
     * The server should be dual mode compatible so that
     * whilst still supporting ipv4 we are geared towards
     * ipv6, then there wont be any sudden need to re-dev
     * should we find service providers deciding the time
     * has come to retire ipv4.
     * 
     * It does not need to be a complex server, although it
     * will need to run on its own thread and obviously spawn
     * threads for handling multiple connections.
     * 
     * The server will use a share protocol for both client and
     * server, however clients connecting need to be in a predifined
     * list of servers that can connect to us.
     */


    public class AsyncServer
    {
        public AsyncServer()
        {
        }
    }
}
