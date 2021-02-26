using System;
using System.Globalization;
using System.Windows.Forms;
using Prova_Suficiencia.Entidades;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public partial class FormCadastroViagens : Form
    {
        private Empresa _empresa;
        private Intermunicipal _intermunicipal;
        private Municipal _municipal;
        private PrincipalForm _principalForm;

        public FormCadastroViagens(Empresa empresa, PrincipalForm form)
        {
            InitializeComponent();
            _empresa = empresa;
            _principalForm = form;
        }

        private void CallCadastroPassageiro(IViagem viagem)
        {
            FormCadastroPassageiros form = new FormCadastroPassageiros(viagem, this);
            form.Visible = true;
        }

        private void buttonCadastroViagemSalvar_Click(object sender, EventArgs e)
        {
            var placaOnibus = textBoxPlaca.Text;
            var nomeMotorista = textBoxNomeMotorista.Text;
            var dataViagemString = textBoxDataViagem.Text;
            var horaViagem = textBoxHoraViagem.Text;

            DateTime dataViagem = DateTime.ParseExact($"{dataViagemString} {horaViagem}", "yyyy-MM-dd HH:mm",
                CultureInfo.CurrentCulture);

            if (checkBoxIntermunicipal.Checked)
            {
                _intermunicipal = new Intermunicipal(placaOnibus, nomeMotorista, dataViagem);
                _empresa.AddViagem(_intermunicipal);
                CallCadastroPassageiro(_intermunicipal);
            }
            else if (checkBoxMunicipal.Checked)
            {
                _municipal = new Municipal(placaOnibus, nomeMotorista, dataViagem);
                _empresa.AddViagem(_municipal);
                CallCadastroPassageiro(_municipal);
            }

            CleanBoxes();
            dataGridViewListaPassageiros.Rows.Clear();
            _principalForm.UpdateGrid();
        }

        private void CleanBoxes()
        {
            textBoxPlaca.Text = "";
            textBoxNomeMotorista.Text = "";
            textBoxDataViagem.Text = "yyyy-MM-dd";
            textBoxHoraViagem.Text = "HH:mm";
            checkBoxIntermunicipal.Checked = false;
            checkBoxIntermunicipal.Enabled = true;
            checkBoxMunicipal.Checked = false;
            checkBoxMunicipal.Enabled = true;
        }

        public void UpdateGrid(string name)
        {
            dataGridViewListaPassageiros.Rows.Clear();

            if (name == nameof(Intermunicipal))
            {
                _intermunicipal.Passageiros.ForEach(passageiro =>
                {
                    dataGridViewListaPassageiros.Rows.Add(
                        passageiro.Nome,
                        passageiro.Telefone,
                        passageiro.Idade,
                        passageiro.TarifaInteira
                    );
                });
            }
            else
            {
                _municipal.Passageiros.ForEach(passageiro =>
                {
                    dataGridViewListaPassageiros.Rows.Add(
                        passageiro.Nome,
                        passageiro.Telefone,
                        passageiro.Idade,
                        passageiro.TarifaInteira
                    );
                });
            }

            _principalForm.UpdateGrid();
        }

        private void checkBoxMunicipal_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIntermunicipal.Enabled = !checkBoxMunicipal.Checked;
        }

        private void checkBoxIntermunicipal_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMunicipal.Enabled = !checkBoxIntermunicipal.Checked;
        }
    }
}