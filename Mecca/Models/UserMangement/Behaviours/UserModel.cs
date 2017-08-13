using Mecca.DomainModel;
using Mecca.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mecca.Models
{
    public partial class UserModel : ModelBase
    {

        protected IUser user;


        //User Interface is resolved here .
        public UserModel()
        {
            this.user = this.Resolve<IUser>();           
        }



        //User Is authenticated here, and Interface method is called from model
        public bool AuthenticateUser(UserModel user)
        {
            try {
                return this.user.AuthenticateUser(
                     Common.Transform.FromObjectToObject<UserDomainModel, UserModel>(user));
            }
            catch(Exception ex){
                throw ex;
            }
          
        }
    }
}