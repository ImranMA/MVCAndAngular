using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using Mecca.IOCContainer;

namespace Mecca.Models
{
    //Model base resolve the Interface based in IOC container
    public abstract class ModelBase
    {
        public T Resolve<T>() where T : class
        {
            var type = MeccaUnityContainer.Instance.Resolve<T>();
            if (type == null)
            {
                throw new NullReferenceException("Unable to resolve type with service locator; type " + typeof(T).Name);
            }

            return type;
        }
    }
}