using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Mecca.Interface;
using Mecca.Repository;


namespace Mecca.IOCContainer
{
   public  class MeccaUnityManager
    {
        public static void Register()
        {
            MeccaUnityContainer.Instance.RegisterType<IUser, UserRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
