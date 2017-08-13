using Mecca.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecca.Interface
{
    //User Interface is implement by UserRepository
    public interface IUser
    {

          bool AuthenticateUser(UserDomainModel user);
    }
}
