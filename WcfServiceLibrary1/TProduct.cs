using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public class TProduct
    {
        public int Idproduct { get; set; }
        public string Name { get; set; }
        public DateTime Expiration_date { get; set; }

        public TProduct()
        {
            Idproduct = -1;
            Name = "";
            Expiration_date = new DateTime();
        }
    }
}
