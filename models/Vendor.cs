using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE412_Group17.models
{
    class Vendor
    {
        public override string ToString()
        {
            return VendorName;
        }
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
       }
}
