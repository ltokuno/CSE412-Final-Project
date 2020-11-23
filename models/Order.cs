using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE412_Group17
{
    class Order
    {
        public int UserID { get; set; }
        public string ConfirmationNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
    }
}
