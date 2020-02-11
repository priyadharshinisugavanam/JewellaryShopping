using System.Data;
using JewellaryShopping.Entity;
using JewellaryShopping.DAL;

namespace JewellaryShopping.BL
{
    public class UserDetails
    {
        Repositary repositary = new Repositary();
        public int SignUp(User user) {
            
            return repositary.SignUp(user);
        }
        public string Login(User user)
        {


            return repositary.Login(user);


        }
        public DataTable ViewDetails()
        {
            return repositary.ViewDetails();
            
        }
        public void DeleteCustomerDetails(string user)
        {
            repositary.DeleteCustomerDetails(user);
        }
        public void UpdateCustomerDetails(string userID, string phoneNumber, string mailId, string role)
        {
            repositary.UpdateCustomerDetails(userID,phoneNumber,mailId,role);
        }
        
            
    }
}
