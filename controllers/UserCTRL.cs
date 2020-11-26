﻿using CSE412_Group17.dal;
using System.Collections.Generic;

namespace CSE412_Group17.controllers {
    class UserCTRL {

        public List<User> getAllUsers() {
            DBSelector selector = new DBSelector();

            return selector.getRows<User>("SELECT * FROM \"User\"");
        }


        public User getUserByID(int ID) {
            DBSelector selector = new DBSelector();

            return selector.getRow<User>("SELECT * FROM \"User\" WHERE \"ID\"= '" + ID + "'");
        }


        public void addUser(User theUser, int loginId) {
            DBModifier modder = new DBModifier();

            modder.modifyRows("INSERT INTO \"User\"(\"ID\", \"FirstName\", \"LastName\", \"Email\", \"PhoneNumber\", \"DateOfBirth\", \"IsAdmin\", \"Gender\", \"Address\") VALUES('"
                + loginId + "','" + theUser.FirstName + "','" + theUser.LastName + "','" + theUser.Email + "','" + theUser.PhoneNumber + "','" + theUser.DateOfBirth.Date + "','"
                + theUser.IsAdmin + "','" + theUser.Gender + "','" + theUser.Address + "')");
        }

        public void changeUser(User theUser) {
            DBModifier modder = new DBModifier();

            modder.modifyRows("UPDATE \"User\" SET " + 
                "\"FirstName\" = '" + theUser.FirstName + "'," +
                "\"LastName\"  = '" + theUser.LastName + "'," +
                "\"Email\" = '" + theUser.Email + "'," +
                "\"PhoneNumber\" = '" +theUser.PhoneNumber + "'," +
                "\"DateOfBirth\" = '" + theUser.DateOfBirth.Date + "'," + 
                "\"IsAdmin\" = '" + theUser.IsAdmin + "'," +
                "\"Gender\" = '" + theUser.Gender + "'," + 
                "\"Address\" = '" + theUser.Address + "'" + 
                " WHERE \"ID\" = '" + theUser.ID + "'");
        }

        public void deleteUser(User user)
        {
            DBModifier modder = new DBModifier();

            modder.modifyRows("DELETE FROM \"User\"" +
                " WHERE \"ID\" = '" + user.ID + "'");

            modder.modifyRows("DELETE FROM \"Login\"" +
                " WHERE \"ID\" = '" + user.ID + "'");
        }


    } //end class
}
