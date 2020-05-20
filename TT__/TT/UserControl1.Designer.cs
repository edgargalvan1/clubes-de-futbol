namespace TT
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_club = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCanciones = new System.Windows.Forms.GroupBox();
            this.lblAlb = new System.Windows.Forms.Label();
            this.lblArtistaP = new System.Windows.Forms.Label();
            this.lblCancion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.gbCanciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_club
            // 
            this.LB_club.AutoSize = true;
            this.LB_club.Location = new System.Drawing.Point(107, 26);
            this.LB_club.Name = "LB_club";
            this.LB_club.Size = new System.Drawing.Size(0, 13);
            this.LB_club.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(150, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbCanciones
            // 
            this.gbCanciones.Controls.Add(this.lblAlb);
            this.gbCanciones.Controls.Add(this.lblArtistaP);
            this.gbCanciones.Controls.Add(this.lblCancion);
            this.gbCanciones.Controls.Add(this.button1);
            this.gbCanciones.Controls.Add(this.lblNombreP);
            this.gbCanciones.Location = new System.Drawing.Point(3, 15);
            this.gbCanciones.Name = "gbCanciones";
            this.gbCanciones.Size = new System.Drawing.Size(246, 120);
            this.gbCanciones.TabIndex = 22;
            this.gbCanciones.TabStop = false;
            this.gbCanciones.Text = "Clubes";
            this.gbCanciones.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblAlb
            // 
            this.lblAlb.AutoSize = true;
            this.lblAlb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlb.Location = new System.Drawing.Point(98, 48);
            this.lblAlb.Name = "lblAlb";
            this.lblAlb.Size = new System.Drawing.Size(35, 13);
            this.lblAlb.TabIndex = 27;
            this.lblAlb.Text = "label2";
            this.lblAlb.Click += new System.EventHandler(this.lblArt_Click);
            // 
            // lblArtistaP
            // 
            this.lblArtistaP.AutoSize = true;
            this.lblArtistaP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtistaP.Location = new System.Drawing.Point(27, 48);
            this.lblArtistaP.Name = "lblArtistaP";
            this.lblArtistaP.Size = new System.Drawing.Size(45, 13);
            this.lblArtistaP.TabIndex = 26;
            this.lblArtistaP.Text = "Estadio:";
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCancion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCancion.Location = new System.Drawing.Point(98, 22);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(35, 13);
            this.lblCancion.TabIndex = 24;
            this.lblCancion.Text = "label6";
            this.lblCancion.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(86, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreP.Location = new System.Drawing.Point(27, 22);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(31, 13);
            this.lblNombreP.TabIndex = 22;
            this.lblNombreP.Text = "Club:";
            this.lblNombreP.Click += new System.EventHandler(this.lblNombreP_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.gbCanciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB_club);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(252, 135);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.gbCanciones.ResumeLayout(false);
            this.gbCanciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_club;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCanciones;
        public System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombreP;
        public System.Windows.Forms.Label lblAlb;
        private System.Windows.Forms.Label lblArtistaP;
    }
}
