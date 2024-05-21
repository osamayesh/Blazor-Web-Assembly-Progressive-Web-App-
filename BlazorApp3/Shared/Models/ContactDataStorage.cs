using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp3.Shared.Models
{
    public class ContactDataStorage
    {
        private List<Contact> contacts = new List<Contact>();

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public void AddContact(Contact contact)
        {
            contact.Id = contacts.Count > 0 ? contacts.Max(c => c.Id) + 1 : 1;
            contacts.Add(contact);
        }

        public Contact GetContact(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateContact(Contact contact)
        {
            var existingContact = GetContact(contact.Id);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.PhoneNumber = contact.PhoneNumber;
            }
        }

        public void DeleteContact(int id)
        {
            var contact = GetContact(id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
        }
    }
}

