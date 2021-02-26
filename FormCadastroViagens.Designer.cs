using System.ComponentModel;

namespace Prova_Suficiencia
{
    partial class FormCadastroViagens
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeMotorista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataViagem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHoraViagem = new System.Windows.Forms.TextBox();
            this.checkBoxMunicipal = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxIntermunicipal = new System.Windows.Forms.CheckBox();
            this.buttonCadastroViagemSalvar = new System.Windows.Forms.Button();
            this.dataGridViewListaPassageiros = new System.Windows.Forms.DataGridView();
            this.nome_passageiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewListaPassageiros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa do Onibus";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxPlaca.Location = new System.Drawing.Point(12, 55);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(273, 26);
            this.textBoxPlaca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Motorista";
            // 
            // textBoxNomeMotorista
            // 
            this.textBoxNomeMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxNomeMotorista.Location = new System.Drawing.Point(323, 56);
            this.textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            this.textBoxNomeMotorista.Size = new System.Drawing.Size(273, 26);
            this.textBoxNomeMotorista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Viagem";
            // 
            // textBoxDataViagem
            // 
            this.textBoxDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxDataViagem.Location = new System.Drawing.Point(12, 141);
            this.textBoxDataViagem.Name = "textBoxDataViagem";
            this.textBoxDataViagem.Size = new System.Drawing.Size(273, 26);
            this.textBoxDataViagem.TabIndex = 5;
            this.textBoxDataViagem.Text = "yyyy-mm-dd";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(323, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora Viagem";
            // 
            // textBoxHoraViagem
            // 
            this.textBoxHoraViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxHoraViagem.Location = new System.Drawing.Point(323, 141);
            this.textBoxHoraViagem.Name = "textBoxHoraViagem";
            this.textBoxHoraViagem.Size = new System.Drawing.Size(273, 26);
            this.textBoxHoraViagem.TabIndex = 7;
            this.textBoxHoraViagem.Text = "HH:mm";
            // 
            // checkBoxMunicipal
            // 
            this.checkBoxMunicipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxMunicipal.Location = new System.Drawing.Point(639, 78);
            this.checkBoxMunicipal.Name = "checkBoxMunicipal";
            this.checkBoxMunicipal.Size = new System.Drawing.Size(273, 44);
            this.checkBoxMunicipal.TabIndex = 8;
            this.checkBoxMunicipal.Text = "Municipal";
            this.checkBoxMunicipal.UseVisualStyleBackColor = true;
            this.checkBoxMunicipal.Click += new System.EventHandler(this.checkBoxMunicipal_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(639, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Viagem";
            // 
            // checkBoxIntermunicipal
            // 
            this.checkBoxIntermunicipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxIntermunicipal.Location = new System.Drawing.Point(639, 128);
            this.checkBoxIntermunicipal.Name = "checkBoxIntermunicipal";
            this.checkBoxIntermunicipal.Size = new System.Drawing.Size(273, 44);
            this.checkBoxIntermunicipal.TabIndex = 10;
            this.checkBoxIntermunicipal.Text = "Intermunicipal";
            this.checkBoxIntermunicipal.UseVisualStyleBackColor = true;
            this.checkBoxIntermunicipal.Click += new System.EventHandler(this.checkBoxIntermunicipal_CheckedChanged);
            // 
            // buttonCadastroViagemSalvar
            // 
            this.buttonCadastroViagemSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonCadastroViagemSalvar.Location = new System.Drawing.Point(651, 251);
            this.buttonCadastroViagemSalvar.Name = "buttonCadastroViagemSalvar";
            this.buttonCadastroViagemSalvar.Size = new System.Drawing.Size(211, 101);
            this.buttonCadastroViagemSalvar.TabIndex = 11;
            this.buttonCadastroViagemSalvar.Text = "Salvar";
            this.buttonCadastroViagemSalvar.UseVisualStyleBackColor = true;
            this.buttonCadastroViagemSalvar.Click += new System.EventHandler(this.buttonCadastroViagemSalvar_Click);
            // 
            // dataGridViewListaPassageiros
            // 
            this.dataGridViewListaPassageiros.AllowUserToAddRows = false;
            this.dataGridViewListaPassageiros.AllowUserToDeleteRows = false;
            this.dataGridViewListaPassageiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPassageiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.nome_passageiro, this.telefone, this.idade, this.tarifa});
            this.dataGridViewListaPassageiros.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewListaPassageiros.Name = "dataGridViewListaPassageiros";
            this.dataGridViewListaPassageiros.ReadOnly = true;
            this.dataGridViewListaPassageiros.Size = new System.Drawing.Size(444, 295);
            this.dataGridViewListaPassageiros.TabIndex = 35;
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
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 43);
            this.label6.TabIndex = 36;
            this.label6.Text = "Lista Passageiros";
            // 
            // FormCadastroViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 558);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewListaPassageiros);
            this.Controls.Add(this.buttonCadastroViagemSalvar);
            this.Controls.Add(this.checkBoxIntermunicipal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxMunicipal);
            this.Controls.Add(this.textBoxHoraViagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDataViagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeMotorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroViagens";
            this.Text = "FormCadastroViagens";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewListaPassageiros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn tarifa;

        private System.Windows.Forms.DataGridView dataGridViewListaPassageiros;

        private System.Windows.Forms.TextBox textBoxHoraViagem;

        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_passageiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;

        private System.Windows.Forms.Button buttonCadastroViagemSalvar;

        private System.Windows.Forms.CheckBox checkBoxIntermunicipal;
        private System.Windows.Forms.CheckBox checkBoxMunicipal;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBoxDataViagem;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeMotorista;

        private System.Windows.Forms.TextBox textBoxPlaca;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}