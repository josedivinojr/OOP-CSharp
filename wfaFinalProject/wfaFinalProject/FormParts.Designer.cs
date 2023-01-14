namespace wfaFinalProject
{
    partial class FormParts
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
            this.btnSelectParts = new FontAwesome.Sharp.IconButton();
            this.btnClearParts = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbParts = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSelectAllParts = new FontAwesome.Sharp.IconButton();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectParts
            // 
            this.btnSelectParts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectParts.IconColor = System.Drawing.Color.Black;
            this.btnSelectParts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectParts.Location = new System.Drawing.Point(75, 56);
            this.btnSelectParts.Name = "btnSelectParts";
            this.btnSelectParts.Size = new System.Drawing.Size(80, 25);
            this.btnSelectParts.TabIndex = 34;
            this.btnSelectParts.Text = "Pesquisar";
            this.btnSelectParts.UseVisualStyleBackColor = true;
            this.btnSelectParts.Click += new System.EventHandler(this.btnSelectParts_Click);
            // 
            // btnClearParts
            // 
            this.btnClearParts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearParts.IconColor = System.Drawing.Color.Black;
            this.btnClearParts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearParts.Location = new System.Drawing.Point(156, 56);
            this.btnClearParts.Name = "btnClearParts";
            this.btnClearParts.Size = new System.Drawing.Size(80, 25);
            this.btnClearParts.TabIndex = 35;
            this.btnClearParts.Text = "Limpar";
            this.btnClearParts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbParts);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnSelectAllParts);
            this.groupBox1.Controls.Add(this.btnClearParts);
            this.groupBox1.Controls.Add(this.btnSelectParts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 122);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Relação de Peças";
            // 
            // cbParts
            // 
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Location = new System.Drawing.Point(75, 29);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(161, 21);
            this.cbParts.TabIndex = 38;
            this.cbParts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbParts_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Modelo";
            // 
            // btnSelectAllParts
            // 
            this.btnSelectAllParts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAllParts.IconColor = System.Drawing.Color.Black;
            this.btnSelectAllParts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAllParts.Location = new System.Drawing.Point(75, 84);
            this.btnSelectAllParts.Name = "btnSelectAllParts";
            this.btnSelectAllParts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectAllParts.Size = new System.Drawing.Size(161, 25);
            this.btnSelectAllParts.TabIndex = 36;
            this.btnSelectAllParts.Text = "Listar todas as peças";
            this.btnSelectAllParts.UseVisualStyleBackColor = true;
            this.btnSelectAllParts.Click += new System.EventHandler(this.btnSelectAllParts_Click);
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.Size = new System.Drawing.Size(637, 460);
            this.dataGridViewParts.TabIndex = 47;
            // 
            // FormParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewParts);
            this.Name = "FormParts";
            this.Text = "FormParts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSelectParts;
        private FontAwesome.Sharp.IconButton btnClearParts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.ComboBox cbParts;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnSelectAllParts;
    }
}