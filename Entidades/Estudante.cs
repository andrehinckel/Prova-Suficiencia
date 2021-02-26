using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia.Entidades
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public class Estudante : IPassageiro
    {
        public string Escola { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public double TarifaInteira { get; set; }
        public string Type { get; set; }
        
        public Estudante(string nome, string telefone, int idade, string escola)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Escola = escola;
            TarifaInteira = GetTarifa();
            Type = GetType().Name;
        }

        public double GetTarifa()
        {
            return 5 / 2;
        }
    }
}