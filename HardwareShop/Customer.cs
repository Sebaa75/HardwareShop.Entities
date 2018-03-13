using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HardwareShop
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName,LastName);
            }
            set { }
        }
    }

}

