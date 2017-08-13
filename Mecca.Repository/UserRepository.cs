using Mecca.DomainModel;
using Mecca.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecca.Repository
{
    //This class should be interacting with the DB
    public class UserRepository : IUser
    {
         public bool AuthenticateUser(UserDomainModel user)
         {
             //Actual Database logic goes here
             if (user.UserName.ToLower() == "admin" && user.Password == "admin")
                 return true;
             else
                 return false;

           
         }
    }
}
