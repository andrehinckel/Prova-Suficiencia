using CsvHelper.Configuration.Attributes;

namespace Prova_Suficiencia.CSVHelper
{
    public class ViagemCSV
    {
        [Index(0)]
        public string Tipo { get; set; }
        [Index(1)]
        public string Data { get; set; }
        [Index(2)]
        public string Hora { get; set; }
        [Index(3)]
        public string Placa { get; set; }
        [Index(4)]
        public string NomeMotorista { get; set; }
        
        public ViagemCSV(string tipo, string data, string hora, string placa, string nomeMotorista)
        {
            Tipo = tipo;
            Data = data;
            Hora = hora;
            Placa = placa;
            NomeMotorista = nomeMotorista;
        }
    }
}