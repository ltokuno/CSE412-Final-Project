using CSE412_Group17.dal;
using System.Collections.Generic;
using System.Text;

namespace CSE412_Group17.controllers {
    class OrderCTRL {

        public Order getOrderByID(int ID) {
            Order output;

            DBSelector selector = new DBSelector();

            output = selector.getRow<Order>("SELECT * FROM Order WHERE OrderID=" + ID);

            return output;
        }

        public List<Order> getOrdersByUser(int userID) {
            List<Order> output;

            DBSelector selector = new DBSelector();

            output = selector.getRows<Order>("SELECT * FROM Order WHERE OrderID=" + userID);

            return output;
        }

        public List<Item> getOrderItems(int oderID) {
            List<Item> output;

            DBSelector selector = new DBSelector();

            List<ItemList> itemList = selector.getRows<ItemList>("SELECT * FROM ItemList WHERE OrderID=" + oderID);

            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < itemList.Count; ++i) {
                sb.Append("'");
                sb.Append(itemList[i].ItemID);
                sb.Append("'");

                //add a comma if it's not the last id
                if (i < (itemList.Count - 1)) {
                    sb.Append(",");
                }
            }

            output = selector.getRows<Item>("SELECT * FROM Item WHERE ItemID IN (" + sb.ToString() + ")");

            return output;
        }

    } //end class
}
