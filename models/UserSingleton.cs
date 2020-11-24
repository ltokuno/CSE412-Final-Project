using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE412_Group17.models
{
    class UserSingleton

    {
        private static User user;
        private static UserSingleton _instance;

        protected UserSingleton(User newUser)
        {
            user = newUser;
        }

        public static UserSingleton Instance(User newUser)
        {

            if (_instance == null)
            {
                _instance = new UserSingleton(newUser);
            }

            return _instance;
        }

        public static void LogOutUser()
        {
            _instance = null;
        }

        public static User GetUser()
        {
            return user;
        }
    }
}
