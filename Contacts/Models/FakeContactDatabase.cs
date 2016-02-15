using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
    public class FakeContactDatabase
    {
        private static List<Contact> _contacts = new List<Contact>();

        public List<Contact>GetAll()
        {
            return _contacts;
        }
        
        public void Add(Contact contact)
        {
            if (_contacts.Any())
                contact.ContactId = _contacts.Max(c => c.ContactId) + 1;
            else
                contact.ContactId = 1;

            _contacts.Add(contact);  
        } 
        
        public void Delete(int id)
        {
            _contacts.RemoveAll(c => c.ContactId == id);
        }

        public void Edit(Contact contact)
        {
            Delete(contact.ContactId);
            _contacts.Add(contact);
        }

        public Contact GetById(int id)
        {
            return _contacts.First(c => c.ContactId == id);
        }
    }
}