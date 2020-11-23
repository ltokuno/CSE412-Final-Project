using CSE412_Group17.dal;
using CSE412_Group17.models;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class VendorCTRL {

        public List<Vendor> getAllVendors() {

            DBSelector selector = new DBSelector();

            return selector.getRows<Vendor>("SELECT * FROM \"Vendor\"");
        }


        public Vendor getVendorByName(string name) {

            DBSelector selector = new DBSelector();

            return selector.getRow<Vendor>("SELECT * FROM \"Vendor\" WHERE \"VendorName\"='" + name + "'");
        }


        public Vendor getVendorByID (int id) {

            DBSelector selector = new DBSelector();

            return selector.getRow<Vendor>("SELECT * FROM \"Vendor\" WHERE \"VendorName\"='" + id + "'");
        }


        public void addVendor(Vendor theVendor) {
            DBModifier modder = new DBModifier();

            modder.modifyRows("INSERT INTO \"Vendor\"(\"VendorName\", \"VendorAdress\") VALUES('"
                + theVendor.VendorName + "','" + theVendor.VendorAddress + "')");
        }


        public void addItemToVendor(int vendorID, int itemID) {
            DBModifier modder = new DBModifier();
            modder.modifyRows("INSERT INTO \"Vendor_Items\"(\"VedndorID\",\"ItemID\") VALUES(' " +
                itemID + "'," + vendorID + "')");
        }


    } //end class
}
