using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransLocalization.Application.Dtos;
using TransLocalization.Application.Interfaces.Mappers;
using TransLocalization.Domain.Entitys;

namespace TransLocalization.Application.Mappers
{
    public class MapperMotoristas : IMapperMotoristas
    {
        List<MotoristaDtos> motoristaDtos = new List<MotoristaDtos>();

        public Motoristas MapperDtoToEntity(MotoristaDtos motoristaDtos)
        {
            var motoristas = new Motoristas()
            {
                IdMotorista = motoristaDtos.Id,
                NomeMotorista = motoristaDtos.NomeMotorista
                    ,
                Cidade = motoristaDtos.Cidade
                    ,
                Contrato = motoristaDtos.Contrato
                    ,
                Nota = motoristaDtos.Nota
            };
            return motoristas;
        }

        public MotoristaDtos MapperEntityToDtos(Motoristas motoristas)
        {
            var motoristaDtos = new MotoristaDtos()
            {
                Id = motoristas.ID
               ,
                NomeMotorista = motoristas.NomeMotorista

                ,
                Cidade = motoristas.Cidade

                ,
                Contrato = motoristas.Contrato

                ,
                Nota = motoristas.Nota
            };
            return motoristaDtos;
        }

        public IEnumerable<MotoristaDtos> MapperListMotoristaDtos(IEnumerable<Motoristas> motoristas)
        {
            var dto = motoristas.Select(c => new MotoristaDtos { Id = c.ID, NomeMotorista = c.NomeMotorista, Cidade = c.Cidade, Contrato = c.Contrato, Nota = c.Nota });

            return dto;
        }
    }
}
