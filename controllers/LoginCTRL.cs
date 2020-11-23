using CSE412_Group17.dal;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class LoginCTRL {

        public Login getLoginByUserID(int userID) {
            DBSelector selector = new DBSelector();

            return selector.getRow<Login>("SELECT * FROM Login WHERE ID = " + userID);
        }


        public List<Login> getAllLogins() {
            DBSelector selector = new DBSelector();
            return selector.getRows<Login>("SELECT * FROM Login");
        }


        public void saveLoginInfo(string username, string password) {
            
            DBModifier modder = new DBModifier();

            modder.modifyRows("INSERT INTO Login (UserName, Password) VALUES (" + username + "," + password + ")");

        }


        public void setPassword(int loginID, string password) {
            DBModifier modder = new DBModifier();

            modder.modifyRows("UPDATE Login SET Passsword = " + password + " WHERE ID = " + loginID);

        }

    } //end class
}
