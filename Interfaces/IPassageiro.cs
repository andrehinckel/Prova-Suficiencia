using System;

namespace Prova_Suficiencia.Interfaces
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public interface IPassageiro
    {
        double GetTarifa();
        string Nome { get; set; }
        string Telefone { get; set; }
        int Idade { get; set; }
        double TarifaInteira { get; set; }
        string Type { get; set; }
    }
}