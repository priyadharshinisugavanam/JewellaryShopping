using System;
namespace JewellaryShopping.Entity
{
   public  class User
    {
        public string userID { get; set; }
        public string password { get; set; }
        public string conformPassword { get; set; }
        public string mailId { get; set; }
        public string role { get; set; }
        public string phoneNumber { get; set; }
        public User(string userID, string password, string phoneNumber, string mailId)
        {
            this.userID = userID;
            this.password = password;
            this.mailId = mailId;
            this.phoneNumber = phoneNumber;

        }
        public User(string userID, string password)
        {
            this.userID = userID;
            this.password = password;

        }
        public User(string userID)
        {
            this.userID = userID;
        }
    }
}
