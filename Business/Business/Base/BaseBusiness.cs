using Ninject;
using System.Reflection;

namespace Business.Business.Base
{
    public class BaseBusiness<T> where T : class
    {
        public T Repository
        {
            get
            {
                StandardKernel kernel = new StandardKernel();
                kernel.Load(Assembly.GetExecutingAssembly());
                return kernel.Get<T>();
            }
        }
    }
}
