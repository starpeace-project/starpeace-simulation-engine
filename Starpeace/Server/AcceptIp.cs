using System;
namespace Starpeace.Server
{
    public struct AcceptIp
    {
        public int Protocol { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
    }
}
