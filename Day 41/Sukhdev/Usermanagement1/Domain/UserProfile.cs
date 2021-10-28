namespace Usermanagement1.Domain
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public User user { get; set; }  //navigation or referential integrity 
           
    }
}