
namespace InteleSys
{
    partial class FrmConfiguracionUsuarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsrs = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageUpdateUsr = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageUsrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsrs);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageUpdateUsr);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUsrs
            // 
            this.tabPageUsrs.Controls.Add(this.tableLayoutPanel1);
            this.tabPageUsrs.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsrs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUsrs.Name = "tabPageUsrs";
            this.tabPageUsrs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUsrs.Size = new System.Drawing.Size(592, 340);
            this.tabPageUsrs.TabIndex = 0;
            this.tabPageUsrs.Tag = "hOME";
            this.tabPageUsrs.Text = "Usuarios";
            this.tabPageUsrs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(592, 340);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Nuevo";
            // 
            // tabPageUpdateUsr
            // 
            this.tabPageUpdateUsr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUpdateUsr.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateUsr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUpdateUsr.Name = "tabPageUpdateUsr";
            this.tabPageUpdateUsr.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUpdateUsr.Size = new System.Drawing.Size(592, 340);
            this.tabPageUpdateUsr.TabIndex = 1;
            this.tabPageUpdateUsr.Text = "Editar";
            // 
            // FrmConfiguracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConfiguracionUsuarios";
            this.Text = "frmUsrConfiguracion";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsrs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsrs;
        private System.Windows.Forms.TabPage tabPageUpdateUsr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}