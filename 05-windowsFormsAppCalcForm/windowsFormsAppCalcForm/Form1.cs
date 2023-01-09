using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowsFormsAppCalcForm.Properties;

namespace windowsFormsAppCalcForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GerarListViewArea();
            GerarListViewPerimetro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void limparInfo()
        {
            // lbSuperior -> raio, bases e lados menores
            // lbInferior -> alturas e lados maiores
            pictureBox.Image = Resources.branco;

            //Quadrado
            tbLadoQuadrado.Text = string.Empty;

            //Triangulo
            tbBaseTriangulo.Text = string.Empty;
            tbAlturaTriangulo.Text = string.Empty;

            //Retangulo
            //tbBaseRetangulo.Text = string.Empty;
            //tbAlturaRetangulo.Text = string.Empty;
        }

        private void ocultarPainel()
        {
            //PNLS
            pnlInputQuadrado.Visible = false;
            pnlInputTriangulo.Visible = false;
            pnlInputRetangulo.Visible = false;

            pnlInputQuadrado.Enabled = false;
            pnlInputRetangulo.Enabled = false;
            pnlInputTriangulo.Enabled = false;


            /*pnlTriangulo.SendToBack();
            pnlQuadrado.SendToBack();
            pnlRetangulo.SendToBack();*/
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            limparInfo();

            pictureBox.Image = Resources.triangulo;
            btCalcArea.Enabled = true;
            btCalcPerimetro.Enabled = true;

            ocultarPainel();
            pnlInputTriangulo.Visible = true;
            pnlInputTriangulo.Enabled = true;
            pnlInputTriangulo.BringToFront();
        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            limparInfo();
            pictureBox.Image = Resources.retangulo;
            btCalcArea.Enabled = true;
            btCalcPerimetro.Enabled = true;

            ocultarPainel();            
            pnlInputRetangulo.BringToFront();
            pnlInputRetangulo.Enabled = true;
            pnlInputRetangulo.Visible = true;
        }


        private void rbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            limparInfo();
            pictureBox.Image = Resources.quadrado;
            btCalcArea.Enabled = true;
            btCalcPerimetro.Enabled = true;

            ocultarPainel();
            pnlInputQuadrado.BringToFront();
            pnlInputQuadrado.Enabled = true;
            pnlInputQuadrado.Visible = true;
        }
        // --- Métodos para inserção do resultado na listview
        public void InsereAreaQuadrado(Formas quadrado)
        {
            string[] formasGeos = new string[9];
            formasGeos[0] = quadrado.Nome;
            formasGeos[1] = tbLadoQuadrado.Text;
            formasGeos[8] = Convert.ToString(quadrado.calcArea());
            lvAreas.Items.Add(new ListViewItem(formasGeos));
        }

        public void InsereAreaTriangulo(Formas triangulo)
        {
            string[] formasGeos = new string[9];
            formasGeos[0] = triangulo.Nome;
            formasGeos[2] = tbAlturaTriangulo.Text;
            formasGeos[3] = tbBaseTriangulo.Text;
            formasGeos[8] = Convert.ToString(triangulo.calcArea());
            lvAreas.Items.Add(new ListViewItem(formasGeos));
        }

        public void InsereAreaRetangulo(Formas retangulo)
        {
            string[] formasGeos = new string[9];
            formasGeos[0] = retangulo.Nome;
            formasGeos[1] = tbBaseRetangulo.Text;
            formasGeos[2] = tbAlturaRetangulo.Text;
            formasGeos[8] = Convert.ToString(retangulo.calcArea());
            lvAreas.Items.Add(new ListViewItem(formasGeos));
        }

        public void InserePerimetroQuadrado(Formas quadrado)
        {
            string[] formasGeos = new string[9];
            formasGeos[0] = quadrado.Nome;
            formasGeos[1] = tbLadoQuadrado.Text;
            formasGeos[8] = Convert.ToString(quadrado.calcPerimetro());
            lvPerimetros.Items.Add(new ListViewItem(formasGeos));
        }
        public void InserePerimetroTriangulo(Formas triangulo)
        {
            string[] formasGeos = new string[9];
            formasGeos[0] = triangulo.Nome;
            formasGeos[2] = tbAlturaTriangulo.Text;
            formasGeos[3] = tbBaseTriangulo.Text;
            formasGeos[8] = Convert.ToString(triangulo.calcPerimetro());
            lvPerimetros.Items.Add(new ListViewItem(formasGeos));
        }

        public void InserePerimetroRetangulo(Formas retangulo)
        {
            string[] formasGeos = new string[9];
            formasGeos[0] = retangulo.Nome;
            formasGeos[1] = tbBaseRetangulo.Text;
            formasGeos[2] = tbAlturaRetangulo.Text;
            formasGeos[8] = Convert.ToString(retangulo.calcPerimetro());
            lvPerimetros.Items.Add(new ListViewItem(formasGeos));
        }

        // --- Botoes ---
        private void btCalcArea_Click(object sender, EventArgs e)
        {
            if(rbQuadrado.Checked == true)
            {
                Formas objetoGeometrico = new Quadrado("Quadrado", Convert.ToDouble(tbLadoQuadrado.Text));
                InsereAreaQuadrado(objetoGeometrico);
                MensagemTelaArea(objetoGeometrico);
            }
            else if (rbTriangulo.Checked == true)
            {
                Formas objetoGeometrico = new Triangulo("Triangulo", Convert.ToDouble(tbBaseTriangulo.Text), Convert.ToDouble(tbAlturaTriangulo.Text));
                InsereAreaTriangulo(objetoGeometrico);
                MensagemTelaArea(objetoGeometrico);
            }
            else if (rbRetangulo.Checked == true)
            {
                Formas objetoGeometrico = new Retangulo("Retangulo", Convert.ToDouble(tbBaseRetangulo.Text), Convert.ToDouble(tbAlturaRetangulo.Text));
                InsereAreaRetangulo(objetoGeometrico);
                MensagemTelaArea(objetoGeometrico);
            }
        }

        private void btCalcPerimetro_Click(object sender, EventArgs e)
        {
            if (rbQuadrado.Checked == true)
            {
                Formas objetoGeometrico = new Quadrado("Quadrado", Convert.ToDouble(tbLadoQuadrado.Text));
                InserePerimetroQuadrado(objetoGeometrico);
                MensagemTelaPerimetro(objetoGeometrico);
            }
            else if (rbTriangulo.Checked == true)
            {
                Formas objetoGeometrico = new Triangulo("Triangulo", Convert.ToDouble(tbBaseTriangulo.Text), Convert.ToDouble(tbAlturaTriangulo.Text));
                InsereAreaTriangulo(objetoGeometrico);
                MensagemTelaPerimetro(objetoGeometrico);
            }
            else if (rbRetangulo.Checked == true)
            {
                Formas objetoGeometrico = new Retangulo("Retangulo", Convert.ToDouble(tbBaseRetangulo.Text), Convert.ToDouble(tbAlturaRetangulo.Text));
                InsereAreaRetangulo(objetoGeometrico);
                MensagemTelaPerimetro(objetoGeometrico);
            }
        }

        private void GerarListViewArea()
        {
            lvAreas.Columns.Add("Nome", 120).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Lado", 60).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Altura", 70).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Base", 60).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Base Menor", 110).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Diagonal", 120).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Diagonal Menor", 120).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Raio", 120).TextAlign = HorizontalAlignment.Center;
            lvAreas.Columns.Add("Area", 120).TextAlign = HorizontalAlignment.Center;
            lvAreas.View = View.Details;
        }
        private void GerarListViewPerimetro()
        {
            lvPerimetros.Columns.Add("Nome", 120).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Lado", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Altura", 70).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Base", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Base Menor", 110).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Diagonal", 100).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Diagonal Menor", 140).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Raio", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.Columns.Add("Area", 110).TextAlign = HorizontalAlignment.Center;
            lvPerimetros.View = View.Details;
        }

        private void MensagemTelaArea(Formas forma)
        {
            MessageBox.Show("Área: " + forma.calcArea(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemTelaPerimetro(Formas forma)
        {
            MessageBox.Show("Perímetro: " + forma.calcPerimetro(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemTelaEscolhaForma()
        {
            MessageBox.Show("Você deve escolher uma forma Geométrica.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ocultarPainel();
            limparInfo();
        }
    }
}
