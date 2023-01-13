namespace wfaFinalProject
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnParts = new FontAwesome.Sharp.IconButton();
            this.btnAsset = new FontAwesome.Sharp.IconButton();
            this.btnCostumer = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new FontAwesome.Sharp.IconPictureBox();
            this.panelBackShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.leftPanel.Controls.Add(this.btnParts);
            this.leftPanel.Controls.Add(this.btnAsset);
            this.leftPanel.Controls.Add(this.btnCostumer);
            this.leftPanel.Controls.Add(this.btnHome);
            this.leftPanel.Controls.Add(this.panelLogo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 660);
            this.leftPanel.TabIndex = 0;
            // 
            // btnParts
            // 
            this.btnParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParts.FlatAppearance.BorderSize = 0;
            this.btnParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParts.ForeColor = System.Drawing.Color.White;
            this.btnParts.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.btnParts.IconColor = System.Drawing.Color.White;
            this.btnParts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParts.IconSize = 32;
            this.btnParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParts.Location = new System.Drawing.Point(0, 250);
            this.btnParts.Name = "btnParts";
            this.btnParts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnParts.Size = new System.Drawing.Size(200, 50);
            this.btnParts.TabIndex = 5;
            this.btnParts.Text = "Relação de Peças";
            this.btnParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParts.UseVisualStyleBackColor = true;
            this.btnParts.Click += new System.EventHandler(this.btnParts_Click);
            // 
            // btnAsset
            // 
            this.btnAsset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsset.FlatAppearance.BorderSize = 0;
            this.btnAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsset.ForeColor = System.Drawing.Color.White;
            this.btnAsset.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.btnAsset.IconColor = System.Drawing.Color.White;
            this.btnAsset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsset.IconSize = 32;
            this.btnAsset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsset.Location = new System.Drawing.Point(0, 200);
            this.btnAsset.Name = "btnAsset";
            this.btnAsset.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAsset.Size = new System.Drawing.Size(200, 50);
            this.btnAsset.TabIndex = 3;
            this.btnAsset.Text = "Ativos";
            this.btnAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsset.UseVisualStyleBackColor = true;
            this.btnAsset.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnCostumer
            // 
            this.btnCostumer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCostumer.FlatAppearance.BorderSize = 0;
            this.btnCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCostumer.ForeColor = System.Drawing.Color.White;
            this.btnCostumer.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.btnCostumer.IconColor = System.Drawing.Color.White;
            this.btnCostumer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCostumer.IconSize = 32;
            this.btnCostumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCostumer.Location = new System.Drawing.Point(0, 150);
            this.btnCostumer.Name = "btnCostumer";
            this.btnCostumer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCostumer.Size = new System.Drawing.Size(200, 50);
            this.btnCostumer.TabIndex = 2;
            this.btnCostumer.Text = "Clientes";
            this.btnCostumer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCostumer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCostumer.UseVisualStyleBackColor = true;
            this.btnCostumer.Click += new System.EventHandler(this.btnCostumer_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Início";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pictureBoxLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pictureBoxLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBoxLogo.IconSize = 91;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(194, 91);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelBackShadow
            // 
            this.panelBackShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelBackShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackShadow.Location = new System.Drawing.Point(200, 0);
            this.panelBackShadow.Name = "panelBackShadow";
            this.panelBackShadow.Size = new System.Drawing.Size(677, 9);
            this.panelBackShadow.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 9);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(677, 651);
            this.panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 660);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBackShadow);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnParts;
        private FontAwesome.Sharp.IconButton btnAsset;
        private FontAwesome.Sharp.IconButton btnCostumer;
        private FontAwesome.Sharp.IconPictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelBackShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

