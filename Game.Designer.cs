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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLP = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblScorePuntos = new System.Windows.Forms.Label();
            this.lblScoreTableTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelJuego = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxGolpeame = new System.Windows.Forms.PictureBox();
            this.panelMarginR = new System.Windows.Forms.Panel();
            this.panelMarginB = new System.Windows.Forms.Panel();
            this.panelMarginT = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblFallas = new System.Windows.Forms.Label();
            this.lblScoreFallas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGolpeame)).BeginInit();
            this.panelMarginT.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelJuego);
            this.splitContainer1.Panel2.Controls.Add(this.panelMarginR);
            this.splitContainer1.Panel2.Controls.Add(this.panelMarginB);
            this.splitContainer1.Panel2.Controls.Add(this.panelMarginT);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 702);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLP
            // 
            this.tableLP.ColumnCount = 4;
            this.tableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14286F));
            this.tableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.57142F));
            this.tableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLP.Controls.Add(this.lblNombre, 1, 1);
            this.tableLP.Controls.Add(this.lblPuntos, 1, 2);
            this.tableLP.Controls.Add(this.lblScorePuntos, 2, 2);
            this.tableLP.Controls.Add(this.lblScoreTableTitle, 1, 6);
            this.tableLP.Controls.Add(this.dataGridView1, 1, 7);
            this.tableLP.Controls.Add(this.lblFallas, 1, 3);
            this.tableLP.Controls.Add(this.lblScoreFallas, 2, 3);
            this.tableLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP.Location = new System.Drawing.Point(0, 0);
            this.tableLP.Name = "tableLP";
            this.tableLP.RowCount = 9;
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.947363F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.957263F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.957263F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.957263F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.957263F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.561254F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.700855F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.1396F));
            this.tableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.598394F));
            this.tableLP.Size = new System.Drawing.Size(348, 702);
            this.tableLP.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nunito Sans Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Coral;
            this.lblNombre.Location = new System.Drawing.Point(55, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Nunito Sans Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPuntos.Location = new System.Drawing.Point(55, 103);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(113, 30);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "PUNTOS:";
            // 
            // lblScorePuntos
            // 
            this.lblScorePuntos.AutoSize = true;
            this.lblScorePuntos.Font = new System.Drawing.Font("Nunito Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePuntos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScorePuntos.Location = new System.Drawing.Point(175, 103);
            this.lblScorePuntos.Name = "lblScorePuntos";
            this.lblScorePuntos.Size = new System.Drawing.Size(104, 30);
            this.lblScorePuntos.TabIndex = 2;
            this.lblScorePuntos.Text = "0000000";
            // 
            // lblScoreTableTitle
            // 
            this.tableLP.SetColumnSpan(this.lblScoreTableTitle, 2);
            this.lblScoreTableTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreTableTitle.Font = new System.Drawing.Font("Nunito Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTableTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblScoreTableTitle.Location = new System.Drawing.Point(55, 272);
            this.lblScoreTableTitle.Name = "lblScoreTableTitle";
            this.lblScoreTableTitle.Size = new System.Drawing.Size(239, 33);
            this.lblScoreTableTitle.TabIndex = 5;
            this.lblScoreTableTitle.Text = "TABLA DE RECORDS";
            this.lblScoreTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLP.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(55, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(239, 353);
            this.dataGridView1.TabIndex = 6;
            // 
            // panelJuego
            // 
            this.panelJuego.ColumnCount = 3;
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.Controls.Add(this.pictureBoxGolpeame, 2, 0);
            this.panelJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJuego.Location = new System.Drawing.Point(0, 60);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.RowCount = 4;
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelJuego.Size = new System.Drawing.Size(803, 597);
            this.panelJuego.TabIndex = 4;
            // 
            // pictureBoxGolpeame
            // 
            this.pictureBoxGolpeame.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGolpeame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGolpeame.ErrorImage = null;
            this.pictureBoxGolpeame.Image = global::PROG2EVA1javierNievesDanielTorrealba.Properties.Resources.topo_HIT;
            this.pictureBoxGolpeame.InitialImage = null;
            this.pictureBoxGolpeame.Location = new System.Drawing.Point(537, 3);
            this.pictureBoxGolpeame.Name = "pictureBoxGolpeame";
            this.pictureBoxGolpeame.Size = new System.Drawing.Size(263, 143);
            this.pictureBoxGolpeame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGolpeame.TabIndex = 1;
            this.pictureBoxGolpeame.TabStop = false;
            // 
            // panelMarginR
            // 
            this.panelMarginR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMarginR.Location = new System.Drawing.Point(803, 60);
            this.panelMarginR.Name = "panelMarginR";
            this.panelMarginR.Size = new System.Drawing.Size(44, 597);
            this.panelMarginR.TabIndex = 3;
            // 
            // panelMarginB
            // 
            this.panelMarginB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMarginB.Location = new System.Drawing.Point(0, 657);
            this.panelMarginB.Name = "panelMarginB";
            this.panelMarginB.Size = new System.Drawing.Size(847, 45);
            this.panelMarginB.TabIndex = 2;
            // 
            // panelMarginT
            // 
            this.panelMarginT.Controls.Add(this.lblTitle);
            this.panelMarginT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarginT.Location = new System.Drawing.Point(0, 0);
            this.panelMarginT.Name = "panelMarginT";
            this.panelMarginT.Size = new System.Drawing.Size(847, 60);
            this.panelMarginT.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(847, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "GOLPEA AL TOPO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFallas
            // 
            this.lblFallas.AutoSize = true;
            this.lblFallas.Font = new System.Drawing.Font("Nunito Sans Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallas.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFallas.Location = new System.Drawing.Point(55, 151);
            this.lblFallas.Name = "lblFallas";
            this.lblFallas.Size = new System.Drawing.Size(106, 30);
            this.lblFallas.TabIndex = 8;
            this.lblFallas.Text = "FALLAS:";
            // 
            // lblScoreFallas
            // 
            this.lblScoreFallas.AutoSize = true;
            this.lblScoreFallas.Font = new System.Drawing.Font("Nunito Sans SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreFallas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScoreFallas.Location = new System.Drawing.Point(175, 151);
            this.lblScoreFallas.Name = "lblScoreFallas";
            this.lblScoreFallas.Size = new System.Drawing.Size(104, 30);
            this.lblScoreFallas.TabIndex = 9;
            this.lblScoreFallas.Text = "0000000";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1199, 702);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.Text = "Golpea al topo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLP.ResumeLayout(false);
            this.tableLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGolpeame)).EndInit();
            this.panelMarginT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblScorePuntos;
        private System.Windows.Forms.Panel panelMarginT;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreTableTitle;
        private System.Windows.Forms.Panel panelMarginR;
        private System.Windows.Forms.Panel panelMarginB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel panelJuego;
        private System.Windows.Forms.PictureBox pictureBoxGolpeame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblFallas;
        private System.Windows.Forms.Label lblScoreFallas;
    }
}