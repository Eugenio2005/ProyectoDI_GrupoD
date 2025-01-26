namespace ProyectoDI_GrupoD.Vistas
{
    partial class FormMisFacturas
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
            this.comboBoxAnios = new System.Windows.Forms.ComboBox();
            this.comboBoxMeses = new System.Windows.Forms.ComboBox();
            this.buttonDescargarFactura = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // comboBoxAnios
            // 
            this.comboBoxAnios.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxAnios.FormattingEnabled = true;
            this.comboBoxAnios.Location = new System.Drawing.Point(12, 274);
            this.comboBoxAnios.Name = "comboBoxAnios";
            this.comboBoxAnios.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnios.TabIndex = 0;
            this.comboBoxAnios.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnios_SelectedIndexChanged);
            // 
            // comboBoxMeses
            // 
            this.comboBoxMeses.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeses.FormattingEnabled = true;
            this.comboBoxMeses.Location = new System.Drawing.Point(12, 323);
            this.comboBoxMeses.Name = "comboBoxMeses";
            this.comboBoxMeses.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMeses.TabIndex = 1;
            this.comboBoxMeses.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeses_SelectedIndexChanged);
            // 
            // buttonDescargarFactura
            // 
            this.buttonDescargarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.buttonDescargarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescargarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.buttonDescargarFactura.Location = new System.Drawing.Point(12, 369);
            this.buttonDescargarFactura.Name = "buttonDescargarFactura";
            this.buttonDescargarFactura.Size = new System.Drawing.Size(200, 30);
            this.buttonDescargarFactura.TabIndex = 2;
            this.buttonDescargarFactura.Text = "Descargar Factura";
            this.buttonDescargarFactura.UseVisualStyleBackColor = false;
            this.buttonDescargarFactura.Click += new System.EventHandler(this.ButtonDescargarFactura_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(229, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(934, 671);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormMisFacturas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1175, 695);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.buttonDescargarFactura);
            this.Controls.Add(this.comboBoxMeses);
            this.Controls.Add(this.comboBoxAnios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMisFacturas";
            this.Text = "Mis Facturas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAnios;
        private System.Windows.Forms.ComboBox comboBoxMeses;
        private System.Windows.Forms.Button buttonDescargarFactura;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
