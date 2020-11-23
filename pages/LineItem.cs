using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE412_Group17.pages {
    class LineItem : Item {
        public int quantity { get; set; }

        public override string ToString() {
            return ItemName + "\t" + quantity + " @ " + RetailPrice;
        }
    }
}
