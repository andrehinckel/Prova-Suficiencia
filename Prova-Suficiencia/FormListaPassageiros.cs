using System;
using System.Windows.Forms;
using Prova_Suficiencia.Entidades;

namespace Prova_Suficiencia
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public partial class FormListaPassageiros : Form
    {
        private Empresa _empresa;

        public FormListaPassageiros(Empresa empresa)
        {
            InitializeComponent();
            _empresa = empresa;
        }

        private void FormListaPassageiros_Load(object sender, EventArgs e)
        {
            var passageiros = _empresa.GetPassageirosMaisVelho();
            passageiros.ForEach(x =>
            {
                dataGridViewListaPassageiro.Rows.Add(x.Nome, x.Idade, x.Telefone, x.Type);
            });
        }
    }
}