using System.Collections.Generic;

namespace ECommerceTopDown_GiorgioBestDown_.DAL
{
    public class User
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationCode { get; set; }
        public List<Address> Addresses { get; set; }
    }
}