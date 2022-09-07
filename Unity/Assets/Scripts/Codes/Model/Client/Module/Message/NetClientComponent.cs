﻿using System.Net;
using System.Net.Sockets;
using ET.Server;

namespace ET.Client
{
    public struct NetClientComponentOnRead
    {
        public Session Session;
        public long ActorId;
        public object Message;
    }
    
    [ComponentOf(typeof(Scene))]
    public class NetClientComponent: Entity, IAwake<AddressFamily>, IDestroy
    {
        public int ServiceId;
    }
}