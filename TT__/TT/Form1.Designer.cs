namespace TT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblColab = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblAlb = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtColab = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtAlb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel_graf = new System.Windows.Forms.Panel();
            this.uc_grafica2 = new dllgraficador.uc_grafica();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.lblDura = new System.Windows.Forms.Label();
            this.lblSelIdioma = new System.Windows.Forms.Label();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.uc_grafica1 = new dllgraficador.uc_grafica();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.raiz1 = new WindowsFormsControlLibrary1.RAIZ();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_graf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistro.Location = new System.Drawing.Point(12, 59);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(239, 43);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro de Clubes";
            this.lblRegistro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblColab
            // 
            this.lblColab.AutoSize = true;
            this.lblColab.Location = new System.Drawing.Point(28, 168);
            this.lblColab.Name = "lblColab";
            this.lblColab.Size = new System.Drawing.Size(57, 13);
            this.lblColab.TabIndex = 2;
            this.lblColab.Text = "Presidente";
            this.lblColab.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(28, 215);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(42, 13);
            this.lblArt.TabIndex = 3;
            this.lblArt.Text = "Estadio";
            this.lblArt.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(32, 309);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(59, 13);
            this.lblGen.TabIndex = 4;
            this.lblGen.Text = "Entrenador\r\n";
            this.lblGen.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAlb
            // 
            this.lblAlb.AutoSize = true;
            this.lblAlb.Location = new System.Drawing.Point(32, 262);
            this.lblAlb.Name = "lblAlb";
            this.lblAlb.Size = new System.Drawing.Size(27, 13);
            this.lblAlb.TabIndex = 5;
            this.lblAlb.Text = "Liga";
            this.lblAlb.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(31, 135);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(199, 20);
            this.txtNom.TabIndex = 6;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtColab
            // 
            this.txtColab.Location = new System.Drawing.Point(31, 184);
            this.txtColab.Name = "txtColab";
            this.txtColab.Size = new System.Drawing.Size(199, 20);
            this.txtColab.TabIndex = 7;
            this.txtColab.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(31, 231);
            this.txtArt.Multiline = true;
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(199, 20);
            this.txtArt.TabIndex = 8;
            this.txtArt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(31, 278);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(199, 20);
            this.txtGen.TabIndex = 9;
            this.txtGen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAlb
            // 
            this.txtAlb.Location = new System.Drawing.Point(31, 325);
            this.txtAlb.Name = "txtAlb";
            this.txtAlb.Size = new System.Drawing.Size(199, 20);
            this.txtAlb.TabIndex = 10;
            this.txtAlb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(296, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 364);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(77, 401);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 30);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            this.btnAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // panel_graf
            // 
            this.panel_graf.Controls.Add(this.uc_grafica2);
            this.panel_graf.Location = new System.Drawing.Point(596, 28);
            this.panel_graf.Name = "panel_graf";
            this.panel_graf.Size = new System.Drawing.Size(351, 370);
            this.panel_graf.TabIndex = 13;
            this.panel_graf.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_graf_Paint);
            // 
            // uc_grafica2
            // 
            this.uc_grafica2.BackColor = System.Drawing.Color.IndianRed;
            this.uc_grafica2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uc_grafica2.Location = new System.Drawing.Point(-16, 0);
            this.uc_grafica2.Margin = new System.Windows.Forms.Padding(2);
            this.uc_grafica2.Name = "uc_grafica2";
            this.uc_grafica2.Size = new System.Drawing.Size(368, 374);
            this.uc_grafica2.TabIndex = 0;
            this.uc_grafica2.Load += new System.EventHandler(this.uc_grafica2_Load);
            // 
            // txtDura
            // 
            this.txtDura.Location = new System.Drawing.Point(31, 372);
            this.txtDura.Name = "txtDura";
            this.txtDura.Size = new System.Drawing.Size(199, 20);
            this.txtDura.TabIndex = 11;
            // 
            // lblDura
            // 
            this.lblDura.AutoSize = true;
            this.lblDura.Location = new System.Drawing.Point(31, 356);
            this.lblDura.Name = "lblDura";
            this.lblDura.Size = new System.Drawing.Size(38, 13);
            this.lblDura.TabIndex = 14;
            this.lblDura.Text = "Titulos";
            this.lblDura.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSelIdioma
            // 
            this.lblSelIdioma.AutoSize = true;
            this.lblSelIdioma.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelIdioma.Location = new System.Drawing.Point(31, 9);
            this.lblSelIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelIdioma.Name = "lblSelIdioma";
            this.lblSelIdioma.Size = new System.Drawing.Size(96, 13);
            this.lblSelIdioma.TabIndex = 15;
            this.lblSelIdioma.Text = "Seleccionar idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Chino (Manadarin)"});
            this.cbIdioma.Location = new System.Drawing.Point(34, 24);
            this.cbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(92, 21);
            this.cbIdioma.TabIndex = 16;
            this.cbIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBox_Idioma_SelectedIndexChanged);
            // 
            // uc_grafica1
            // 
            this.uc_grafica1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uc_grafica1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uc_grafica1.Location = new System.Drawing.Point(-6, -1);
            this.uc_grafica1.Margin = new System.Windows.Forms.Padding(2);
            this.uc_grafica1.Name = "uc_grafica1";
            this.uc_grafica1.Size = new System.Drawing.Size(356, 372);
            this.uc_grafica1.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // raiz1
            // 
            this.raiz1.Location = new System.Drawing.Point(936, 169);
            this.raiz1.Name = "raiz1";
            this.raiz1.Size = new System.Drawing.Size(254, 147);
            this.raiz1.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(28, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Club";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "¿Quienes somos?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1239, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.raiz1);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.lblSelIdioma);
            this.Controls.Add(this.txtDura);
            this.Controls.Add(this.lblDura);
            this.Controls.Add(this.panel_graf);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAlb);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtColab);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblAlb);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblColab);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clubes de futbol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_graf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblColab;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblAlb;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtColab;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtAlb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private dllgraficador.uc_grafica uc_grafica1;
        private System.Windows.Forms.Panel panel_graf;
        private System.Windows.Forms.TextBox txtDura;
        private System.Windows.Forms.Label lblDura;
        private System.Windows.Forms.Label lblSelIdioma;
        private System.Windows.Forms.ComboBox cbIdioma;
        private WindowsFormsControlLibrary1.RAIZ raiz1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private dllgraficador.uc_grafica uc_grafica2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
    }
}

