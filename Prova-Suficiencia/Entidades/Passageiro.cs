using Newtonsoft.Json;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia.Entidades
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public class Passageiro : IPassageiro
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public double TarifaInteira { get; set; }
        public string Type { get; set; }
        
        [JsonConstructor]
        public Passageiro(string nome, string telefone, int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Type = GetType().Name;
            TarifaInteira = GetTarifa();
        }

        public double GetTarifa()
        {
            return 5;
        }
    }
}