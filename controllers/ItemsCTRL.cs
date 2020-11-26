using CSE412_Group17.dal;
using CSE412_Group17.models;
using System;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class ItemsCTRL {

        public List<String> getItemCategories() {
            DBSelector selector = new DBSelector();
            return selector.getRows<String>("SELECT DISTINCT \"Category\" FROM \"Item\"");
        }


        public List<Item> geItemsByCategory(string category) {
            DBSelector selector = new DBSelector();
            return selector.getRows<Item>("SELECT * FROM \"Item\" WHERE \"Category\" = '" + category + "'");
        }


        public Item getItemByID(int ID) {
            DBSelector selector = new DBSelector();
            return selector.getRow<Item>("SELECT * FROM \"Item\" WHERE \"ItemID\"= '" + ID + "'");
        }


        public void addItem(Item theItem, Vendor theVendor) {
            DBModifier modder = new DBModifier();
            DBSelector selector = new DBSelector();

            //put the item in the DB
            modder.modifyRows("INSERT INTO \"Item\"(\"RetailPrice\",\"StockQuantity\",\"ItemName\",\"CostPrice\",\"Category\") VALUES(" +
                theItem.RetailPrice + "," + theItem.StockQuantity + ",'" + theItem.ItemName + "'," + theItem.CostPrice + ",'" + 
                theItem.Category + "')");

            Item newitem = selector.getRow<Item>("SELECT * FROM \"Item\" WHERE \"RetailPrice\" = " + theItem.RetailPrice + 
                " AND \"StockQuantity\" = " + theItem.StockQuantity +
                " AND \"ItemName\" = '" + theItem.ItemName + 
                "' AND \"CostPrice\" = " + theItem.CostPrice + 
                " AND \"Category\" = '" + theItem.Category + "'");

            //add it to the vedor
            modder.modifyRows("INSERT INTO \"Vendor_Items\"(\"VendorID\",\"ItemID\") VALUES( " +
                theVendor.VendorID + "," + newitem.ItemID + ")");
        }

        public void changeItem(Item theItem)
        {
            DBModifier modder = new DBModifier();

            modder.modifyRows("UPDATE \"Item\" SET " +
                "\"StockQuantity\" = " + theItem.StockQuantity + "," +
                "\"ItemName\"  = '" + theItem.ItemName + "'," +
                "\"CostPrice\" = " + theItem.CostPrice + "," +
                "\"RetailPrice\" = " + theItem.RetailPrice + "" +
                " WHERE \"ItemID\" = '" + theItem.ItemID + "'");
        }

    } //end class
}
