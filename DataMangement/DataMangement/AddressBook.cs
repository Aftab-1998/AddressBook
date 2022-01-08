using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class AddressBook
    {
        List<Contact> addressList = new List<Contact>();
        public void Display() // This Method wii Display the Details
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);
            }
        }
      
    }
}
