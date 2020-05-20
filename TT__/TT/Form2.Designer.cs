namespace TT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblEditar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtColab = new System.Windows.Forms.TextBox();
            this.lblColab = new System.Windows.Forms.Label();
            this.txtNomCan = new System.Windows.Forms.TextBox();
            this.lblNomCan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEditar.Location = new System.Drawing.Point(58, 9);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(273, 43);
            this.lblEditar.TabIndex = 0;
            this.lblEditar.Text = "Editar datos del club";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(152, 308);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(99, 35);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(80, 267);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(231, 20);
            this.txtAlbum.TabIndex = 25;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlbum.Location = new System.Drawing.Point(77, 251);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(89, 13);
            this.lblAlbum.TabIndex = 30;
            this.lblAlbum.Text = "Nombre de la liga";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(80, 218);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(231, 20);
            this.txtGen.TabIndex = 24;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGen.Location = new System.Drawing.Point(75, 202);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(115, 13);
            this.lblGen.TabIndex = 29;
            this.lblGen.Text = "Nombre del entrenador";
            this.lblGen.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(81, 166);
            this.txtArt.Multiline = true;
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(231, 25);
            this.txtArt.TabIndex = 23;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArt.Location = new System.Drawing.Point(77, 150);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(98, 13);
            this.lblArt.TabIndex = 28;
            this.lblArt.Text = "Nombre del estadio";
            // 
            // txtColab
            // 
            this.txtColab.Location = new System.Drawing.Point(80, 118);
            this.txtColab.Name = "txtColab";
            this.txtColab.Size = new System.Drawing.Size(231, 20);
            this.txtColab.TabIndex = 22;
            // 
            // lblColab
            // 
            this.lblColab.AutoSize = true;
            this.lblColab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColab.Location = new System.Drawing.Point(77, 102);
            this.lblColab.Name = "lblColab";
            this.lblColab.Size = new System.Drawing.Size(113, 13);
            this.lblColab.TabIndex = 27;
            this.lblColab.Text = "Nombre del presidente";
            // 
            // txtNomCan
            // 
            this.txtNomCan.Location = new System.Drawing.Point(80, 73);
            this.txtNomCan.Name = "txtNomCan";
            this.txtNomCan.Size = new System.Drawing.Size(231, 20);
            this.txtNomCan.TabIndex = 21;
            this.txtNomCan.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblNomCan
            // 
            this.lblNomCan.AutoSize = true;
            this.lblNomCan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomCan.Location = new System.Drawing.Point(78, 56);
            this.lblNomCan.Name = "lblNomCan";
            this.lblNomCan.Size = new System.Drawing.Size(84, 13);
            this.lblNomCan.TabIndex = 26;
            this.lblNomCan.Text = "Nombre del club\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(388, 368);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblColab);
            this.Controls.Add(this.lblNomCan);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtColab);
            this.Controls.Add(this.txtNomCan);
            this.Controls.Add(this.lblEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar clubes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditar;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblAlbum;
        public System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblGen;
        public System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label lblArt;
        public System.Windows.Forms.TextBox txtColab;
        private System.Windows.Forms.Label lblColab;
        public System.Windows.Forms.TextBox txtNomCan;
        private System.Windows.Forms.Label lblNomCan;
    }
}