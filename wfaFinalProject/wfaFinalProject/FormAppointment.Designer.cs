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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectAllAppointments = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAppointment = new FontAwesome.Sharp.IconButton();
            this.lbTime = new System.Windows.Forms.Label();
            this.mtbTime = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectAllAppointments);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSelectAppointment);
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.mtbTime);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSelectAllAppointments
            // 
            this.btnSelectAllAppointments.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectAllAppointments.IconColor = System.Drawing.Color.Black;
            this.btnSelectAllAppointments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectAllAppointments.Location = new System.Drawing.Point(356, 37);
            this.btnSelectAllAppointments.Name = "btnSelectAllAppointments";
            this.btnSelectAllAppointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectAllAppointments.Size = new System.Drawing.Size(80, 25);
            this.btnSelectAllAppointments.TabIndex = 38;
            this.btnSelectAllAppointments.Text = "Listar Visitas";
            this.btnSelectAllAppointments.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
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
            this.btnSelectAppointment.Location = new System.Drawing.Point(270, 37);
            this.btnSelectAppointment.Name = "btnSelectAppointment";
            this.btnSelectAppointment.Size = new System.Drawing.Size(80, 25);
            this.btnSelectAppointment.TabIndex = 37;
            this.btnSelectAppointment.Text = "Pesquisar";
            this.btnSelectAppointment.UseVisualStyleBackColor = true;
            this.btnSelectAppointment.Click += new System.EventHandler(this.btnSelectAppointment_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(7, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 13);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Horário";
            // 
            // mtbTime
            // 
            this.mtbTime.Location = new System.Drawing.Point(7, 37);
            this.mtbTime.Mask = "00:00";
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.Size = new System.Drawing.Size(236, 20);
            this.mtbTime.TabIndex = 1;
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 612);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAppointment";
            this.Text = "FormAppointment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.MaskedTextBox mtbTime;
        private FontAwesome.Sharp.IconButton btnSelectAllAppointments;
        private FontAwesome.Sharp.IconButton btnSelectAppointment;
    }
}