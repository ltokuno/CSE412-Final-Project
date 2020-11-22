using CSE412_Group17.dal;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class UserCTRL {

        public List<User> getAllUsers() {
            List<User> output;

            DBSelector selector = new DBSelector();

            output = selector.getRows<User>("SELECT * FROM User");

            return output;
        }


        public User getUserByID(int ID) {
            User output;

            DBSelector selector = new DBSelector();

            output = selector.getRow<User>("SELECT * FROM User WHERE ID=" + ID);

            return output;
        }


        public void addUser(User theUser) {
            DBModifier modder = new DBModifier();

            modder.modifyRows("INSERT INTO User(FirstName, LastName, Email, PhoneNumber, DateOfBirth, IsAdmin, Gender, Address) VALUES(" 
                + theUser.FirstName + "," + theUser.LastName + "," + theUser.Email + "," + theUser.PhoneNumber + "," + theUser.DateOfBirth + ","
                + theUser.IsAdmin + "," + theUser.Gender + "," + theUser.Address);
        }

    } //end class
}
