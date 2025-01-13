using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Packet
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public byte[] Message { get; set; }
    }
    //public Packet() { }
    //public Packet(string name, string code, byte[] message)
    //{
    //    this.Name = name;
    //    this.Code = code;
    //    this.Message = message;

    //}
}
