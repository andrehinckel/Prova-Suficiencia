using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Prova_Suficiencia.Entidades;

namespace Prova_Suficiencia
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public partial class PrincipalForm : Form
    {
        private static Empresa _empresa = new Empresa();

        public PrincipalForm()
        {
            InitializeComponent();
            _empresa.Viagens = _empresa.ReadJsonFile();
        }

        private void btnCadastrarViagem_Click(object sender, EventArgs e)
        {
            FormCadastroViagens form = new FormCadastroViagens(_empresa, this);
            form.Visible = true;
        }

        public void UpdateGrid()
        {
            dataGridViewViagens.Rows.Clear();

            _empresa.Viagens
                .OrderBy(x => x.DataViagem)
                .ToList()
                .ForEach(viagem =>
                {
                    dataGridViewViagens.Rows.Add(
                        viagem.PlacaOnibus,
                        viagem.NomeMotorista,
                        viagem.DataViagem.Date.ToString("yyyy MM dd"),
                        viagem.DataViagem.TimeOfDay.ToString(),
                        viagem.Type,
                        viagem.Passageiros.Count
                    );
                });
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void buttonListaPassageiros_Click(object sender, EventArgs e)
        {
            FormListaPassageiros form = new FormListaPassageiros(_empresa);
            form.Visible = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewViagens.Rows.Clear();

            var text = textBoxSearch.Text;

            _empresa.Viagens
                .Where(x => x.DataViagem.Date.ToString("yyyy MM dd").Contains(text) ||
                            x.DataViagem.TimeOfDay.ToString().Contains(text) ||
                            x.PlacaOnibus.Contains(text))
                .OrderBy(x => x.DataViagem)
                .ToList()
                .ForEach(viagem =>
                {
                    dataGridViewViagens.Rows.Add(
                        viagem.PlacaOnibus,
                        viagem.NomeMotorista,
                        viagem.DataViagem.Date.ToString("yyyy MM dd"),
                        viagem.DataViagem.TimeOfDay.ToString("HH:mm"),
                        viagem.Type,
                        viagem.Passageiros.Count
                    );
                });
        }

        private void dataGridViewViagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var placaOnibus = dataGridViewViagens.CurrentRow?.Cells[0].Value.ToString();
            var nomeMotorista = dataGridViewViagens.CurrentRow?.Cells[1].Value.ToString();
            var tipoViagem = dataGridViewViagens.CurrentRow?.Cells[4].Value.ToString();
            
            var viagem =
                _empresa.Viagens
                    .FirstOrDefault(x => x.PlacaOnibus == placaOnibus &&
                                         x.NomeMotorista == nomeMotorista &&
                                         x.Type== tipoViagem);
            
            FormPesquisaViagem form = new FormPesquisaViagem(viagem);
            form.Visible = true;
        }

        private void buttonSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            _empresa.Viagens.ForEach(x =>
            {
                File.WriteAllText("./Resources/ListaViagens.json", JsonConvert.SerializeObject(x));
            });
        }
    }
}