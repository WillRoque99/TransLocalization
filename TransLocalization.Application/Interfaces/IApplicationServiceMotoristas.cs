using System;
using System.Collections.Generic;
using System.Text;
using TransLocalization.Application.Dtos;

namespace TransLocalization.Application.Interfaces
{
   public interface IApplicationServiceMotoristas
    {
        void Add(MotoristaDtos motoristaDtos);

        void Update(MotoristaDtos motoristaDtos);

        void Remove(MotoristaDtos motoristaDtos);

        IEnumerable<MotoristaDtos> GetAll();

        MotoristaDtos GetById(int id);



    }
}
