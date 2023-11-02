
namespace InteleSys
{
    partial class FormHome
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelUsr = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.panelCategoriaReportes = new System.Windows.Forms.Panel();
            this.buttonReportesInventario = new System.Windows.Forms.Button();
            this.buttonReportesMantenimiento = new System.Windows.Forms.Button();
            this.buttonReportesAverias = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonMantenimiento = new System.Windows.Forms.Button();
            this.buttonAverias = new System.Windows.Forms.Button();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.panelMainFrm = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCategoriaReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonLogo);
            this.panelHeader.Controls.Add(this.panelProfile);
            this.panelHeader.Controls.Add(this.panelToolBar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(993, 122);
            this.panelHeader.TabIndex = 3;
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackgroundImage = global::InteleSys.Properties.Resources.logoIntelident;
            this.buttonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Location = new System.Drawing.Point(-1, 8);
            this.buttonLogo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(261, 98);
            this.buttonLogo.TabIndex = 0;
            this.buttonLogo.UseVisualStyleBackColor = true;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.labelUsr);
            this.panelProfile.Controls.Add(this.pictureBoxProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelProfile.Location = new System.Drawing.Point(863, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(130, 122);
            this.panelProfile.TabIndex = 0;
            // 
            // labelUsr
            // 
            this.labelUsr.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsr.Location = new System.Drawing.Point(2, 90);
            this.labelUsr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(125, 19);
            this.labelUsr.TabIndex = 0;
            this.labelUsr.Text = "User";
            this.labelUsr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::InteleSys.Properties.Resources.profileFrank;
            this.pictureBoxProfile.Location = new System.Drawing.Point(31, 8);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // panelToolBar
            // 
            this.panelToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelToolBar.Location = new System.Drawing.Point(272, 8);
            this.panelToolBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(572, 110);
            this.panelToolBar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.buttonConfiguracion);
            this.panel2.Controls.Add(this.panelCategoriaReportes);
            this.panel2.Controls.Add(this.buttonReportes);
            this.panel2.Controls.Add(this.buttonMantenimiento);
            this.panel2.Controls.Add(this.buttonAverias);
            this.panel2.Controls.Add(this.buttonInventario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 504);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 63);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(44, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Configuracion de Usuario";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.Maroon;
            this.buttonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguracion.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguracion.Location = new System.Drawing.Point(0, 400);
            this.buttonConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(262, 57);
            this.buttonConfiguracion.TabIndex = 10;
            this.buttonConfiguracion.Text = "Configuración";
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // panelCategoriaReportes
            // 
            this.panelCategoriaReportes.Controls.Add(this.buttonReportesInventario);
            this.panelCategoriaReportes.Controls.Add(this.buttonReportesMantenimiento);
            this.panelCategoriaReportes.Controls.Add(this.buttonReportesAverias);
            this.panelCategoriaReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategoriaReportes.Enabled = false;
            this.panelCategoriaReportes.Location = new System.Drawing.Point(0, 228);
            this.panelCategoriaReportes.Margin = new System.Windows.Forms.Padding(2);
            this.panelCategoriaReportes.Name = "panelCategoriaReportes";
            this.panelCategoriaReportes.Size = new System.Drawing.Size(262, 172);
            this.panelCategoriaReportes.TabIndex = 9;
            this.panelCategoriaReportes.Visible = false;
            // 
            // buttonReportesInventario
            // 
            this.buttonReportesInventario.BackColor = System.Drawing.Color.Maroon;
            this.buttonReportesInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportesInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonReportesInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReportesInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReportesInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesInventario.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesInventario.ForeColor = System.Drawing.Color.White;
            this.buttonReportesInventario.Location = new System.Drawing.Point(44, 115);
            this.buttonReportesInventario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportesInventario.Name = "buttonReportesInventario";
            this.buttonReportesInventario.Size = new System.Drawing.Size(216, 57);
            this.buttonReportesInventario.TabIndex = 7;
            this.buttonReportesInventario.Text = "Reportes Inventario";
            this.buttonReportesInventario.UseVisualStyleBackColor = false;
            this.buttonReportesInventario.Click += new System.EventHandler(this.buttonReportesInventario_Click);
            // 
            // buttonReportesMantenimiento
            // 
            this.buttonReportesMantenimiento.BackColor = System.Drawing.Color.Maroon;
            this.buttonReportesMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportesMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonReportesMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReportesMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReportesMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesMantenimiento.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesMantenimiento.ForeColor = System.Drawing.Color.White;
            this.buttonReportesMantenimiento.Location = new System.Drawing.Point(44, 58);
            this.buttonReportesMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportesMantenimiento.Name = "buttonReportesMantenimiento";
            this.buttonReportesMantenimiento.Size = new System.Drawing.Size(216, 57);
            this.buttonReportesMantenimiento.TabIndex = 6;
            this.buttonReportesMantenimiento.Text = "Reportes Mantenimiento";
            this.buttonReportesMantenimiento.UseVisualStyleBackColor = false;
            this.buttonReportesMantenimiento.Click += new System.EventHandler(this.buttonReportesMantenimiento_Click);
            // 
            // buttonReportesAverias
            // 
            this.buttonReportesAverias.BackColor = System.Drawing.Color.Maroon;
            this.buttonReportesAverias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportesAverias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonReportesAverias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReportesAverias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReportesAverias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesAverias.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesAverias.ForeColor = System.Drawing.Color.White;
            this.buttonReportesAverias.Location = new System.Drawing.Point(44, 1);
            this.buttonReportesAverias.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportesAverias.Name = "buttonReportesAverias";
            this.buttonReportesAverias.Size = new System.Drawing.Size(216, 57);
            this.buttonReportesAverias.TabIndex = 5;
            this.buttonReportesAverias.Text = "Reportes Averías";
            this.buttonReportesAverias.UseVisualStyleBackColor = false;
            this.buttonReportesAverias.Click += new System.EventHandler(this.buttonReportesAverias_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackColor = System.Drawing.Color.Maroon;
            this.buttonReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.Color.White;
            this.buttonReportes.Location = new System.Drawing.Point(0, 171);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(262, 57);
            this.buttonReportes.TabIndex = 3;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = false;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonMantenimiento
            // 
            this.buttonMantenimiento.BackColor = System.Drawing.Color.Maroon;
            this.buttonMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMantenimiento.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMantenimiento.ForeColor = System.Drawing.Color.White;
            this.buttonMantenimiento.Location = new System.Drawing.Point(0, 114);
            this.buttonMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMantenimiento.Name = "buttonMantenimiento";
            this.buttonMantenimiento.Size = new System.Drawing.Size(262, 57);
            this.buttonMantenimiento.TabIndex = 2;
            this.buttonMantenimiento.Text = "Mantenimiento";
            this.buttonMantenimiento.UseVisualStyleBackColor = false;
            this.buttonMantenimiento.Click += new System.EventHandler(this.buttonMantenimiento_Click);
            // 
            // buttonAverias
            // 
            this.buttonAverias.BackColor = System.Drawing.Color.Maroon;
            this.buttonAverias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAverias.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAverias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonAverias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonAverias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAverias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAverias.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverias.ForeColor = System.Drawing.Color.White;
            this.buttonAverias.Location = new System.Drawing.Point(0, 57);
            this.buttonAverias.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAverias.Name = "buttonAverias";
            this.buttonAverias.Size = new System.Drawing.Size(262, 57);
            this.buttonAverias.TabIndex = 1;
            this.buttonAverias.Text = "Averías";
            this.buttonAverias.UseVisualStyleBackColor = false;
            this.buttonAverias.Click += new System.EventHandler(this.buttonAverias_Click);
            // 
            // buttonInventario
            // 
            this.buttonInventario.BackColor = System.Drawing.Color.Maroon;
            this.buttonInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventario.ForeColor = System.Drawing.Color.White;
            this.buttonInventario.Location = new System.Drawing.Point(0, 0);
            this.buttonInventario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(262, 57);
            this.buttonInventario.TabIndex = 0;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.UseVisualStyleBackColor = false;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);
            // 
            // panelMainFrm
            // 
            this.panelMainFrm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMainFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainFrm.Location = new System.Drawing.Point(262, 122);
            this.panelMainFrm.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainFrm.Name = "panelMainFrm";
            this.panelMainFrm.Size = new System.Drawing.Size(731, 504);
            this.panelMainFrm.TabIndex = 6;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 626);
            this.Controls.Add(this.panelMainFrm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCategoriaReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUsr;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonMantenimiento;
        private System.Windows.Forms.Button buttonAverias;
        private System.Windows.Forms.Button buttonConfiguracion;
        private System.Windows.Forms.Panel panelCategoriaReportes;
        private System.Windows.Forms.Button buttonReportesInventario;
        private System.Windows.Forms.Button buttonReportesMantenimiento;
        private System.Windows.Forms.Button buttonReportesAverias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelMainFrm;
    }
}

