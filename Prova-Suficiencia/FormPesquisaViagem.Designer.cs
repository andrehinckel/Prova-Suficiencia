using System.ComponentModel;

namespace Prova_Suficiencia
{
    partial class FormPesquisaViagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewViagem = new System.Windows.Forms.DataGridView();
            this.placa_onibus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_viagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_viagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_viagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ociosidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListaPassageiros = new System.Windows.Forms.DataGridView();
            this.nome_passageiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGerarCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewViagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewListaPassageiros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViagem
            // 
            this.dataGridViewViagem.AllowUserToAddRows = false;
            this.dataGridViewViagem.AllowUserToDeleteRows = false;
            this.dataGridViewViagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.placa_onibus, this.nome_motorista, this.data_viagem, this.hora_viagem, this.tipo_viagem, this.valor_total, this.ociosidade});
            this.dataGridViewViagem.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewViagem.Name = "dataGridViewViagem";
            this.dataGridViewViagem.ReadOnly = true;
            this.dataGridViewViagem.Size = new System.Drawing.Size(744, 61);
            this.dataGridViewViagem.TabIndex = 36;
            // 
            // placa_onibus
            // 
            this.placa_onibus.HeaderText = "Placa Onibus";
            this.placa_onibus.Name = "placa_onibus";
            this.placa_onibus.ReadOnly = true;
            // 
            // nome_motorista
            // 
            this.nome_motorista.HeaderText = "Nome Motorista";
            this.nome_motorista.Name = "nome_motorista";
            this.nome_motorista.ReadOnly = true;
            // 
            // data_viagem
            // 
            this.data_viagem.HeaderText = "Data Viagem";
            this.data_viagem.Name = "data_viagem";
            this.data_viagem.ReadOnly = true;
            // 
            // hora_viagem
            // 
            this.hora_viagem.HeaderText = "Hora Viagem";
            this.hora_viagem.Name = "hora_viagem";
            this.hora_viagem.ReadOnly = true;
            // 
            // tipo_viagem
            // 
            this.tipo_viagem.HeaderText = "Tipo Viagem";
            this.tipo_viagem.Name = "tipo_viagem";
            this.tipo_viagem.ReadOnly = true;
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            // 
            // ociosidade
            // 
            this.ociosidade.HeaderText = "Ociosiodade";
            this.ociosidade.Name = "ociosidade";
            this.ociosidade.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 43);
            this.label1.TabIndex = 37;
            this.label1.Text = "Viagem";
            // 
            // dataGridViewListaPassageiros
            // 
            this.dataGridViewListaPassageiros.AllowUserToAddRows = false;
            this.dataGridViewListaPassageiros.AllowUserToDeleteRows = false;
            this.dataGridViewListaPassageiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPassageiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.nome_passageiro, this.telefone, this.idade, this.tarifa});
            this.dataGridViewListaPassageiros.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewListaPassageiros.Name = "dataGridViewListaPassageiros";
            this.dataGridViewListaPassageiros.ReadOnly = true;
            this.dataGridViewListaPassageiros.Size = new System.Drawing.Size(444, 350);
            this.dataGridViewListaPassageiros.TabIndex = 38;
            // 
            // nome_passageiro
            // 
            this.nome_passageiro.HeaderText = "Nome";
            this.nome_passageiro.Name = "nome_passageiro";
            this.nome_passageiro.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            // 
            // tarifa
            // 
            this.tarifa.HeaderText = "Valor Tarifa";
            this.tarifa.Name = "tarifa";
            this.tarifa.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 44);
            this.label2.TabIndex = 39;
            this.label2.Text = "Lista Passageiros";
            // 
            // buttonGerarCSV
            // 
            this.buttonGerarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonGerarCSV.Location = new System.Drawing.Point(500, 188);
            this.buttonGerarCSV.Name = "buttonGerarCSV";
            this.buttonGerarCSV.Size = new System.Drawing.Size(233, 127);
            this.buttonGerarCSV.TabIndex = 40;
            this.buttonGerarCSV.Text = "GerarCSV";
            this.buttonGerarCSV.UseVisualStyleBackColor = true;
            this.buttonGerarCSV.Click += new System.EventHandler(this.buttonGerarCSV_Click);
            // 
            // FormPesquisaViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 549);
            this.Controls.Add(this.buttonGerarCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewListaPassageiros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewViagem);
            this.Name = "FormPesquisaViagem";
            this.Text = "FormPesquisaViagem";
            this.Load += new System.EventHandler(this.FormPesquisaViagem_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewViagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewListaPassageiros)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewViagem;

        private System.Windows.Forms.Button buttonGerarCSV;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ociosidade;

        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;

        private System.Windows.Forms.DataGridView dataGridViewListaPassageiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_passageiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridViewTextBoxColumn data_viagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_viagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa_onibus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_viagem;

        #endregion
    }
}