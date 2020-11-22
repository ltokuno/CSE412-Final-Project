using CSE412_Group17.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSE412_Group17.controllers {
    class OrderCTRL {

        public Order getOrderByID(int ID) {

            DBSelector selector = new DBSelector();

            return selector.getRow<Order>("SELECT * FROM Order WHERE OrderID=" + ID);
        }


        public List<Order> getOrdersByUser(int userID) {

            DBSelector selector = new DBSelector();

            return selector.getRows<Order>("SELECT * FROM Order WHERE OrderID=" + userID);
        }


        public List<Item> getOrderItems(int oderID) {

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

            return selector.getRows<Item>("SELECT * FROM Item WHERE ItemID IN (" + sb.ToString() + ")");

        }


        public List<ItemList> getORderLineItems(int orderID) {
            DBSelector selector = new DBSelector();

            return selector.getRows<ItemList>("SELCT * FROM ItemList Where OrderID=" + orderID);
        }


        public string generateConfirmationNumber() {
            return Guid.NewGuid().ToString();
        }


        public void saveOrder(Order theOrder, List<ItemList> itemLists) {

            DBModifier modder = new DBModifier();

            //todo: OrderDateTime should come from the Order object
            modder.modifyRows("INSERT INTO Order (ConfirmationNumber, OrderDateTime, TotalPrice, UserID) VALUES (" +
                theOrder.ConfirmationNumber + "," + DateTime.Now + "," + theOrder.TotalPrice + "," + theOrder.UserID + ")");

            foreach (ItemList i in itemLists) {
                modder.modifyRows("INSERT INTO ItemList (OrderID, ItemID, Quantity) VALUES (" +
                    i.OrderID + "," + i.ItemID + "," + i.Quantity + ")");
            }
        }

    } //end class
}
