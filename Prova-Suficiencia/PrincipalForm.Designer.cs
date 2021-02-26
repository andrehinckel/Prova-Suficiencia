namespace Prova_Suficiencia
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewViagens = new System.Windows.Forms.DataGridView();
            this.placa_onibus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_viagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_viagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_viagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_passageiros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonListaPassageiros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvarAlteracoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewViagens)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(701, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar Viagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCadastrarViagem_Click);
            // 
            // dataGridViewViagens
            // 
            this.dataGridViewViagens.AllowUserToAddRows = false;
            this.dataGridViewViagens.AllowUserToDeleteRows = false;
            this.dataGridViewViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.placa_onibus, this.nome_motorista, this.data_viagem, this.hora_viagem, this.tipo_viagem, this.numero_passageiros});
            this.dataGridViewViagens.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewViagens.Name = "dataGridViewViagens";
            this.dataGridViewViagens.ReadOnly = true;
            this.dataGridViewViagens.Size = new System.Drawing.Size(644, 409);
            this.dataGridViewViagens.TabIndex = 35;
            this.dataGridViewViagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViagens_CellContentClick);
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
            // numero_passageiros
            // 
            this.numero_passageiros.HeaderText = "Numero Passageiros";
            this.numero_passageiros.Name = "numero_passageiros";
            this.numero_passageiros.ReadOnly = true;
            // 
            // buttonListaPassageiros
            // 
            this.buttonListaPassageiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonListaPassageiros.Location = new System.Drawing.Point(701, 261);
            this.buttonListaPassageiros.Name = "buttonListaPassageiros";
            this.buttonListaPassageiros.Size = new System.Drawing.Size(232, 95);
            this.buttonListaPassageiros.TabIndex = 36;
            this.buttonListaPassageiros.Text = "Lista de Passageiros";
            this.buttonListaPassageiros.UseVisualStyleBackColor = true;
            this.buttonListaPassageiros.Click += new System.EventHandler(this.buttonListaPassageiros_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Viagens";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(701, 107);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(232, 20);
            this.textBoxSearch.TabIndex = 38;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(701, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "Pesquisar";
            // 
            // buttonSalvarAlteracoes
            // 
            this.buttonSalvarAlteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonSalvarAlteracoes.Location = new System.Drawing.Point(701, 372);
            this.buttonSalvarAlteracoes.Name = "buttonSalvarAlteracoes";
            this.buttonSalvarAlteracoes.Size = new System.Drawing.Size(232, 95);
            this.buttonSalvarAlteracoes.TabIndex = 40;
            this.buttonSalvarAlteracoes.Text = "Salvar Alterações";
            this.buttonSalvarAlteracoes.UseVisualStyleBackColor = true;
            this.buttonSalvarAlteracoes.Click += new System.EventHandler(this.buttonSalvarAlteracoes_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 480);
            this.Controls.Add(this.buttonSalvarAlteracoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonListaPassageiros);
            this.Controls.Add(this.dataGridViewViagens);
            this.Controls.Add(this.button1);
            this.Name = "PrincipalForm";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.Click += new System.EventHandler(this.btnCadastrarViagem_Click);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewViagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonSalvarAlteracoes;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxSearch;

        private System.Windows.Forms.Button buttonListaPassageiros;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridViewTextBoxColumn data_viagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_viagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_passageiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa_onibus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_viagem;

        private System.Windows.Forms.DataGridView dataGridViewViagens;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}