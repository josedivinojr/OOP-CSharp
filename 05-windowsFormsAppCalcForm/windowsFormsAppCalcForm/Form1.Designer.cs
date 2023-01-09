namespace windowsFormsAppCalcForm
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
            this.rbQuadrado = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.rbLosango = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbHexagono = new System.Windows.Forms.RadioButton();
            this.rbPentagono = new System.Windows.Forms.RadioButton();
            this.rbCírculo = new System.Windows.Forms.RadioButton();
            this.rbTrapezio = new System.Windows.Forms.RadioButton();
            this.lbFormasGeometricas = new System.Windows.Forms.Label();
            this.lbCalcular = new System.Windows.Forms.Label();
            this.btCalcArea = new System.Windows.Forms.Button();
            this.btCalcPerimetro = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lvAreas = new System.Windows.Forms.ListView();
            this.lbCalculoDeAreas = new System.Windows.Forms.Label();
            this.lbCalculoDePerimetros = new System.Windows.Forms.Label();
            this.lvPerimetros = new System.Windows.Forms.ListView();
            this.lbDados = new System.Windows.Forms.Label();
            this.pnlInputQuadrado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLadoQuadrado = new System.Windows.Forms.TextBox();
            this.pnlInputTriangulo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.tbBaseTriangulo = new System.Windows.Forms.TextBox();
            this.pnlInputRetangulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlturaRetangulo = new System.Windows.Forms.TextBox();
            this.tbBaseRetangulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnlInputQuadrado.SuspendLayout();
            this.pnlInputTriangulo.SuspendLayout();
            this.pnlInputRetangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbQuadrado
            // 
            this.rbQuadrado.AutoSize = true;
            this.rbQuadrado.Location = new System.Drawing.Point(322, 69);
            this.rbQuadrado.Name = "rbQuadrado";
            this.rbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rbQuadrado.TabIndex = 0;
            this.rbQuadrado.TabStop = true;
            this.rbQuadrado.Text = "Quadrado";
            this.rbQuadrado.UseVisualStyleBackColor = true;
            this.rbQuadrado.CheckedChanged += new System.EventHandler(this.rbQuadrado_CheckedChanged);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Location = new System.Drawing.Point(413, 69);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rbRetangulo.TabIndex = 1;
            this.rbRetangulo.TabStop = true;
            this.rbRetangulo.Text = "Retângulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // rbLosango
            // 
            this.rbLosango.AutoSize = true;
            this.rbLosango.Location = new System.Drawing.Point(413, 92);
            this.rbLosango.Name = "rbLosango";
            this.rbLosango.Size = new System.Drawing.Size(66, 17);
            this.rbLosango.TabIndex = 3;
            this.rbLosango.TabStop = true;
            this.rbLosango.Text = "Losango";
            this.rbLosango.UseVisualStyleBackColor = true;
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(322, 92);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 2;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triângulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbHexagono
            // 
            this.rbHexagono.AutoSize = true;
            this.rbHexagono.Location = new System.Drawing.Point(413, 115);
            this.rbHexagono.Name = "rbHexagono";
            this.rbHexagono.Size = new System.Drawing.Size(74, 17);
            this.rbHexagono.TabIndex = 5;
            this.rbHexagono.TabStop = true;
            this.rbHexagono.Text = "Hexagono";
            this.rbHexagono.UseVisualStyleBackColor = true;
            // 
            // rbPentagono
            // 
            this.rbPentagono.AutoSize = true;
            this.rbPentagono.Location = new System.Drawing.Point(322, 115);
            this.rbPentagono.Name = "rbPentagono";
            this.rbPentagono.Size = new System.Drawing.Size(77, 17);
            this.rbPentagono.TabIndex = 4;
            this.rbPentagono.TabStop = true;
            this.rbPentagono.Text = "Pentágono";
            this.rbPentagono.UseVisualStyleBackColor = true;
            // 
            // rbCírculo
            // 
            this.rbCírculo.AutoSize = true;
            this.rbCírculo.Location = new System.Drawing.Point(413, 138);
            this.rbCírculo.Name = "rbCírculo";
            this.rbCírculo.Size = new System.Drawing.Size(59, 17);
            this.rbCírculo.TabIndex = 7;
            this.rbCírculo.TabStop = true;
            this.rbCírculo.Text = "Círculo";
            this.rbCírculo.UseVisualStyleBackColor = true;
            // 
            // rbTrapezio
            // 
            this.rbTrapezio.AutoSize = true;
            this.rbTrapezio.Location = new System.Drawing.Point(322, 138);
            this.rbTrapezio.Name = "rbTrapezio";
            this.rbTrapezio.Size = new System.Drawing.Size(66, 17);
            this.rbTrapezio.TabIndex = 6;
            this.rbTrapezio.TabStop = true;
            this.rbTrapezio.Text = "Trapézio";
            this.rbTrapezio.UseVisualStyleBackColor = true;
            // 
            // lbFormasGeometricas
            // 
            this.lbFormasGeometricas.AutoSize = true;
            this.lbFormasGeometricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormasGeometricas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFormasGeometricas.Location = new System.Drawing.Point(320, 34);
            this.lbFormasGeometricas.Name = "lbFormasGeometricas";
            this.lbFormasGeometricas.Size = new System.Drawing.Size(176, 20);
            this.lbFormasGeometricas.TabIndex = 8;
            this.lbFormasGeometricas.Text = "Formas Geométricas";
            // 
            // lbCalcular
            // 
            this.lbCalcular.AutoSize = true;
            this.lbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalcular.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCalcular.Location = new System.Drawing.Point(320, 203);
            this.lbCalcular.Name = "lbCalcular";
            this.lbCalcular.Size = new System.Drawing.Size(74, 20);
            this.lbCalcular.TabIndex = 9;
            this.lbCalcular.Text = "Calcular";
            // 
            // btCalcArea
            // 
            this.btCalcArea.Location = new System.Drawing.Point(324, 226);
            this.btCalcArea.Name = "btCalcArea";
            this.btCalcArea.Size = new System.Drawing.Size(75, 23);
            this.btCalcArea.TabIndex = 10;
            this.btCalcArea.Text = "Área";
            this.btCalcArea.UseVisualStyleBackColor = true;
            this.btCalcArea.Click += new System.EventHandler(this.btCalcArea_Click);
            // 
            // btCalcPerimetro
            // 
            this.btCalcPerimetro.Location = new System.Drawing.Point(405, 226);
            this.btCalcPerimetro.Name = "btCalcPerimetro";
            this.btCalcPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btCalcPerimetro.TabIndex = 11;
            this.btCalcPerimetro.Text = "Perímetro";
            this.btCalcPerimetro.UseVisualStyleBackColor = true;
            this.btCalcPerimetro.Click += new System.EventHandler(this.btCalcPerimetro_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(325, 255);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(155, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar Dados";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::windowsFormsAppCalcForm.Properties.Resources.pentagono;
            this.pictureBox.Image = global::windowsFormsAppCalcForm.Properties.Resources.branco;
            this.pictureBox.InitialImage = global::windowsFormsAppCalcForm.Properties.Resources.branco;
            this.pictureBox.Location = new System.Drawing.Point(12, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(268, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // lvAreas
            // 
            this.lvAreas.HideSelection = false;
            this.lvAreas.Location = new System.Drawing.Point(12, 324);
            this.lvAreas.Name = "lvAreas";
            this.lvAreas.Size = new System.Drawing.Size(776, 97);
            this.lvAreas.TabIndex = 14;
            this.lvAreas.UseCompatibleStateImageBehavior = false;
            // 
            // lbCalculoDeAreas
            // 
            this.lbCalculoDeAreas.AutoSize = true;
            this.lbCalculoDeAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculoDeAreas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCalculoDeAreas.Location = new System.Drawing.Point(305, 301);
            this.lbCalculoDeAreas.Name = "lbCalculoDeAreas";
            this.lbCalculoDeAreas.Size = new System.Drawing.Size(246, 20);
            this.lbCalculoDeAreas.TabIndex = 15;
            this.lbCalculoDeAreas.Text = "Histórico de Cálculo de Áreas";
            // 
            // lbCalculoDePerimetros
            // 
            this.lbCalculoDePerimetros.AutoSize = true;
            this.lbCalculoDePerimetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculoDePerimetros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCalculoDePerimetros.Location = new System.Drawing.Point(281, 437);
            this.lbCalculoDePerimetros.Name = "lbCalculoDePerimetros";
            this.lbCalculoDePerimetros.Size = new System.Drawing.Size(285, 20);
            this.lbCalculoDePerimetros.TabIndex = 16;
            this.lbCalculoDePerimetros.Text = "Histórico de Cálculo de Perímetros";
            // 
            // lvPerimetros
            // 
            this.lvPerimetros.HideSelection = false;
            this.lvPerimetros.Location = new System.Drawing.Point(12, 460);
            this.lvPerimetros.Name = "lvPerimetros";
            this.lvPerimetros.Size = new System.Drawing.Size(776, 97);
            this.lvPerimetros.TabIndex = 17;
            this.lvPerimetros.UseCompatibleStateImageBehavior = false;
            // 
            // lbDados
            // 
            this.lbDados.AutoSize = true;
            this.lbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDados.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDados.Location = new System.Drawing.Point(532, 34);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(142, 20);
            this.lbDados.TabIndex = 18;
            this.lbDados.Text = "Dados da Forma";
            // 
            // pnlInputQuadrado
            // 
            this.pnlInputQuadrado.Controls.Add(this.label2);
            this.pnlInputQuadrado.Controls.Add(this.tbLadoQuadrado);
            this.pnlInputQuadrado.Location = new System.Drawing.Point(536, 69);
            this.pnlInputQuadrado.Name = "pnlInputQuadrado";
            this.pnlInputQuadrado.Size = new System.Drawing.Size(160, 63);
            this.pnlInputQuadrado.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Base";
            // 
            // tbLadoQuadrado
            // 
            this.tbLadoQuadrado.Location = new System.Drawing.Point(41, 3);
            this.tbLadoQuadrado.Name = "tbLadoQuadrado";
            this.tbLadoQuadrado.Size = new System.Drawing.Size(100, 20);
            this.tbLadoQuadrado.TabIndex = 22;
            // 
            // pnlInputTriangulo
            // 
            this.pnlInputTriangulo.Controls.Add(this.label5);
            this.pnlInputTriangulo.Controls.Add(this.label4);
            this.pnlInputTriangulo.Controls.Add(this.tbAlturaTriangulo);
            this.pnlInputTriangulo.Controls.Add(this.tbBaseTriangulo);
            this.pnlInputTriangulo.Location = new System.Drawing.Point(536, 138);
            this.pnlInputTriangulo.Name = "pnlInputTriangulo";
            this.pnlInputTriangulo.Size = new System.Drawing.Size(160, 63);
            this.pnlInputTriangulo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Base";
            // 
            // tbAlturaTriangulo
            // 
            this.tbAlturaTriangulo.Location = new System.Drawing.Point(44, 32);
            this.tbAlturaTriangulo.Name = "tbAlturaTriangulo";
            this.tbAlturaTriangulo.Size = new System.Drawing.Size(100, 20);
            this.tbAlturaTriangulo.TabIndex = 25;
            // 
            // tbBaseTriangulo
            // 
            this.tbBaseTriangulo.Location = new System.Drawing.Point(44, 6);
            this.tbBaseTriangulo.Name = "tbBaseTriangulo";
            this.tbBaseTriangulo.Size = new System.Drawing.Size(100, 20);
            this.tbBaseTriangulo.TabIndex = 25;
            // 
            // pnlInputRetangulo
            // 
            this.pnlInputRetangulo.Controls.Add(this.label1);
            this.pnlInputRetangulo.Controls.Add(this.label3);
            this.pnlInputRetangulo.Controls.Add(this.tbAlturaRetangulo);
            this.pnlInputRetangulo.Controls.Add(this.tbBaseRetangulo);
            this.pnlInputRetangulo.Location = new System.Drawing.Point(536, 207);
            this.pnlInputRetangulo.Name = "pnlInputRetangulo";
            this.pnlInputRetangulo.Size = new System.Drawing.Size(160, 63);
            this.pnlInputRetangulo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Base";
            // 
            // tbAlturaRetangulo
            // 
            this.tbAlturaRetangulo.Location = new System.Drawing.Point(44, 32);
            this.tbAlturaRetangulo.Name = "tbAlturaRetangulo";
            this.tbAlturaRetangulo.Size = new System.Drawing.Size(100, 20);
            this.tbAlturaRetangulo.TabIndex = 25;
            // 
            // tbBaseRetangulo
            // 
            this.tbBaseRetangulo.Location = new System.Drawing.Point(44, 6);
            this.tbBaseRetangulo.Name = "tbBaseRetangulo";
            this.tbBaseRetangulo.Size = new System.Drawing.Size(100, 20);
            this.tbBaseRetangulo.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.pnlInputRetangulo);
            this.Controls.Add(this.pnlInputTriangulo);
            this.Controls.Add(this.pnlInputQuadrado);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.lvPerimetros);
            this.Controls.Add(this.lbCalculoDePerimetros);
            this.Controls.Add(this.lbCalculoDeAreas);
            this.Controls.Add(this.lvAreas);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcPerimetro);
            this.Controls.Add(this.btCalcArea);
            this.Controls.Add(this.lbCalcular);
            this.Controls.Add(this.lbFormasGeometricas);
            this.Controls.Add(this.rbCírculo);
            this.Controls.Add(this.rbTrapezio);
            this.Controls.Add(this.rbHexagono);
            this.Controls.Add(this.rbPentagono);
            this.Controls.Add(this.rbLosango);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.rbQuadrado);
            this.Name = "Form1";
            this.Text = "Formas Geometricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnlInputQuadrado.ResumeLayout(false);
            this.pnlInputQuadrado.PerformLayout();
            this.pnlInputTriangulo.ResumeLayout(false);
            this.pnlInputTriangulo.PerformLayout();
            this.pnlInputRetangulo.ResumeLayout(false);
            this.pnlInputRetangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbQuadrado;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbLosango;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbHexagono;
        private System.Windows.Forms.RadioButton rbPentagono;
        private System.Windows.Forms.RadioButton rbCírculo;
        private System.Windows.Forms.RadioButton rbTrapezio;
        private System.Windows.Forms.Label lbFormasGeometricas;
        private System.Windows.Forms.Label lbCalcular;
        private System.Windows.Forms.Button btCalcArea;
        private System.Windows.Forms.Button btCalcPerimetro;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView lvAreas;
        private System.Windows.Forms.Label lbCalculoDeAreas;
        private System.Windows.Forms.Label lbCalculoDePerimetros;
        private System.Windows.Forms.ListView lvPerimetros;
        private System.Windows.Forms.Label lbDados;
        private System.Windows.Forms.Panel pnlInputQuadrado;
        private System.Windows.Forms.TextBox tbLadoQuadrado;
        private System.Windows.Forms.Panel pnlInputTriangulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAlturaTriangulo;
        private System.Windows.Forms.TextBox tbBaseTriangulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInputRetangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAlturaRetangulo;
        private System.Windows.Forms.TextBox tbBaseRetangulo;
    }
}

