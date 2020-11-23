using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE412_Group17
{
    class User
    {
        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + "Address: " + Address + ", Phone Number: " + PhoneNumber + ", Email Address: " + Email;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
