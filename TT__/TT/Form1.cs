using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;
namespace TT
{
    public partial class Form1 : Form
    {

        int mv = 0;
        int cont = 0;
        List<UserControl> Todosmiuc1 = new List<UserControl>();
        Class1 GlobalC1 = new Class1();
        dllgraficador.uc_grafica gra = new dllgraficador.uc_grafica();
        public Form1()
        {
            InitializeComponent();
        }
        private bool validarCampos()
        {
            bool ok = true;
            if(txtNom.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNom,"Ingrese Nombre de canción");
            }
            if (txtColab.Text =="")
            {
                ok = false;
                errorProvider1.SetError(txtColab,"Campo Obligatorio");
            }
            if (txtArt.Text =="")
            {
                ok = false;
                errorProvider1.SetError(txtArt, "Nombre del artista");
            }
            if (txtGen.Text =="")
            {
                ok = false;
                errorProvider1.SetError(txtGen, "Campo Obligatorio");
            }
            if (txtDura.Text =="")
            {
                ok = false;
                errorProvider1.SetError(txtDura, "Campo Obligatorio");
            }
            return ok;
        }
        public void clearError()
        {
            errorProvider1.SetError(txtNom, "");
            errorProvider1.SetError(txtColab, "");
            errorProvider1.SetError(txtArt, "");
            errorProvider1.SetError(txtGen, "");
            errorProvider1.SetError(txtDura, "");
        }
        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                clearError();
                if (validarCampos())
                {


                    Class1 cl = new Class1();


                    uc_grafica2.anadirDatos(txtNom.Text, int.Parse(txtDura.Text));

                    cl.NombrePelicula = txtNom.Text;
                    cl.Colab = txtColab.Text;
                    cl.Art = txtArt.Text;
                    cl.Genero = txtGen.Text;
                    cl.Album = txtAlb.Text;

                    UserControl1 UC = new UserControl1(cl);
                    panel1.Controls.Add(UC);
                    Todosmiuc1.Add(UC);


                    UC.Location = new System.Drawing.Point(15, mv);
                    mv = UC.Size.Height + mv;

                    txtNom.Clear();
                    txtColab.Clear();
                    txtArt.Clear();
                    txtGen.Clear();
                    txtAlb.Clear();
                    txtDura.Clear();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Huvo un error en los datos. Vuelva a intentarlo    " + ex);

            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbIdioma.SelectedIndex = 0;
            panel_graf.Controls.Add(gra);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_graf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void uc_grafica2_Load(object sender, EventArgs e)
        {

        }
   
        public void cambioIdioma()
        {
            Form2 f = new Form2();
            UserControl1 con = new UserControl1();
            lblRegistro.Text = lang.Res.Reg_canciones;
            lblNombre.Text = lang.Res.Nom_cancion;
            lblColab.Text = lang.Res.Colab;
            lblArt.Text = lang.Res.Art_Inc;
            lblGen.Text = lang.Res.Genero;
            lblAlb.Text = lang.Res.Album;
            lblDura.Text = lang.Res.Duracion;
            btnAgregar.Text = lang.Res.btnAgregar;
            
            cbIdioma.Text = lang.Res.Sel_idioma;
           
            raiz1.cambiarText(lang.Res.gbText, lang.Res.Calcular);
            con.cambiarTexto(lang.Res.NomCancion,lang.Res.NomArt, lang.Res.Canciones);
            f.cambiarTexto(lang.Res.Editar, lang.Res.Nom_cancion, lang.Res.Art_Inc, lang.Res.Colab, lang.Res.Genero, lang.Res.Album,lang.Res.Actualizar);
            f.Update();
            con.Update();
            

        }
        private void comboBox_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            UserControl1 uc = new UserControl1();
            if(cbIdioma.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                cambioIdioma();
                f.Update();
                uc.Update();

            }
            if (cbIdioma.SelectedIndex ==1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                cambioIdioma();
                f.Update();
                uc.Update();
            }
            if (cbIdioma.SelectedIndex == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                cambioIdioma();
                f.Update();
                uc.Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            GlobalC1.Color = color.Color;
            this.BackColor = color.Color;
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto de Kevin Diaz y Yeison Espinosa");
        }
    }
}
        
