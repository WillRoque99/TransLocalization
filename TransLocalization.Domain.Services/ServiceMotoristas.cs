using System;
using System.Collections.Generic;
using System.Text;
using TransLocalization.Domain.Core.Interface.Repositorys;
using TransLocalization.Domain.Core.Interface.Services;
using TransLocalization.Domain.Entitys;

namespace TransLocalization.Domain.Services
{
   public class ServiceMotoristas : ServiceBase<Motoristas>, IServiceMotoristas
    {
        private readonly IRepositoryMotoristas repositoryMotoristas;

            public ServiceMotoristas(IRepositoryMotoristas repositoryMotoristas)
            :base(repositoryMotoristas)
        {
            this.repositoryMotoristas = repositoryMotoristas;
        }
    }
}
