using AutoMapper;
using Core.Abstract;
using Core.Services;
using Ninject;
using Ninject.Modules;

namespace Core
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            //Services
            Bind<IDataService>().To<DataService>();
            Bind<IAuthService>().To<AuthService>();

            //Automapper
            var mapperConfiguration = MapperConfig.CreateConfiguration();
            Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();

            // This teaches Ninject how to create automapper instances say if for instance
            // MyResolver has a constructor with a parameter that needs to be injected
            Bind<IMapper>().ToMethod(ctx =>
                 new Mapper(mapperConfiguration, type => ctx.Kernel.Get(type)));
        }
    }
}
