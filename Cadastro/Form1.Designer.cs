namespace Cadastro
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.lblRG_IE = new System.Windows.Forms.Label();
            this.txtBoxRG_IE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.comboBoxPessoa = new System.Windows.Forms.ComboBox();
            this.txtBoxTelefoneSecundario = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxTelefonePrincipal = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txtBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxComplemento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxLogradouro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxUf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(130, 12);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.ReadOnly = true;
            this.txtBoxCodigo.Size = new System.Drawing.Size(45, 20);
            this.txtBoxCodigo.TabIndex = 1;
            this.txtBoxCodigo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(130, 38);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(328, 20);
            this.txtBoxNome.TabIndex = 3;
            this.txtBoxNome.Leave += new System.EventHandler(this.txtBoxNome_Leave);
            // 
            // txtBoxDataNascimento
            // 
            this.txtBoxDataNascimento.Location = new System.Drawing.Point(130, 64);
            this.txtBoxDataNascimento.Name = "txtBoxDataNascimento";
            this.txtBoxDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDataNascimento.TabIndex = 4;
            this.txtBoxDataNascimento.Leave += new System.EventHandler(this.txtBoxDataNascimento_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Nascimento";
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.Location = new System.Drawing.Point(267, 92);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(67, 13);
            this.lblPessoa.TabIndex = 0;
            this.lblPessoa.Text = "CPF/CNPJ";
            // 
            // lblRG_IE
            // 
            this.lblRG_IE.AutoSize = true;
            this.lblRG_IE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG_IE.Location = new System.Drawing.Point(10, 93);
            this.lblRG_IE.Name = "lblRG_IE";
            this.lblRG_IE.Size = new System.Drawing.Size(43, 13);
            this.lblRG_IE.TabIndex = 0;
            this.lblRG_IE.Text = "RG/IE";
            // 
            // txtBoxRG_IE
            // 
            this.txtBoxRG_IE.Location = new System.Drawing.Point(130, 90);
            this.txtBoxRG_IE.Name = "txtBoxRG_IE";
            this.txtBoxRG_IE.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRG_IE.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefone Principal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefone Secundário";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.comboBoxPessoa);
            this.panelPrincipal.Controls.Add(this.txtBoxTelefoneSecundario);
            this.panelPrincipal.Controls.Add(this.txtBoxTelefonePrincipal);
            this.panelPrincipal.Controls.Add(this.txtBoxEmail);
            this.panelPrincipal.Controls.Add(this.txtBoxCPF_CNPJ);
            this.panelPrincipal.Location = new System.Drawing.Point(4, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(575, 179);
            this.panelPrincipal.TabIndex = 0;
            // 
            // comboBoxPessoa
            // 
            this.comboBoxPessoa.FormattingEnabled = true;
            this.comboBoxPessoa.Items.AddRange(new object[] {
            "Juridica",
            "Fisica"});
            this.comboBoxPessoa.Location = new System.Drawing.Point(282, 7);
            this.comboBoxPessoa.Name = "comboBoxPessoa";
            this.comboBoxPessoa.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPessoa.TabIndex = 2;
            this.comboBoxPessoa.Text = "Selecione";
            this.comboBoxPessoa.SelectedValueChanged += new System.EventHandler(this.comboBoxPessoa_SelectedValueChanged);
            this.comboBoxPessoa.Click += new System.EventHandler(this.comboBoxPessoa_Click);
            // 
            // txtBoxTelefoneSecundario
            // 
            this.txtBoxTelefoneSecundario.Location = new System.Drawing.Point(352, 140);
            this.txtBoxTelefoneSecundario.Mask = "(99) 00000-0000";
            this.txtBoxTelefoneSecundario.Name = "txtBoxTelefoneSecundario";
            this.txtBoxTelefoneSecundario.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelefoneSecundario.TabIndex = 9;
            // 
            // txtBoxTelefonePrincipal
            // 
            this.txtBoxTelefonePrincipal.Location = new System.Drawing.Point(125, 139);
            this.txtBoxTelefonePrincipal.Mask = "(99) 0000-0000";
            this.txtBoxTelefonePrincipal.Name = "txtBoxTelefonePrincipal";
            this.txtBoxTelefonePrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelefonePrincipal.TabIndex = 8;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(124, 112);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(328, 20);
            this.txtBoxEmail.TabIndex = 7;
            // 
            // txtBoxCPF_CNPJ
            // 
            this.txtBoxCPF_CNPJ.Location = new System.Drawing.Point(334, 84);
            this.txtBoxCPF_CNPJ.Mask = "000.000.000-00";
            this.txtBoxCPF_CNPJ.Name = "txtBoxCPF_CNPJ";
            this.txtBoxCPF_CNPJ.Size = new System.Drawing.Size(118, 20);
            this.txtBoxCPF_CNPJ.TabIndex = 6;
            this.txtBoxCPF_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtBoxCPF_CNPJ.Leave += new System.EventHandler(this.txtBoxCPF_CNPJ_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.txtBoxCEP);
            this.panel1.Controls.Add(this.txtBoxComplemento);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtBoxNumero);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtBoxLogradouro);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtBoxUf);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBoxCidade);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(4, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 158);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(238, 120);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(110, 27);
            this.btnCadastrarCliente.TabIndex = 16;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtBoxCEP
            // 
            this.txtBoxCEP.Location = new System.Drawing.Point(69, 52);
            this.txtBoxCEP.Mask = "00000-000";
            this.txtBoxCEP.Name = "txtBoxCEP";
            this.txtBoxCEP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCEP.TabIndex = 12;
            // 
            // txtBoxComplemento
            // 
            this.txtBoxComplemento.Location = new System.Drawing.Point(259, 78);
            this.txtBoxComplemento.Name = "txtBoxComplemento";
            this.txtBoxComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtBoxComplemento.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(172, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Complemento";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(69, 78);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumero.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Número";
            // 
            // txtBoxLogradouro
            // 
            this.txtBoxLogradouro.Location = new System.Drawing.Point(259, 51);
            this.txtBoxLogradouro.Name = "txtBoxLogradouro";
            this.txtBoxLogradouro.Size = new System.Drawing.Size(205, 20);
            this.txtBoxLogradouro.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(183, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Logradouro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "CEP";
            // 
            // txtBoxUf
            // 
            this.txtBoxUf.Location = new System.Drawing.Point(259, 25);
            this.txtBoxUf.Name = "txtBoxUf";
            this.txtBoxUf.Size = new System.Drawing.Size(99, 20);
            this.txtBoxUf.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(231, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "UF";
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Location = new System.Drawing.Point(69, 26);
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCidade.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Endereço";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRG_IE);
            this.Controls.Add(this.txtBoxRG_IE);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDataNascimento);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Label lblRG_IE;
        private System.Windows.Forms.TextBox txtBoxRG_IE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxLogradouro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxUf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxComplemento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtBoxCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox txtBoxCEP;
        private System.Windows.Forms.MaskedTextBox txtBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxPessoa;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefoneSecundario;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefonePrincipal;
        private System.Windows.Forms.Button btnCadastrarCliente;
    }
}

