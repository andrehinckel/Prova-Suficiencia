using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Prova_Suficiencia.Entidades;

namespace Prova_Suficiencia.Interfaces
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public interface IViagem
    {
        void AddPassageiro(IPassageiro passageiro);
        int NumeroMaximoPassageiros { get; set; }
        string PlacaOnibus { get; set; }
        string NomeMotorista { get; set; }
        DateTime DataViagem { get; set; }
        [JsonConverter(typeof(SerializationConverter))]
        List<IPassageiro> Passageiros { get; set; }
        string Type { get; set; }
    }
}