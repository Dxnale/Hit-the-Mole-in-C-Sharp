namespace PROG2EVA1javierNievesDanielTorrealba
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxRut = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.rutLabel = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxNombre.Location = new System.Drawing.Point(87, 142);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(261, 30);
            this.textBoxNombre.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(147, 260);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(141, 41);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("DINPro-Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLogin.Location = new System.Drawing.Point(156, 72);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(123, 51);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            // 
            // textBoxRut
            // 
            this.textBoxRut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.textBoxRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRut.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxRut.Location = new System.Drawing.Point(87, 200);
            this.textBoxRut.Name = "textBoxRut";
            this.textBoxRut.Size = new System.Drawing.Size(261, 30);
            this.textBoxRut.TabIndex = 1;
            this.textBoxRut.TextChanged += new System.EventHandler(this.textBoxRut_TextChanged);
            this.textBoxRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRut_KeyPress);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nombreLabel.Location = new System.Drawing.Point(94, 133);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(56, 16);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre";
            // 
            // rutLabel
            // 
            this.rutLabel.AutoSize = true;
            this.rutLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.rutLabel.Location = new System.Drawing.Point(94, 189);
            this.rutLabel.Name = "rutLabel";
            this.rutLabel.Size = new System.Drawing.Size(36, 16);
            this.rutLabel.TabIndex = 5;
            this.rutLabel.Text = "RUT";
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.AutoEllipsis = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.resultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultado.Location = new System.Drawing.Point(251, 219);
            this.resultado.Margin = new System.Windows.Forms.Padding(0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(91, 21);
            this.resultado.TabIndex = 14;
            this.resultado.Text = "Ingrese RUT";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(435, 384);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.rutLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.textBoxRut);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxRut;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label rutLabel;
        private System.Windows.Forms.Label resultado;
    }
}

