﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia.Entidades
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public class Intermunicipal : IViagem
    {
        public int NumeroMaximoPassageiros { get; set; } = 18;
        public string PlacaOnibus { get; set; }
        public string NomeMotorista { get; set; }
        public DateTime DataViagem { get; set; }
        public List<IPassageiro> Passageiros { get; set; } = new List<IPassageiro>();
        public string Type { get; set; }

        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataViagem = dataViagem;
            Type = GetType().Name;
        }

        public void AddPassageiro(IPassageiro passageiro)
        {
            if (Passageiros.Count < NumeroMaximoPassageiros)
            {
                passageiro.TarifaInteira += 3.21;
                Passageiros.Add(passageiro);

                MessageBox.Show("Passageiro Adicionado com Sucesso", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }

            MessageBox.Show("Essa viagem chegou ao limite de passageiros", "Não foi possivel cadastrar o Passageiro",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}