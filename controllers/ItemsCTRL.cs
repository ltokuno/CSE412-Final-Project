using CSE412_Group17.dal;
using System;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class ItemsCTRL {

        public List<String> getItemCategories() {
            List<String> output = new List<string>();

            return output;
        }


        public List<Item> geItemsByCategory(string category) {
            List<Item> output = new List<Item>();

            return output;
        }


        public Item getItemByID(int ID) {

            DBSelector selector = new DBSelector();

            return selector.getRow<Item>("SELECT * FROM Item WHERE ItemID=" + ID);
        }

    } //end class
}
