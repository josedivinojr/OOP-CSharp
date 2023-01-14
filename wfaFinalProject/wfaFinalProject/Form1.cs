using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace wfaFinalProject
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton selectedButton;
        private Panel leftBorderButton;
        private Form currentChildForm;


        public Form1()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 50);
            leftPanel.Controls.Add(leftBorderButton);
        }

        //Methods
        private void ActivateButton(object senderButton, Color color)
        {
            //validating the button
            if (senderButton != null)
            {
                DisableButton();
                // highligth button
                selectedButton = (IconButton)senderButton;
                selectedButton.BackColor = Color.FromArgb(37, 37, 81);
                selectedButton.ForeColor = color;
                selectedButton.TextAlign = ContentAlignment.MiddleCenter;
                selectedButton.ImageAlign = ContentAlignment.MiddleCenter;
                selectedButton.IconColor = color;
                selectedButton.TextImageRelation = TextImageRelation.ImageBeforeText;

                // lighlight left border
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, selectedButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(31, 30, 68);
                selectedButton.ForeColor = Color.Gainsboro;
                selectedButton.TextAlign = ContentAlignment.MiddleLeft;
                selectedButton.ImageAlign = ContentAlignment.MiddleLeft;
                selectedButton.IconColor = Color.Gainsboro;
                selectedButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void ResetButton()
        {
            DisableButton();
            leftBorderButton.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
        }

        private void btnCostumer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new FormCostumer());
        }

        private void btnAsset_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new FormAsset());
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new FormAppointment());
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new FormParts());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new FormAppointment());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

    }
}
