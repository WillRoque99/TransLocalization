using Autofac;
using TransLocalization.Application;
using TransLocalization.Application.Interfaces;
using TransLocalization.Application.Interfaces.Mappers;
using TransLocalization.Application.Mappers;
using TransLocalization.Domain.Core.Interface.Repositorys;
using TransLocalization.Domain.Core.Interface.Services;
using TransLocalization.Domain.Services;
using TransLocalization.Infrastructure.Data.Repositorys;

namespace TransLocalization.Infrastructure.CrossCuting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceMotoristas>().As<IApplicationServiceMotoristas>();

            builder.RegisterType<ServiceMotoristas>().As<IServiceMotoristas>();

            builder.RegisterType<RepositoryMotoristas>().As<IRepositoryMotoristas>();

            builder.RegisterType<MapperMotoristas>().As<IMapperMotoristas>();


                #endregion
        }
    }

   
}
