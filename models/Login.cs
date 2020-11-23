using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE412_Group17
{
    class Login
    {
        public override string ToString()
        {
            return "ID: " + ID +",  Username: " + UserName + ",   Password: ********";
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }
    }
}
