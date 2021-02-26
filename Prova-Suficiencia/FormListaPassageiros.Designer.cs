using System.ComponentModel;

namespace Prova_Suficiencia
{
    partial class FormListaPassageiros
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
            this.dataGridViewListaPassageiro = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_passageiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewListaPassageiro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaPassageiro
            // 
            this.dataGridViewListaPassageiro.AllowUserToAddRows = false;
            this.dataGridViewListaPassageiro.AllowUserToDeleteRows = false;
            this.dataGridViewListaPassageiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPassageiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.nome, this.telefone, this.idade, this.tipo_passageiro});
            this.dataGridViewListaPassageiro.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListaPassageiro.Name = "dataGridViewListaPassageiro";
            this.dataGridViewListaPassageiro.ReadOnly = true;
            this.dataGridViewListaPassageiro.Size = new System.Drawing.Size(444, 363);
            this.dataGridViewListaPassageiro.TabIndex = 36;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
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
            // tipo_passageiro
            // 
            this.tipo_passageiro.HeaderText = "Tipo Passageiro";
            this.tipo_passageiro.Name = "tipo_passageiro";
            this.tipo_passageiro.ReadOnly = true;
            // 
            // FormListaPassageiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListaPassageiro);
            this.Name = "FormListaPassageiros";
            this.Text = "FormListaPassageiros";
            this.Load += new System.EventHandler(this.FormListaPassageiros_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewListaPassageiro)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewListaPassageiro;

        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_passageiro;

        #endregion
    }
}