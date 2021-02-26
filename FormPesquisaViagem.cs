using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using Prova_Suficiencia.CSVHelper;
using Prova_Suficiencia.Entidades;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public partial class FormPesquisaViagem : Form
    {
        private readonly IViagem _viagem;

        public FormPesquisaViagem(IViagem viagem)
        {
            _viagem = viagem;
            InitializeComponent();
        }

        private void FormPesquisaViagem_Load(object sender, EventArgs e)
        {
            dataGridViewViagem.Rows.Clear();

            var valorTotal = _viagem.Passageiros.Select(x => x.TarifaInteira).Sum();
            var ociosidade = _viagem.NumeroMaximoPassageiros - _viagem.Passageiros.Count;

            dataGridViewViagem.Rows.Add(
                _viagem.PlacaOnibus,
                _viagem.NomeMotorista,
                _viagem.DataViagem.Date.ToString("yyyy MMMM dd"),
                _viagem.DataViagem.TimeOfDay.ToString(),
                _viagem.Type,
                valorTotal.ToString(),
                ociosidade
            );

            _viagem.Passageiros.ForEach(passageiro =>
            {
                dataGridViewListaPassageiros.Rows.Add(
                    passageiro.Nome,
                    passageiro.Telefone,
                    passageiro.Idade,
                    passageiro.TarifaInteira
                );
            });
        }

        private void buttonGerarCSV_Click(object sender, EventArgs e)
        {
            var viagemCsv = new ViagemCSV(_viagem.Type, _viagem.DataViagem.Date.ToString("dd/MM/yyyy"),
                _viagem.DataViagem.TimeOfDay.ToString("hh\\:mm"), _viagem.PlacaOnibus, _viagem.NomeMotorista);

            var fileName = "Viagem.csv";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = path + "/" + fileName;
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.CurrentCulture))
                {
                    csv.WriteRecord(viagemCsv);
                    csv.NextRecord();
                    _viagem.Passageiros.ForEach(x =>
                    {
                        var rg = "";
                        var escola = "";

                        var passageiro = new PassageiroCSV(x.Nome, x.Telefone);

                        switch (x.Type)
                        {
                            case "Passageiro":
                                passageiro.Tipo = "P";
                                break;
                            case "Estudante":
                            {
                                Estudante estudante = (Estudante) x;
                                passageiro.Tipo = "E";
                                passageiro.RGEscola = estudante.Escola;
                                break;
                            }
                            case "Idoso":
                            {
                                Idoso idoso = (Idoso) x;
                                passageiro.Tipo = "I";
                                passageiro.RGEscola = idoso.RG;
                                break;
                            }
                        }

                        csv.WriteRecord(passageiro);
                        csv.NextRecord();
                    });
                }
            }
            
            MessageBox.Show("O CSV foi gerado na sua Area de trabalho (Desktop)", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}