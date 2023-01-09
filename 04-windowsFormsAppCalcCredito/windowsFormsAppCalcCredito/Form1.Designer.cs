namespace windowsFormsAppCalcCredito
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
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.lbCpfCnpj = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbQtdFilhosFuncionarios = new System.Windows.Forms.Label();
            this.lbSalarioFaturamento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtQtdFilhosFuncionarios = new System.Windows.Forms.TextBox();
            this.txtSalarioFaturamento = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lvPessoaFisica = new System.Windows.Forms.ListView();
            this.lvPessoaJuridica = new System.Windows.Forms.ListView();
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(13, 13);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(111, 13);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // lbCpfCnpj
            // 
            this.lbCpfCnpj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCpfCnpj.AutoSize = true;
            this.lbCpfCnpj.Location = new System.Drawing.Point(28, 59);
            this.lbCpfCnpj.Name = "lbCpfCnpj";
            this.lbCpfCnpj.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbCpfCnpj.Size = new System.Drawing.Size(37, 13);
            this.lbCpfCnpj.TabIndex = 2;
            this.lbCpfCnpj.Text = "CPF";
            this.lbCpfCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(28, 85);
            this.lbNome.Name = "lbNome";
            this.lbNome.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCidade
            // 
            this.lbCidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(28, 111);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbCidade.Size = new System.Drawing.Size(50, 13);
            this.lbCidade.TabIndex = 4;
            this.lbCidade.Text = "Cidade";
            this.lbCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbQtdFilhosFuncionarios
            // 
            this.lbQtdFilhosFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbQtdFilhosFuncionarios.AutoSize = true;
            this.lbQtdFilhosFuncionarios.Location = new System.Drawing.Point(28, 137);
            this.lbQtdFilhosFuncionarios.Name = "lbQtdFilhosFuncionarios";
            this.lbQtdFilhosFuncionarios.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbQtdFilhosFuncionarios.Size = new System.Drawing.Size(64, 13);
            this.lbQtdFilhosFuncionarios.TabIndex = 5;
            this.lbQtdFilhosFuncionarios.Text = "Qtd Filhos";
            this.lbQtdFilhosFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSalarioFaturamento
            // 
            this.lbSalarioFaturamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSalarioFaturamento.AutoSize = true;
            this.lbSalarioFaturamento.Location = new System.Drawing.Point(28, 163);
            this.lbSalarioFaturamento.Name = "lbSalarioFaturamento";
            this.lbSalarioFaturamento.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbSalarioFaturamento.Size = new System.Drawing.Size(49, 13);
            this.lbSalarioFaturamento.TabIndex = 6;
            this.lbSalarioFaturamento.Text = "Salário";
            this.lbSalarioFaturamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(122, 108);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(314, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtQtdFilhosFuncionarios
            // 
            this.txtQtdFilhosFuncionarios.Location = new System.Drawing.Point(122, 134);
            this.txtQtdFilhosFuncionarios.Name = "txtQtdFilhosFuncionarios";
            this.txtQtdFilhosFuncionarios.Size = new System.Drawing.Size(314, 20);
            this.txtQtdFilhosFuncionarios.TabIndex = 10;
            this.txtQtdFilhosFuncionarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdFilhosFuncionarios.KeyPress += TxtQtdFilhosFuncionarios_KeyPress;
            // 
            // txtSalarioFaturamento
            // 
            this.txtSalarioFaturamento.Location = new System.Drawing.Point(122, 160);
            this.txtSalarioFaturamento.Name = "txtSalarioFaturamento";
            this.txtSalarioFaturamento.Size = new System.Drawing.Size(314, 20);
            this.txtSalarioFaturamento.TabIndex = 11;
            this.txtSalarioFaturamento.KeyPress += TxtSalarioFaturamento_KeyPress;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(135, 230);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(122, 37);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Cadastrar";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(295, 230);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(122, 37);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lvPessoaFisica
            // 
            this.lvPessoaFisica.HideSelection = false;
            this.lvPessoaFisica.Location = new System.Drawing.Point(36, 305);
            this.lvPessoaFisica.Name = "lvPessoaFisica";
            this.lvPessoaFisica.Size = new System.Drawing.Size(695, 80);
            this.lvPessoaFisica.TabIndex = 14;
            this.lvPessoaFisica.UseCompatibleStateImageBehavior = false;
            // 
            // lvPessoaJuridica
            // 
            this.lvPessoaJuridica.HideSelection = false;
            this.lvPessoaJuridica.Location = new System.Drawing.Point(36, 391);
            this.lvPessoaJuridica.Name = "lvPessoaJuridica";
            this.lvPessoaJuridica.Size = new System.Drawing.Size(695, 80);
            this.lvPessoaJuridica.TabIndex = 15;
            this.lvPessoaJuridica.UseCompatibleStateImageBehavior = false;
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.Location = new System.Drawing.Point(122, 56);
            this.mtbCpfCnpj.Mask = "000.000.000-00";
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(314, 20);
            this.mtbCpfCnpj.TabIndex = 16;
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Location = new System.Drawing.Point(28, 189);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbNomeFantasia.Size = new System.Drawing.Size(88, 13);
            this.lbNomeFantasia.TabIndex = 17;
            this.lbNomeFantasia.Text = "Nome Fantasia";
            this.lbNomeFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(122, 186);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(314, 20);
            this.txtNomeFantasia.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 483);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lbNomeFantasia);
            this.Controls.Add(this.mtbCpfCnpj);
            this.Controls.Add(this.lvPessoaJuridica);
            this.Controls.Add(this.lvPessoaFisica);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtSalarioFaturamento);
            this.Controls.Add(this.txtQtdFilhosFuncionarios);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbSalarioFaturamento);
            this.Controls.Add(this.lbQtdFilhosFuncionarios);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCpfCnpj);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.Label lbCpfCnpj;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbQtdFilhosFuncionarios;
        private System.Windows.Forms.Label lbSalarioFaturamento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtQtdFilhosFuncionarios;
        private System.Windows.Forms.TextBox txtSalarioFaturamento;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListView lvPessoaFisica;
        private System.Windows.Forms.ListView lvPessoaJuridica;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.TextBox txtNomeFantasia;
    }
}

