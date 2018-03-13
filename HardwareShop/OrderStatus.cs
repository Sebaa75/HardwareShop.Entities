using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HardwareShop
{
    [DataContract]
    public class OrderStatus
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
