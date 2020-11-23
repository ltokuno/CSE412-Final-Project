using CSE412_Group17.dal;
using System;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class ItemsCTRL {

        public List<String> getItemCategories() {
            DBSelector selector = new DBSelector();
            return selector.getRows<String>("SELCT UNIQUE Category FROM Item");
        }


        public List<Item> geItemsByCategory(string category) {
            DBSelector selector = new DBSelector();
            return selector.getRows<Item>("SELCT * FROM Item WHERE Category = " + category);
        }


        public Item getItemByID(int ID) {
            DBSelector selector = new DBSelector();
            return selector.getRow<Item>("SELECT * FROM Item WHERE ItemID=" + ID);
        }

    } //end class
}
