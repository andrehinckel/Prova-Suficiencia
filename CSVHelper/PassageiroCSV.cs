using CsvHelper.Configuration.Attributes;

namespace Prova_Suficiencia.CSVHelper
{
    public class PassageiroCSV
    {
        [Index(0)]
        public string Tipo { get; set; }
        
        [Index(1)]
        public string Nome { get; set; }
        
        [Index(2)]
        public string Telefone { get; set; }
        
        [Index(3)]
        public int Idade { get; set; }
        
        [Index(4)]
        public string RGEscola { get; set; }
        
        public PassageiroCSV(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}