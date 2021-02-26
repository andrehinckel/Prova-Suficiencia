using System.ComponentModel;

namespace Prova_Suficiencia
{
    partial class FormCadastroPassageiros
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
            this.textBoxNomePassageiro = new System.Windows.Forms.TextBox();
            this.textBoxTelefonePassageiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdadePassageiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRGEscola = new System.Windows.Forms.Label();
            this.textBoxRGEscola = new System.Windows.Forms.TextBox();
            this.buttonSalvarPassageiro = new System.Windows.Forms.Button();
            this.checkBoxRegular = new System.Windows.Forms.CheckBox();
            this.checkBoxEstudante = new System.Windows.Forms.CheckBox();
            this.checkBoxIdoso = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNomePassageiro
            // 
            this.textBoxNomePassageiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxNomePassageiro.Location = new System.Drawing.Point(12, 56);
            this.textBoxNomePassageiro.Name = "textBoxNomePassageiro";
            this.textBoxNomePassageiro.Size = new System.Drawing.Size(273, 26);
            this.textBoxNomePassageiro.TabIndex = 2;
            // 
            // textBoxTelefonePassageiro
            // 
            this.textBoxTelefonePassageiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxTelefonePassageiro.Location = new System.Drawing.Point(12, 143);
            this.textBoxTelefonePassageiro.Name = "textBoxTelefonePassageiro";
            this.textBoxTelefonePassageiro.Size = new System.Drawing.Size(273, 26);
            this.textBoxTelefonePassageiro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // textBoxIdadePassageiro
            // 
            this.textBoxIdadePassageiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxIdadePassageiro.Location = new System.Drawing.Point(12, 229);
            this.textBoxIdadePassageiro.Name = "textBoxIdadePassageiro";
            this.textBoxIdadePassageiro.Size = new System.Drawing.Size(273, 26);
            this.textBoxIdadePassageiro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "Idade";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Passageiro";
            // 
            // labelRGEscola
            // 
            this.labelRGEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelRGEscola.Location = new System.Drawing.Point(12, 379);
            this.labelRGEscola.Name = "labelRGEscola";
            this.labelRGEscola.Size = new System.Drawing.Size(188, 44);
            this.labelRGEscola.TabIndex = 11;
            this.labelRGEscola.Text = "RG/Escola";
            this.labelRGEscola.Visible = false;
            // 
            // textBoxRGEscola
            // 
            this.textBoxRGEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxRGEscola.Location = new System.Drawing.Point(12, 426);
            this.textBoxRGEscola.Name = "textBoxRGEscola";
            this.textBoxRGEscola.Size = new System.Drawing.Size(273, 26);
            this.textBoxRGEscola.TabIndex = 12;
            this.textBoxRGEscola.Visible = false;
            // 
            // buttonSalvarPassageiro
            // 
            this.buttonSalvarPassageiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonSalvarPassageiro.Location = new System.Drawing.Point(331, 392);
            this.buttonSalvarPassageiro.Name = "buttonSalvarPassageiro";
            this.buttonSalvarPassageiro.Size = new System.Drawing.Size(186, 97);
            this.buttonSalvarPassageiro.TabIndex = 13;
            this.buttonSalvarPassageiro.Text = "Salvar";
            this.buttonSalvarPassageiro.UseVisualStyleBackColor = true;
            this.buttonSalvarPassageiro.Click += new System.EventHandler(this.buttonSalvarPassageiro_Click);
            // 
            // checkBoxRegular
            // 
            this.checkBoxRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxRegular.Location = new System.Drawing.Point(12, 325);
            this.checkBoxRegular.Name = "checkBoxRegular";
            this.checkBoxRegular.Size = new System.Drawing.Size(131, 41);
            this.checkBoxRegular.TabIndex = 14;
            this.checkBoxRegular.Text = "Regular";
            this.checkBoxRegular.UseVisualStyleBackColor = true;
            this.checkBoxRegular.CheckedChanged += new System.EventHandler(this.checkBoxRegular_CheckedChanged);
            // 
            // checkBoxEstudante
            // 
            this.checkBoxEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxEstudante.Location = new System.Drawing.Point(149, 325);
            this.checkBoxEstudante.Name = "checkBoxEstudante";
            this.checkBoxEstudante.Size = new System.Drawing.Size(158, 41);
            this.checkBoxEstudante.TabIndex = 15;
            this.checkBoxEstudante.Text = "Estudante";
            this.checkBoxEstudante.UseVisualStyleBackColor = true;
            this.checkBoxEstudante.CheckedChanged += new System.EventHandler(this.checkBoxEstudante_CheckedChanged);
            // 
            // checkBoxIdoso
            // 
            this.checkBoxIdoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxIdoso.Location = new System.Drawing.Point(313, 325);
            this.checkBoxIdoso.Name = "checkBoxIdoso";
            this.checkBoxIdoso.Size = new System.Drawing.Size(131, 41);
            this.checkBoxIdoso.TabIndex = 16;
            this.checkBoxIdoso.Text = "Idoso";
            this.checkBoxIdoso.UseVisualStyleBackColor = true;
            this.checkBoxIdoso.CheckedChanged += new System.EventHandler(this.checkBoxIdoso_CheckedChanged);
            // 
            // FormCadastroPassageiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 509);
            this.Controls.Add(this.checkBoxIdoso);
            this.Controls.Add(this.checkBoxEstudante);
            this.Controls.Add(this.checkBoxRegular);
            this.Controls.Add(this.buttonSalvarPassageiro);
            this.Controls.Add(this.textBoxRGEscola);
            this.Controls.Add(this.labelRGEscola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIdadePassageiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTelefonePassageiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomePassageiro);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroPassageiros";
            this.Text = "FormCadastroPassageiros";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBoxEstudante;
        private System.Windows.Forms.CheckBox checkBoxIdoso;
        private System.Windows.Forms.CheckBox checkBoxRegular;

        private System.Windows.Forms.Button buttonSalvarPassageiro;

        private System.Windows.Forms.Label labelRGEscola;
        private System.Windows.Forms.TextBox textBoxRGEscola;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdadePassageiro;
        private System.Windows.Forms.TextBox textBoxNomePassageiro;
        private System.Windows.Forms.TextBox textBoxTelefonePassageiro;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}