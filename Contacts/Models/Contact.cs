using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}