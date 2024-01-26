namespace PROG2EVA1javierNievesDanielTorrealba.Forms
{
    partial class Actions
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAcciones = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DTPickerHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPickerDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnTraspaso = new System.Windows.Forms.Button();
            this.btnFrecuencia = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.lblEVA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.Font = new System.Drawing.Font("DINPro-Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAcciones.Location = new System.Drawing.Point(31, 36);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(183, 51);
            this.lblAcciones.TabIndex = 13;
            this.lblAcciones.Text = "Acciones";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DTPickerHasta);
            this.splitContainer1.Panel1.Controls.Add(this.DTPickerDesde);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblAcciones);
            this.splitContainer1.Panel1.Controls.Add(this.btnJugar);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel1.Controls.Add(this.btnPDF);
            this.splitContainer1.Panel1.Controls.Add(this.btnTraspaso);
            this.splitContainer1.Panel1.Controls.Add(this.btnFrecuencia);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAdmin);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 524);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 0;
            // 
            // DTPickerHasta
            // 
            this.DTPickerHasta.Location = new System.Drawing.Point(24, 159);
            this.DTPickerHasta.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.DTPickerHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPickerHasta.Name = "DTPickerHasta";
            this.DTPickerHasta.Size = new System.Drawing.Size(260, 22);
            this.DTPickerHasta.TabIndex = 15;
            // 
            // DTPickerDesde
            // 
            this.DTPickerDesde.Location = new System.Drawing.Point(24, 119);
            this.DTPickerDesde.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.DTPickerDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPickerDesde.Name = "DTPickerDesde";
            this.DTPickerDesde.Size = new System.Drawing.Size(260, 22);
            this.DTPickerDesde.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde";
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(24, 467);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(83, 31);
            this.btnJugar.TabIndex = 5;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(24, 369);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(260, 41);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Exportar a Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(24, 418);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(260, 41);
            this.btnPDF.TabIndex = 4;
            this.btnPDF.Text = "Exportar a PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnTraspaso
            // 
            this.btnTraspaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraspaso.Location = new System.Drawing.Point(24, 271);
            this.btnTraspaso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraspaso.Name = "btnTraspaso";
            this.btnTraspaso.Size = new System.Drawing.Size(260, 41);
            this.btnTraspaso.TabIndex = 1;
            this.btnTraspaso.Text = "Traspasar a tabla";
            this.btnTraspaso.UseVisualStyleBackColor = true;
            this.btnTraspaso.Click += new System.EventHandler(this.btnTraspaso_Click);
            // 
            // btnFrecuencia
            // 
            this.btnFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrecuencia.Location = new System.Drawing.Point(24, 320);
            this.btnFrecuencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFrecuencia.Name = "btnFrecuencia";
            this.btnFrecuencia.Size = new System.Drawing.Size(260, 41);
            this.btnFrecuencia.TabIndex = 2;
            this.btnFrecuencia.Text = "Frecuencia";
            this.btnFrecuencia.UseVisualStyleBackColor = true;
            this.btnFrecuencia.Click += new System.EventHandler(this.btnFrecuencia_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(113, 467);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(201, 467);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 31);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Mostrar todo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmin.EnableHeadersVisualStyles = false;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 0);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAdmin.ShowCellErrors = false;
            this.dgvAdmin.ShowCellToolTips = false;
            this.dgvAdmin.ShowEditingIcon = false;
            this.dgvAdmin.ShowRowErrors = false;
            this.dgvAdmin.Size = new System.Drawing.Size(700, 524);
            this.dgvAdmin.TabIndex = 0;
            // 
            // lblEVA
            // 
            this.lblEVA.AutoSize = true;
            this.lblEVA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEVA.Font = new System.Drawing.Font("DINPro-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEVA.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEVA.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblEVA.Location = new System.Drawing.Point(0, 524);
            this.lblEVA.Name = "lblEVA";
            this.lblEVA.Size = new System.Drawing.Size(27, 26);
            this.lblEVA.TabIndex = 5;
            this.lblEVA.Text = "   ";
            this.lblEVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1012, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblEVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Actions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Actions_FormClosing);
            this.Load += new System.EventHandler(this.Actions_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblEVA;
        private System.Windows.Forms.Button btnFrecuencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DTPickerHasta;
        private System.Windows.Forms.DateTimePicker DTPickerDesde;
        private System.Windows.Forms.Button btnTraspaso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
    }
}