using Newtonsoft.Json;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia.Entidades
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public class Idoso : IPassageiro
    {
        public string RG { get; set; }
        
        [JsonConstructor]
        public Idoso(string nome, string telefone, int idade, string rg)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            RG = rg;
            TarifaInteira = GetTarifa();
            Type = GetType().Name;
        }

        public double GetTarifa()
        {
            return 0;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public double TarifaInteira { get; set; }
        public string Type { get; set; }
    }
}