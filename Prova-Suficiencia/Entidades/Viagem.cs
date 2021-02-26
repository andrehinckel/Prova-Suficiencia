using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia.Entidades
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public class Viagem : IViagem
    {
        public string PlacaOnibus { get; set; }
        public string NomeMotorista { get; set; }
        public DateTime DataViagem { get; set; }
        public List<IPassageiro> Passageiros { get; set; } = new List<IPassageiro>();
        public virtual int NumeroMaximoPassageiros { get; set; }
        public  string Type { get; set; }
        
        [JsonConstructor]
        public Viagem(string placaOnibus, string nomeMotorista, DateTime dataViagem, List<IPassageiro> passageiros, int numeroMaximoPassageiros, string type)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataViagem = dataViagem;
            Passageiros = passageiros;
            NumeroMaximoPassageiros = numeroMaximoPassageiros;
            Type = type;
        }

        protected Viagem(string placaOnibus, string nomeMotorista, DateTime dataViagem)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataViagem = dataViagem;
            Type = GetType().Name;
        }

        public virtual void AddPassageiro(IPassageiro passageiro)
        {
            Passageiros.Add(passageiro);
        }
    }
}