using CSE412_Group17.dal;
using CSE412_Group17.models;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class VendorCTRL {

        public List<Vendor> getAllVendors() {
            List<Vendor> output;

            DBSelector selector = new DBSelector();

            output = selector.getRows<Vendor>("SELECT * FROM Vendor");

            return output;
        }

        public Vendor getVendorByName(string name) {
            Vendor output;

            DBSelector selector = new DBSelector();

            output = selector.getRow<Vendor>("SELECT * FROM Vendor WHERE VendorName=" + name);

            return output;
        }

        public Vendor getVendorByID (int id) {
            Vendor output;

            DBSelector selector = new DBSelector();

            output = selector.getRow<Vendor>("SELECT * FROM Vendor WHERE VendorName=" + id);

            return output;
        }

    } //end class
}
