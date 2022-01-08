using DataManagement;

class program
{
    Contact contact = new Contact();
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter your Choice Number to Execute the Address Program Press- 1-Contacts");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Contact Information in Format of FirstName, LastName,  City, State, Zip, Ph.No, Email.");
                    Contact newContact = new Contact();
                    newContact.FirstName = Console.ReadLine();
                    newContact.LastName = Console.ReadLine();
                    newContact.City = Console.ReadLine();
                    newContact.State = Console.ReadLine();
                    newContact.Zip = Console.ReadLine();
                    newContact.PhoneNumber = Console.ReadLine();
                    newContact.Email = Console.ReadLine();
                    break;
                case 2:
                    flag = false;
                    break;
            }
        }

    }
}
