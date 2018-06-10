using DataInterface;
using DataRepository;
using Ninject.Modules;


namespace Business.Business.NinjectBindings
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IProfileDataInterface>().To<ProfileRepository>().InSingletonScope();
        }
    }
}
