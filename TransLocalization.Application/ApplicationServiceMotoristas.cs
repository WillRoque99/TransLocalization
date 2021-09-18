using System;
using System.Collections.Generic;

using TransLocalization.Application.Dtos;
using TransLocalization.Application.Interfaces;
using TransLocalization.Application.Interfaces.Mappers;
using TransLocalization.Domain.Core.Interface.Services;

namespace TransLocalization.Application
{
    public class ApplicationServiceMotoristas : IApplicationServiceMotoristas
    {
        private readonly IServiceMotoristas serviceMotoristas;
        private readonly IMapperMotoristas mapperMotoristas;
        public ApplicationServiceMotoristas(IServiceMotoristas serviceMotoristas, IMapperMotoristas mapperMotoristas)
        {
            this.serviceMotoristas = serviceMotoristas;
            this.mapperMotoristas = mapperMotoristas;
        }



        public void Add(MotoristaDtos motoristaDtos)
        {
            var motoristas = mapperMotoristas.MapperDtoToEntity(motoristaDtos);
            serviceMotoristas.Add(motoristas);
        }

        public IEnumerable<MotoristaDtos> GetAll()
        {
            var motoristas = serviceMotoristas.GetAll();
            return mapperMotoristas.MapperListMotoristaDtos(motoristas);
        }

        public MotoristaDtos GetById(int id)
        {
            var motoristas = serviceMotoristas.GetById(id);
            return mapperMotoristas.MapperEntityToDtos(motoristas);
        }

        public void Remove(MotoristaDtos motoristaDtos)
        {
            var motoristas = mapperMotoristas.MapperDtoToEntity(motoristaDtos);
            serviceMotoristas.Remove(motoristas);
        }

        public void Update(MotoristaDtos motoristaDtos)
        {
            var motoristas = mapperMotoristas.MapperDtoToEntity(motoristaDtos);
            serviceMotoristas.Update(motoristas);
        }
    }
}
