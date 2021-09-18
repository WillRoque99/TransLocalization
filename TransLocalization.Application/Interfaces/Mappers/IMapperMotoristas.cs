using System;
using System.Collections.Generic;
using System.Text;
using TransLocalization.Application.Dtos;
using TransLocalization.Domain.Entitys;

namespace TransLocalization.Application.Interfaces.Mappers
{
   public interface IMapperMotoristas
    {
        Motoristas MapperDtoToEntity(MotoristaDtos motoristaDtos);

        IEnumerable<MotoristaDtos> MapperListMotoristaDtos(IEnumerable<Motoristas> motoristas);

        MotoristaDtos MapperEntityToDtos(Motoristas motoristas);


    }
}
