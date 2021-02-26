using System;
using System.Reflection;
using System.Windows.Forms;
using Prova_Suficiencia.Entidades;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public partial class FormCadastroPassageiros : Form
    {
        private readonly IViagem _viagem;
        private FormCadastroViagens _cadastro;
        private Passageiro _regular;
        private Idoso _idoso;
        private Estudante _estudante;
        
        public FormCadastroPassageiros(IViagem viagem, FormCadastroViagens cadastro)
        {
            InitializeComponent();
            _viagem = viagem;
            _cadastro = cadastro;
        }
        
        private void buttonSalvarPassageiro_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomePassageiro.Text;
            var telefone = textBoxTelefonePassageiro.Text;
            var idade = int.Parse(textBoxIdadePassageiro.Text);

            if (checkBoxRegular.Checked)
            {
                _regular = new Passageiro(nome, telefone, idade);
                _viagem.AddPassageiro(_regular);
            }
            else if (checkBoxEstudante.Checked)
            {
                _estudante = new Estudante(nome, telefone, idade, textBoxRGEscola.Text);
                _viagem.AddPassageiro(_estudante);
            }
            else if (checkBoxIdoso.Checked)
            {
                if (idade < 60)
                {
                    MessageBox.Show("Não é possivel adicionar um Idoso com menos de 60 anos", 
                        "Não foi possivel cadastrar o Passageiro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _idoso = new Idoso(nome, telefone, idade, textBoxRGEscola.Text);
                    _viagem.AddPassageiro(_idoso);
                }
            }

            _cadastro.UpdateGrid(_viagem.GetType().Name);
            CleanBoxes();
        }

        private void CleanBoxes()
        {
            textBoxNomePassageiro.Text = "";
            textBoxTelefonePassageiro.Text = "";
            textBoxIdadePassageiro.Text = "";
            textBoxRGEscola.Text = "";
            checkBoxRegular.Checked = false;
            checkBoxRegular.Enabled = true;
            checkBoxEstudante.Checked = false;
            checkBoxEstudante.Enabled = true;
            checkBoxIdoso.Checked = false;
            checkBoxIdoso.Enabled = true;
        }

        private void checkBoxRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRegular.Checked)
            {
                checkBoxEstudante.Enabled = false;
                checkBoxIdoso.Enabled = false;
                labelRGEscola.Visible = false;
                textBoxRGEscola.Visible = false;
            }
            else
            {
                checkBoxEstudante.Enabled = true;
                checkBoxIdoso.Enabled = true;
            }
        }

        private void checkBoxEstudante_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstudante.Checked)
            {
                checkBoxIdoso.Enabled = false;
                checkBoxRegular.Enabled = false;
                labelRGEscola.Visible = true;
                labelRGEscola.Text = "Escola";
                textBoxRGEscola.Visible = true;
            }
            else
            {
                checkBoxIdoso.Enabled = true;
                checkBoxRegular.Enabled = true;
                labelRGEscola.Visible = false;
                textBoxRGEscola.Visible = false;
            }
        }

        private void checkBoxIdoso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIdoso.Checked)
            {
                checkBoxEstudante.Enabled = false;
                checkBoxRegular.Enabled = false;
                labelRGEscola.Visible = true;
                labelRGEscola.Text = "RG";
                textBoxRGEscola.Visible = true;
            }
            else
            {
                checkBoxEstudante.Enabled = true;
                checkBoxRegular.Enabled = true;
                labelRGEscola.Visible = false;
                textBoxRGEscola.Visible = false;
            }
        }
    }
}