using System;


namespace TransLocalization.Domain.Entitys
{
    public class Motoristas : Base
    {
        public int IdMotorista { get; set; }

        public string NomeMotorista{ get; set; }

        public string Cidade { get; set; }

        public int Contrato { get; set; }

        public int Nota { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool IsAtivo { get; set; }





    }
}
