namespace wfaFinalProject
{
    partial class FormCostumer
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
            this.mtbCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.cbAddressNewCostumer = new System.Windows.Forms.ComboBox();
            this.lbNewCPFCNPJ = new System.Windows.Forms.Label();
            this.lbNewName = new System.Windows.Forms.Label();
            this.tbNomeRasaoSocialNewCostumer = new System.Windows.Forms.TextBox();
            this.mtbPhoneNewCostumer = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPFCNPJNewCostumer = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmailNewCostumer = new System.Windows.Forms.TextBox();
            this.dataGridViewCostumers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectAllCostumers = new FontAwesome.Sharp.IconButton();
            this.btnClearCostumer = new FontAwesome.Sharp.IconButton();
            this.btnSelectCostumer = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteCostumer = new FontAwesome.Sharp.IconButton();
            this.btUpdateCostumer = new FontAwesome.Sharp.IconButton();
            this.btnClearNewCostumer = new FontAwesome.Sharp.IconButton();
            this.btnInsertNewCostumer = new FontAwesome.Sharp.IconButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostumers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbCPFCNPJ
            // 
            this.mtbCPFCNPJ.Location = new System.Drawing.Point(59, 30);
            this.mtbCPFCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCPFCNPJ.Name = "mtbCPFCNPJ";
            this.mtbCPFCNPJ.Size = new System.Drawing.Size(197, 20);
            this.mtbCPFCNPJ.TabIndex = 32;
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(19, 33);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbCPFCNPJ.TabIndex = 33;
            this.lbCPFCNPJ.Text = "CNPJ";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(26, 157);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(53, 13);
            this.lbAdress.TabIndex = 43;
            this.lbAdress.Text = "Endereço";
            // 
            // cbAddressNewCostumer
            // 
            this.cbAddressNewCostumer.FormattingEnabled = true;
            this.cbAddressNewCostumer.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbAddressNewCostumer.Location = new System.Drawing.Point(97, 154);
            this.cbAddressNewCostumer.Name = "cbAddressNewCostumer";
            this.cbAddressNewCostumer.Size = new System.Drawing.Size(197, 21);
            this.cbAddressNewCostumer.Sorted = true;
            this.cbAddressNewCostumer.TabIndex = 42;
            // 
            // lbNewCPFCNPJ
            // 
            this.lbNewCPFCNPJ.AutoSize = true;
            this.lbNewCPFCNPJ.Location = new System.Drawing.Point(26, 33);
            this.lbNewCPFCNPJ.Name = "lbNewCPFCNPJ";
            this.lbNewCPFCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbNewCPFCNPJ.TabIndex = 34;
            this.lbNewCPFCNPJ.Text = "CNPJ";
            // 
            // lbNewName
            // 
            this.lbNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNewName.AutoSize = true;
            this.lbNewName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNewName.Location = new System.Drawing.Point(26, 64);
            this.lbNewName.Name = "lbNewName";
            this.lbNewName.Size = new System.Drawing.Size(70, 13);
            this.lbNewName.TabIndex = 36;
            this.lbNewName.Text = "Razão Social";
            this.lbNewName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNomeRasaoSocialNewCostumer
            // 
            this.tbNomeRasaoSocialNewCostumer.Location = new System.Drawing.Point(97, 61);
            this.tbNomeRasaoSocialNewCostumer.Name = "tbNomeRasaoSocialNewCostumer";
            this.tbNomeRasaoSocialNewCostumer.Size = new System.Drawing.Size(197, 20);
            this.tbNomeRasaoSocialNewCostumer.TabIndex = 37;
            // 
            // mtbPhoneNewCostumer
            // 
            this.mtbPhoneNewCostumer.Location = new System.Drawing.Point(97, 123);
            this.mtbPhoneNewCostumer.Mask = "(99) 00000-0000";
            this.mtbPhoneNewCostumer.Name = "mtbPhoneNewCostumer";
            this.mtbPhoneNewCostumer.Size = new System.Drawing.Size(197, 20);
            this.mtbPhoneNewCostumer.TabIndex = 41;
            // 
            // mtbCPFCNPJNewCostumer
            // 
            this.mtbCPFCNPJNewCostumer.Location = new System.Drawing.Point(97, 30);
            this.mtbCPFCNPJNewCostumer.Mask = "00.000.000/0000-00";
            this.mtbCPFCNPJNewCostumer.Name = "mtbCPFCNPJNewCostumer";
            this.mtbCPFCNPJNewCostumer.Size = new System.Drawing.Size(197, 20);
            this.mtbCPFCNPJNewCostumer.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "E-mail";
            // 
            // tbEmailNewCostumer
            // 
            this.tbEmailNewCostumer.Location = new System.Drawing.Point(97, 92);
            this.tbEmailNewCostumer.Name = "tbEmailNewCostumer";
            this.tbEmailNewCostumer.Size = new System.Drawing.Size(197, 20);
            this.tbEmailNewCostumer.TabIndex = 39;
            // 
            // dataGridViewCostumers
            // 
            this.dataGridViewCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostumers.Location = new System.Drawing.Point(12, 275);
            this.dataGridViewCostumers.Name = "dataGridViewCostumers";
            this.dataGridViewCostumers.Size = new System.Drawing.Size(637, 325);
            this.dataGridViewCostumers.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectAllCostumers);
            this.groupBox1.Controls.Add(this.btnClearCostumer);
            this.groupBox1.Controls.Add(this.btnSelectCostumer);
            this.groupBox1.Controls.Add(this.mtbCPFCNPJ);
            this.groupBox1.Controls.Add(this.lbCPFCNPJ);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 221);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Cliente";
            // 
            // btnSelectAllCostumers
            // 
            this.btnSelectAllCostumers.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAllCostumers.IconColor = System.Drawing.Color.Black;
            this.btnSelectAllCostumers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAllCostumers.Location = new System.Drawing.Point(59, 89);
            this.btnSelectAllCostumers.Name = "btnSelectAllCostumers";
            this.btnSelectAllCostumers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectAllCostumers.Size = new System.Drawing.Size(161, 25);
            this.btnSelectAllCostumers.TabIndex = 36;
            this.btnSelectAllCostumers.Text = "Listas todos os Clientes";
            this.btnSelectAllCostumers.UseVisualStyleBackColor = true;
            this.btnSelectAllCostumers.Click += new System.EventHandler(this.btnSelectAllCostumers_Click);
            // 
            // btnClearCostumer
            // 
            this.btnClearCostumer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearCostumer.IconColor = System.Drawing.Color.Black;
            this.btnClearCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearCostumer.Location = new System.Drawing.Point(140, 61);
            this.btnClearCostumer.Name = "btnClearCostumer";
            this.btnClearCostumer.Size = new System.Drawing.Size(80, 25);
            this.btnClearCostumer.TabIndex = 35;
            this.btnClearCostumer.Text = "Limpar";
            this.btnClearCostumer.UseVisualStyleBackColor = true;
            this.btnClearCostumer.Click += new System.EventHandler(this.btnClearCostumer_Click);
            // 
            // btnSelectCostumer
            // 
            this.btnSelectCostumer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectCostumer.IconColor = System.Drawing.Color.Black;
            this.btnSelectCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectCostumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectCostumer.Location = new System.Drawing.Point(59, 61);
            this.btnSelectCostumer.Name = "btnSelectCostumer";
            this.btnSelectCostumer.Size = new System.Drawing.Size(80, 25);
            this.btnSelectCostumer.TabIndex = 34;
            this.btnSelectCostumer.Text = "Pesquisar";
            this.btnSelectCostumer.UseVisualStyleBackColor = true;
            this.btnSelectCostumer.Click += new System.EventHandler(this.btnSelectCostumer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteCostumer);
            this.groupBox2.Controls.Add(this.btUpdateCostumer);
            this.groupBox2.Controls.Add(this.btnClearNewCostumer);
            this.groupBox2.Controls.Add(this.lbNewCPFCNPJ);
            this.groupBox2.Controls.Add(this.btnInsertNewCostumer);
            this.groupBox2.Controls.Add(this.tbEmailNewCostumer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbAdress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbAddressNewCostumer);
            this.groupBox2.Controls.Add(this.mtbCPFCNPJNewCostumer);
            this.groupBox2.Controls.Add(this.mtbPhoneNewCostumer);
            this.groupBox2.Controls.Add(this.lbNewName);
            this.groupBox2.Controls.Add(this.tbNomeRasaoSocialNewCostumer);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 244);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atualizar Informações";
            // 
            // deleteCostumer
            // 
            this.deleteCostumer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteCostumer.IconColor = System.Drawing.Color.Black;
            this.deleteCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteCostumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCostumer.Location = new System.Drawing.Point(185, 213);
            this.deleteCostumer.Name = "deleteCostumer";
            this.deleteCostumer.Size = new System.Drawing.Size(80, 25);
            this.deleteCostumer.TabIndex = 44;
            this.deleteCostumer.Text = "Deletar Cliente";
            this.deleteCostumer.UseVisualStyleBackColor = true;
            this.deleteCostumer.Click += new System.EventHandler(this.deleteCostumer_Click);
            // 
            // btUpdateCostumer
            // 
            this.btUpdateCostumer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btUpdateCostumer.IconColor = System.Drawing.Color.Black;
            this.btUpdateCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btUpdateCostumer.Location = new System.Drawing.Point(97, 212);
            this.btUpdateCostumer.Name = "btUpdateCostumer";
            this.btUpdateCostumer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btUpdateCostumer.Size = new System.Drawing.Size(80, 25);
            this.btUpdateCostumer.TabIndex = 39;
            this.btUpdateCostumer.Text = "Atualizar";
            this.btUpdateCostumer.UseVisualStyleBackColor = true;
            this.btUpdateCostumer.Click += new System.EventHandler(this.btUpdateCostumer_Click);
            // 
            // btnClearNewCostumer
            // 
            this.btnClearNewCostumer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearNewCostumer.IconColor = System.Drawing.Color.Black;
            this.btnClearNewCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearNewCostumer.Location = new System.Drawing.Point(185, 181);
            this.btnClearNewCostumer.Name = "btnClearNewCostumer";
            this.btnClearNewCostumer.Size = new System.Drawing.Size(80, 25);
            this.btnClearNewCostumer.TabIndex = 38;
            this.btnClearNewCostumer.Text = "Limpar";
            this.btnClearNewCostumer.UseVisualStyleBackColor = true;
            this.btnClearNewCostumer.Click += new System.EventHandler(this.btnClearNewCostumer_Click);
            // 
            // btnInsertNewCostumer
            // 
            this.btnInsertNewCostumer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInsertNewCostumer.IconColor = System.Drawing.Color.Black;
            this.btnInsertNewCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertNewCostumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertNewCostumer.Location = new System.Drawing.Point(97, 181);
            this.btnInsertNewCostumer.Name = "btnInsertNewCostumer";
            this.btnInsertNewCostumer.Size = new System.Drawing.Size(80, 25);
            this.btnInsertNewCostumer.TabIndex = 37;
            this.btnInsertNewCostumer.Text = "Inserir Novo";
            this.btnInsertNewCostumer.UseVisualStyleBackColor = true;
            this.btnInsertNewCostumer.Click += new System.EventHandler(this.btnInsertNewCostumer_Click);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(12, 12);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rbCNPJ.TabIndex = 48;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbCNPJ_CheckedChanged);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(70, 12);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(45, 17);
            this.rbCPF.TabIndex = 49;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // FormCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(661, 612);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCostumers);
            this.Name = "FormCostumer";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostumers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCPFCNPJ;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.ComboBox cbAddressNewCostumer;
        private System.Windows.Forms.Label lbNewCPFCNPJ;
        private System.Windows.Forms.Label lbNewName;
        private System.Windows.Forms.TextBox tbNomeRasaoSocialNewCostumer;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNewCostumer;
        private System.Windows.Forms.MaskedTextBox mtbCPFCNPJNewCostumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmailNewCostumer;
        private System.Windows.Forms.DataGridView dataGridViewCostumers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnSelectAllCostumers;
        private FontAwesome.Sharp.IconButton btnClearCostumer;
        private FontAwesome.Sharp.IconButton btnSelectCostumer;
        private FontAwesome.Sharp.IconButton btUpdateCostumer;
        private FontAwesome.Sharp.IconButton btnClearNewCostumer;
        private FontAwesome.Sharp.IconButton btnInsertNewCostumer;
        public FontAwesome.Sharp.IconButton deleteCostumer;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
    }
}