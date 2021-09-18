using System;
using System.Collections.Generic;
using System.Text;
using TransLocalization.Domain.Core.Interface.Repositorys;
using TransLocalization.Domain.Entitys;

namespace TransLocalization.Infrastructure.Data.Repositorys
{
   public class RepositoryMotoristas : RepositoryBase<Motoristas>, IRepositoryMotoristas
    {
        private readonly SqlContext sqlContext;

        public RepositoryMotoristas(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
