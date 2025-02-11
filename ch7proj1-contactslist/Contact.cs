

namespace ch7proj1_contactslist
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Contact()
        {
        }
        public Contact(int id, string firstName, string lastName, string email, string phone)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
        }
        public string PrintMessage()
        {
            return $"------------------------------------\n" +
                   $"----Current Contact-----------------\n" +
                   $"------------------------------------\n" +
                   $"Name:\t\t{FirstName} {LastName}\n" +
                   $"Email Address:\t{Email}\n" +
                   $"Phone Number:\t{Phone}\n"
                   +
                   $"------------------------------------\n"    ;
        }
    }
}
