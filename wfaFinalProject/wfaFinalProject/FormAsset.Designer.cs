namespace wfaFinalProject
{
    partial class FormAsset
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btUpdateAsset = new FontAwesome.Sharp.IconButton();
            this.btnClearNewAsset = new FontAwesome.Sharp.IconButton();
            this.btnInsertNewAsset = new FontAwesome.Sharp.IconButton();
            this.mtbNewAssetCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNewAssetModel = new System.Windows.Forms.TextBox();
            this.mtbNewAssetSerial = new System.Windows.Forms.MaskedTextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.btnSelectAsset = new FontAwesome.Sharp.IconButton();
            this.btnSelectAllAssets = new FontAwesome.Sharp.IconButton();
            this.btnClearAsset = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbAssetSerial = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewAssets = new System.Windows.Forms.DataGridView();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btUpdateAsset);
            this.groupBox2.Controls.Add(this.btnClearNewAsset);
            this.groupBox2.Controls.Add(this.btnInsertNewAsset);
            this.groupBox2.Controls.Add(this.mtbNewAssetCPFCNPJ);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbNewAssetModel);
            this.groupBox2.Controls.Add(this.mtbNewAssetSerial);
            this.groupBox2.Controls.Add(this.lbCPFCNPJ);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 244);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atualizar Informações";
            // 
            // btUpdateAsset
            // 
            this.btUpdateAsset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btUpdateAsset.IconColor = System.Drawing.Color.Black;
            this.btUpdateAsset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btUpdateAsset.Location = new System.Drawing.Point(152, 143);
            this.btUpdateAsset.Name = "btUpdateAsset";
            this.btUpdateAsset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btUpdateAsset.Size = new System.Drawing.Size(80, 25);
            this.btUpdateAsset.TabIndex = 43;
            this.btUpdateAsset.Text = "Atualizar";
            this.btUpdateAsset.UseVisualStyleBackColor = true;
            this.btUpdateAsset.Click += new System.EventHandler(this.btUpdateAsset_Click);
            // 
            // btnClearNewAsset
            // 
            this.btnClearNewAsset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearNewAsset.IconColor = System.Drawing.Color.Black;
            this.btnClearNewAsset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearNewAsset.Location = new System.Drawing.Point(240, 143);
            this.btnClearNewAsset.Name = "btnClearNewAsset";
            this.btnClearNewAsset.Size = new System.Drawing.Size(80, 25);
            this.btnClearNewAsset.TabIndex = 42;
            this.btnClearNewAsset.Text = "Limpar";
            this.btnClearNewAsset.UseVisualStyleBackColor = true;
            // 
            // btnInsertNewAsset
            // 
            this.btnInsertNewAsset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInsertNewAsset.IconColor = System.Drawing.Color.Black;
            this.btnInsertNewAsset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertNewAsset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertNewAsset.Location = new System.Drawing.Point(64, 143);
            this.btnInsertNewAsset.Name = "btnInsertNewAsset";
            this.btnInsertNewAsset.Size = new System.Drawing.Size(80, 25);
            this.btnInsertNewAsset.TabIndex = 41;
            this.btnInsertNewAsset.Text = "Inserir Novo";
            this.btnInsertNewAsset.UseVisualStyleBackColor = true;
            this.btnInsertNewAsset.Click += new System.EventHandler(this.btnInsertNewAsset_Click);
            // 
            // mtbNewAssetCPFCNPJ
            // 
            this.mtbNewAssetCPFCNPJ.Location = new System.Drawing.Point(129, 30);
            this.mtbNewAssetCPFCNPJ.Mask = "00.000.000/0000-00";
            this.mtbNewAssetCPFCNPJ.Name = "mtbNewAssetCPFCNPJ";
            this.mtbNewAssetCPFCNPJ.Size = new System.Drawing.Size(197, 20);
            this.mtbNewAssetCPFCNPJ.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nº de Série";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Modelo";
            // 
            // tbNewAssetModel
            // 
            this.tbNewAssetModel.Location = new System.Drawing.Point(129, 69);
            this.tbNewAssetModel.Name = "tbNewAssetModel";
            this.tbNewAssetModel.Size = new System.Drawing.Size(197, 20);
            this.tbNewAssetModel.TabIndex = 38;
            // 
            // mtbNewAssetSerial
            // 
            this.mtbNewAssetSerial.Location = new System.Drawing.Point(129, 108);
            this.mtbNewAssetSerial.Mask = "0000000-00";
            this.mtbNewAssetSerial.Name = "mtbNewAssetSerial";
            this.mtbNewAssetSerial.Size = new System.Drawing.Size(197, 20);
            this.mtbNewAssetSerial.TabIndex = 36;
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(32, 33);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(84, 13);
            this.lbCPFCNPJ.TabIndex = 39;
            this.lbCPFCNPJ.Text = "CNPJ do Cliente";
            // 
            // btnSelectAsset
            // 
            this.btnSelectAsset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAsset.IconColor = System.Drawing.Color.Black;
            this.btnSelectAsset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAsset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAsset.Location = new System.Drawing.Point(84, 60);
            this.btnSelectAsset.Name = "btnSelectAsset";
            this.btnSelectAsset.Size = new System.Drawing.Size(80, 25);
            this.btnSelectAsset.TabIndex = 34;
            this.btnSelectAsset.Text = "Pesquisar";
            this.btnSelectAsset.UseVisualStyleBackColor = true;
            this.btnSelectAsset.Click += new System.EventHandler(this.btnSelectAsset_Click);
            // 
            // btnSelectAllAssets
            // 
            this.btnSelectAllAssets.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAllAssets.IconColor = System.Drawing.Color.Black;
            this.btnSelectAllAssets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAllAssets.Location = new System.Drawing.Point(84, 88);
            this.btnSelectAllAssets.Name = "btnSelectAllAssets";
            this.btnSelectAllAssets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectAllAssets.Size = new System.Drawing.Size(161, 25);
            this.btnSelectAllAssets.TabIndex = 36;
            this.btnSelectAllAssets.Text = "Listar Ativos";
            this.btnSelectAllAssets.UseVisualStyleBackColor = true;
            this.btnSelectAllAssets.Click += new System.EventHandler(this.btnSelectAllAssets_Click);
            // 
            // btnClearAsset
            // 
            this.btnClearAsset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearAsset.IconColor = System.Drawing.Color.Black;
            this.btnClearAsset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearAsset.Location = new System.Drawing.Point(165, 60);
            this.btnClearAsset.Name = "btnClearAsset";
            this.btnClearAsset.Size = new System.Drawing.Size(80, 25);
            this.btnClearAsset.TabIndex = 35;
            this.btnClearAsset.Text = "Limpar";
            this.btnClearAsset.UseVisualStyleBackColor = true;
            this.btnClearAsset.Click += new System.EventHandler(this.btnClearAsset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbAssetSerial);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSelectAllAssets);
            this.groupBox1.Controls.Add(this.btnClearAsset);
            this.groupBox1.Controls.Add(this.btnSelectAsset);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 221);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Ativo";
            // 
            // mtbAssetSerial
            // 
            this.mtbAssetSerial.Location = new System.Drawing.Point(84, 30);
            this.mtbAssetSerial.Mask = "0000000-00";
            this.mtbAssetSerial.Name = "mtbAssetSerial";
            this.mtbAssetSerial.Size = new System.Drawing.Size(161, 20);
            this.mtbAssetSerial.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nº de Série";
            // 
            // dataGridViewAssets
            // 
            this.dataGridViewAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssets.Location = new System.Drawing.Point(12, 275);
            this.dataGridViewAssets.Name = "dataGridViewAssets";
            this.dataGridViewAssets.Size = new System.Drawing.Size(637, 325);
            this.dataGridViewAssets.TabIndex = 47;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(70, 12);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(45, 17);
            this.rbCPF.TabIndex = 51;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(12, 12);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rbCNPJ.TabIndex = 50;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbCNPJ_CheckedChanged);
            // 
            // FormAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 612);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewAssets);
            this.Name = "FormAsset";
            this.Text = "Ativos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbNewAssetCPFCNPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNewAssetModel;
        private System.Windows.Forms.MaskedTextBox mtbNewAssetSerial;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private FontAwesome.Sharp.IconButton btnSelectAsset;
        private FontAwesome.Sharp.IconButton btnSelectAllAssets;
        private FontAwesome.Sharp.IconButton btnClearAsset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAssets;
        private FontAwesome.Sharp.IconButton btUpdateAsset;
        private FontAwesome.Sharp.IconButton btnClearNewAsset;
        private FontAwesome.Sharp.IconButton btnInsertNewAsset;
        private System.Windows.Forms.MaskedTextBox mtbAssetSerial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbCNPJ;
    }
}