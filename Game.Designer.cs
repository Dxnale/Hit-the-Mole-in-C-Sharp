using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    partial class Game
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLPInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblScorePuntos = new System.Windows.Forms.Label();
            this.lblScoreTableTitle = new System.Windows.Forms.Label();
            this.lblFallas = new System.Windows.Forms.Label();
            this.lblScoreFallas = new System.Windows.Forms.Label();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.lblShowDificultad = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridViewScores = new System.Windows.Forms.DataGridView();
            this.panelJuego = new System.Windows.Forms.TableLayoutPanel();
            this.panelMarginR = new System.Windows.Forms.Panel();
            this.panelMarginB = new System.Windows.Forms.Panel();
            this.lblEVA2 = new System.Windows.Forms.Label();
            this.panelMarginT = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLPInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).BeginInit();
            this.panelMarginB.SuspendLayout();
            this.panelMarginT.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLPInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelJuego);
            this.splitContainer1.Panel2.Controls.Add(this.panelMarginR);
            this.splitContainer1.Panel2.Controls.Add(this.panelMarginB);
            this.splitContainer1.Panel2.Controls.Add(this.panelMarginT);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 702);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLPInfo
            // 
            this.tableLPInfo.BackColor = System.Drawing.Color.Transparent;
            this.tableLPInfo.ColumnCount = 4;
            this.tableLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14286F));
            this.tableLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.57142F));
            this.tableLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLPInfo.Controls.Add(this.lblNombre, 1, 1);
            this.tableLPInfo.Controls.Add(this.lblPuntos, 1, 2);
            this.tableLPInfo.Controls.Add(this.lblScorePuntos, 2, 2);
            this.tableLPInfo.Controls.Add(this.lblScoreTableTitle, 1, 6);
            this.tableLPInfo.Controls.Add(this.lblFallas, 1, 3);
            this.tableLPInfo.Controls.Add(this.lblScoreFallas, 2, 3);
            this.tableLPInfo.Controls.Add(this.lblDificultad, 1, 4);
            this.tableLPInfo.Controls.Add(this.lblShowDificultad, 2, 4);
            this.tableLPInfo.Controls.Add(this.btnReset, 1, 8);
            this.tableLPInfo.Controls.Add(this.dataGridViewScores, 1, 7);
            this.tableLPInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLPInfo.Location = new System.Drawing.Point(0, 0);
            this.tableLPInfo.Name = "tableLPInfo";
            this.tableLPInfo.RowCount = 9;
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.947363F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.977208F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.410256F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.267806F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.957263F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.561254F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.700855F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.00855F));
            this.tableLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.11396F));
            this.tableLPInfo.Size = new System.Drawing.Size(348, 702);
            this.tableLPInfo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.tableLPInfo.SetColumnSpan(this.lblNombre, 2);
            this.lblNombre.Font = new System.Drawing.Font("Nunito Sans Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(139)))), ((int)(((byte)(114)))));
            this.lblNombre.Location = new System.Drawing.Point(55, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 41);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Nunito Sans Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.lblPuntos.Location = new System.Drawing.Point(55, 110);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(107, 30);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "PUNTOS";
            // 
            // lblScorePuntos
            // 
            this.lblScorePuntos.AutoSize = true;
            this.lblScorePuntos.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePuntos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScorePuntos.Location = new System.Drawing.Point(175, 110);
            this.lblScorePuntos.Name = "lblScorePuntos";
            this.lblScorePuntos.Size = new System.Drawing.Size(26, 30);
            this.lblScorePuntos.TabIndex = 2;
            this.lblScorePuntos.Text = "0";
            // 
            // lblScoreTableTitle
            // 
            this.tableLPInfo.SetColumnSpan(this.lblScoreTableTitle, 2);
            this.lblScoreTableTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreTableTitle.Font = new System.Drawing.Font("Nunito Sans Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.lblScoreTableTitle.Location = new System.Drawing.Point(55, 269);
            this.lblScoreTableTitle.Name = "lblScoreTableTitle";
            this.lblScoreTableTitle.Size = new System.Drawing.Size(239, 32);
            this.lblScoreTableTitle.TabIndex = 5;
            this.lblScoreTableTitle.Text = "TABLA DE RECORDS";
            this.lblScoreTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFallas
            // 
            this.lblFallas.AutoSize = true;
            this.lblFallas.Font = new System.Drawing.Font("Nunito Sans Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.lblFallas.Location = new System.Drawing.Point(55, 154);
            this.lblFallas.Name = "lblFallas";
            this.lblFallas.Size = new System.Drawing.Size(100, 30);
            this.lblFallas.TabIndex = 8;
            this.lblFallas.Text = "FALLAS";
            // 
            // lblScoreFallas
            // 
            this.lblScoreFallas.AutoSize = true;
            this.lblScoreFallas.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreFallas.ForeColor = System.Drawing.Color.Red;
            this.lblScoreFallas.Location = new System.Drawing.Point(175, 154);
            this.lblScoreFallas.Name = "lblScoreFallas";
            this.lblScoreFallas.Size = new System.Drawing.Size(26, 30);
            this.lblScoreFallas.TabIndex = 9;
            this.lblScoreFallas.Text = "0";
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.Font = new System.Drawing.Font("Nunito Sans Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.lblDificultad.Location = new System.Drawing.Point(55, 197);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(79, 30);
            this.lblDificultad.TabIndex = 10;
            this.lblDificultad.Text = "NIVEL";
            // 
            // lblShowDificultad
            // 
            this.lblShowDificultad.AutoSize = true;
            this.lblShowDificultad.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDificultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblShowDificultad.Location = new System.Drawing.Point(175, 197);
            this.lblShowDificultad.Name = "lblShowDificultad";
            this.lblShowDificultad.Size = new System.Drawing.Size(26, 30);
            this.lblShowDificultad.TabIndex = 11;
            this.lblShowDificultad.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.tableLPInfo.SetColumnSpan(this.btnReset, 2);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Nunito Sans Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.btnReset.Location = new System.Drawing.Point(55, 630);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(239, 48);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // dataGridViewScores
            // 
            this.dataGridViewScores.AllowUserToAddRows = false;
            this.dataGridViewScores.AllowUserToDeleteRows = false;
            this.dataGridViewScores.AllowUserToResizeColumns = false;
            this.dataGridViewScores.AllowUserToResizeRows = false;
            this.dataGridViewScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewScores.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewScores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScores.ColumnHeadersHeight = 29;
            this.dataGridViewScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewScores.ColumnHeadersVisible = false;
            this.tableLPInfo.SetColumnSpan(this.dataGridViewScores, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewScores.GridColor = System.Drawing.Color.Black;
            this.dataGridViewScores.Location = new System.Drawing.Point(55, 304);
            this.dataGridViewScores.MultiSelect = false;
            this.dataGridViewScores.Name = "dataGridViewScores";
            this.dataGridViewScores.ReadOnly = true;
            this.dataGridViewScores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewScores.RowHeadersVisible = false;
            this.dataGridViewScores.RowHeadersWidth = 51;
            this.dataGridViewScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nunito Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewScores.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScores.RowTemplate.Height = 24;
            this.dataGridViewScores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewScores.ShowCellErrors = false;
            this.dataGridViewScores.ShowCellToolTips = false;
            this.dataGridViewScores.ShowEditingIcon = false;
            this.dataGridViewScores.ShowRowErrors = false;
            this.dataGridViewScores.Size = new System.Drawing.Size(239, 320);
            this.dataGridViewScores.TabIndex = 13;
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego.ColumnCount = 3;
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJuego.Location = new System.Drawing.Point(0, 60);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.RowCount = 3;
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelJuego.Size = new System.Drawing.Size(806, 597);
            this.panelJuego.TabIndex = 4;
            // 
            // panelMarginR
            // 
            this.panelMarginR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panelMarginR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMarginR.Location = new System.Drawing.Point(806, 60);
            this.panelMarginR.Name = "panelMarginR";
            this.panelMarginR.Size = new System.Drawing.Size(44, 597);
            this.panelMarginR.TabIndex = 3;
            // 
            // panelMarginB
            // 
            this.panelMarginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panelMarginB.Controls.Add(this.lblEVA2);
            this.panelMarginB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMarginB.Location = new System.Drawing.Point(0, 657);
            this.panelMarginB.Name = "panelMarginB";
            this.panelMarginB.Size = new System.Drawing.Size(850, 45);
            this.panelMarginB.TabIndex = 2;
            // 
            // lblEVA2
            // 
            this.lblEVA2.BackColor = System.Drawing.Color.Transparent;
            this.lblEVA2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEVA2.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEVA2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.lblEVA2.Location = new System.Drawing.Point(71, 0);
            this.lblEVA2.Name = "lblEVA2";
            this.lblEVA2.Size = new System.Drawing.Size(779, 45);
            this.lblEVA2.TabIndex = 2;
            this.lblEVA2.Text = "DANIEL TORRREALBA EVALUACION 3";
            this.lblEVA2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMarginT
            // 
            this.panelMarginT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panelMarginT.Controls.Add(this.lblTitle);
            this.panelMarginT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarginT.Location = new System.Drawing.Point(0, 0);
            this.panelMarginT.Name = "panelMarginT";
            this.panelMarginT.Size = new System.Drawing.Size(850, 60);
            this.panelMarginT.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(850, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "GOLPEA AL TOPO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PROG2EVA1javierNievesDanielTorrealba.Properties.Resources.FONDO;
            this.ClientSize = new System.Drawing.Size(1199, 702);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Golpea al topo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLPInfo.ResumeLayout(false);
            this.tableLPInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).EndInit();
            this.panelMarginB.ResumeLayout(false);
            this.panelMarginT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLPInfo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblScorePuntos;
        private System.Windows.Forms.Panel panelMarginT;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreTableTitle;
        private System.Windows.Forms.Panel panelMarginR;
        private System.Windows.Forms.Panel panelMarginB;
        private System.Windows.Forms.Label lblFallas;
        private System.Windows.Forms.Label lblScoreFallas;
        private System.Windows.Forms.TableLayoutPanel panelJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.Label lblShowDificultad;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridViewScores;
        private Label lblEVA2;
    }
}