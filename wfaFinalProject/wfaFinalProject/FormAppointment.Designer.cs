namespace wfaFinalProject
{
    partial class FormAppointment
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSearchAppointment = new System.Windows.Forms.GroupBox();
            this.btnSelectAllAppointments = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAppointment = new FontAwesome.Sharp.IconButton();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.groupBoxManageAppointments = new System.Windows.Forms.GroupBox();
            this.btnUpdateAppointment = new FontAwesome.Sharp.IconButton();
            this.tbAssetSerialAppointment = new System.Windows.Forms.TextBox();
            this.lbAssetAppointment = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertAppointment = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNewAppointmentTime = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSearchAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.groupBoxManageAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // groupBoxSearchAppointment
            // 
            this.groupBoxSearchAppointment.Controls.Add(this.btnSelectAllAppointments);
            this.groupBoxSearchAppointment.Controls.Add(this.label1);
            this.groupBoxSearchAppointment.Controls.Add(this.btnSelectAppointment);
            this.groupBoxSearchAppointment.Controls.Add(this.dateTimePicker);
            this.groupBoxSearchAppointment.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchAppointment.Name = "groupBoxSearchAppointment";
            this.groupBoxSearchAppointment.Size = new System.Drawing.Size(260, 206);
            this.groupBoxSearchAppointment.TabIndex = 1;
            this.groupBoxSearchAppointment.TabStop = false;
            this.groupBoxSearchAppointment.Text = "Consultar Visitas";
            // 
            // btnSelectAllAppointments
            // 
            this.btnSelectAllAppointments.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAllAppointments.IconColor = System.Drawing.Color.Black;
            this.btnSelectAllAppointments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAllAppointments.Location = new System.Drawing.Point(92, 63);
            this.btnSelectAllAppointments.Name = "btnSelectAllAppointments";
            this.btnSelectAllAppointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectAllAppointments.Size = new System.Drawing.Size(151, 25);
            this.btnSelectAllAppointments.TabIndex = 38;
            this.btnSelectAllAppointments.Text = "Listar Todas Visitas";
            this.btnSelectAllAppointments.UseVisualStyleBackColor = true;
            this.btnSelectAllAppointments.Click += new System.EventHandler(this.btnSelectAllAppointments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // btnSelectAppointment
            // 
            this.btnSelectAppointment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAppointment.IconColor = System.Drawing.Color.Black;
            this.btnSelectAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAppointment.Location = new System.Drawing.Point(6, 63);
            this.btnSelectAppointment.Name = "btnSelectAppointment";
            this.btnSelectAppointment.Size = new System.Drawing.Size(80, 25);
            this.btnSelectAppointment.TabIndex = 37;
            this.btnSelectAppointment.Text = "Pesquisar";
            this.btnSelectAppointment.UseVisualStyleBackColor = true;
            this.btnSelectAppointment.Click += new System.EventHandler(this.btnSelectAppointment_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.Size = new System.Drawing.Size(637, 376);
            this.dataGridViewAppointment.TabIndex = 48;
            // 
            // groupBoxManageAppointments
            // 
            this.groupBoxManageAppointments.Controls.Add(this.btnUpdateAppointment);
            this.groupBoxManageAppointments.Controls.Add(this.tbAssetSerialAppointment);
            this.groupBoxManageAppointments.Controls.Add(this.lbAssetAppointment);
            this.groupBoxManageAppointments.Controls.Add(this.btnDeleteAppointment);
            this.groupBoxManageAppointments.Controls.Add(this.label2);
            this.groupBoxManageAppointments.Controls.Add(this.btnInsertAppointment);
            this.groupBoxManageAppointments.Controls.Add(this.label3);
            this.groupBoxManageAppointments.Controls.Add(this.mtbNewAppointmentTime);
            this.groupBoxManageAppointments.Controls.Add(this.dateTimePickerAppointment);
            this.groupBoxManageAppointments.Location = new System.Drawing.Point(278, 12);
            this.groupBoxManageAppointments.Name = "groupBoxManageAppointments";
            this.groupBoxManageAppointments.Size = new System.Drawing.Size(273, 206);
            this.groupBoxManageAppointments.TabIndex = 39;
            this.groupBoxManageAppointments.TabStop = false;
            this.groupBoxManageAppointments.Text = "Gerenciar Visitas";
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateAppointment.IconColor = System.Drawing.Color.Black;
            this.btnUpdateAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAppointment.Location = new System.Drawing.Point(95, 167);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(80, 25);
            this.btnUpdateAppointment.TabIndex = 41;
            this.btnUpdateAppointment.Text = "Atualizar Visita";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // tbAssetSerialAppointment
            // 
            this.tbAssetSerialAppointment.Location = new System.Drawing.Point(7, 141);
            this.tbAssetSerialAppointment.Name = "tbAssetSerialAppointment";
            this.tbAssetSerialAppointment.Size = new System.Drawing.Size(256, 20);
            this.tbAssetSerialAppointment.TabIndex = 40;
            // 
            // lbAssetAppointment
            // 
            this.lbAssetAppointment.AutoSize = true;
            this.lbAssetAppointment.Location = new System.Drawing.Point(9, 127);
            this.lbAssetAppointment.Name = "lbAssetAppointment";
            this.lbAssetAppointment.Size = new System.Drawing.Size(61, 13);
            this.lbAssetAppointment.TabIndex = 39;
            this.lbAssetAppointment.Text = "Nº de Série";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeleteAppointment.IconColor = System.Drawing.Color.Black;
            this.btnDeleteAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(183, 167);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteAppointment.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteAppointment.TabIndex = 38;
            this.btnDeleteAppointment.Text = "Deletar Visita";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // btnInsertAppointment
            // 
            this.btnInsertAppointment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInsertAppointment.IconColor = System.Drawing.Color.Black;
            this.btnInsertAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertAppointment.Location = new System.Drawing.Point(7, 167);
            this.btnInsertAppointment.Name = "btnInsertAppointment";
            this.btnInsertAppointment.Size = new System.Drawing.Size(80, 25);
            this.btnInsertAppointment.TabIndex = 37;
            this.btnInsertAppointment.Text = "Inserir Visita";
            this.btnInsertAppointment.UseVisualStyleBackColor = true;
            this.btnInsertAppointment.Click += new System.EventHandler(this.btnInsertAppointment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horário";
            // 
            // mtbNewAppointmentTime
            // 
            this.mtbNewAppointmentTime.Location = new System.Drawing.Point(7, 37);
            this.mtbNewAppointmentTime.Mask = "00:00";
            this.mtbNewAppointmentTime.Name = "mtbNewAppointmentTime";
            this.mtbNewAppointmentTime.Size = new System.Drawing.Size(256, 20);
            this.mtbNewAppointmentTime.TabIndex = 1;
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(7, 89);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(256, 20);
            this.dateTimePickerAppointment.TabIndex = 0;
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 612);
            this.Controls.Add(this.groupBoxManageAppointments);
            this.Controls.Add(this.dataGridViewAppointment);
            this.Controls.Add(this.groupBoxSearchAppointment);
            this.Name = "FormAppointment";
            this.Text = "FormAppointment";
            this.groupBoxSearchAppointment.ResumeLayout(false);
            this.groupBoxSearchAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.groupBoxManageAppointments.ResumeLayout(false);
            this.groupBoxManageAppointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBoxSearchAppointment;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSelectAllAppointments;
        private FontAwesome.Sharp.IconButton btnSelectAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.GroupBox groupBoxManageAppointments;
        private FontAwesome.Sharp.IconButton btnUpdateAppointment;
        private System.Windows.Forms.TextBox tbAssetSerialAppointment;
        private System.Windows.Forms.Label lbAssetAppointment;
        private FontAwesome.Sharp.IconButton btnDeleteAppointment;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnInsertAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNewAppointmentTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
    }
}