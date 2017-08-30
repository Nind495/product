using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace WcfServiceLibrary1
{
    [DataContract]
    public class Tclient
    {
        [DataMember]
        public int Idclient { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
    }
};



