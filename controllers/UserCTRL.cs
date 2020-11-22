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

    } //end class
}
