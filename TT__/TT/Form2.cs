using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT
{
    public partial class Form2 : Form
    {
        Class1 GlobalC1 = new Class1();
        Form1 f1 = new Form1();

        List<UserControl> UserCon = new List<UserControl>();
        public Form2()
        {
            InitializeComponent();

        }

        public Form2(Class1 CS)
        {
            InitializeComponent();
            txtNomCan.Text = CS.NombrePelicula.ToString();
            txtArt.Text = CS.Art.ToString();
            txtColab.Text = CS.Colab.ToString();
            txtGen.Text = CS.Genero.ToString();
            txtAlbum.Text = CS.Album.ToString();
            this.BackColor = GlobalC1.Color;
            GlobalC1 = CS;
        }

        public void cambiarTexto(string editar, string nom, string art, string colab, string gen, string alb, string actu){

            lblEditar.Text = editar;
            lblNomCan.Text = nom;
            lblArt.Text = art;
            lblColab.Text = colab;
            lblGen.Text = gen;
            lblAlbum.Text = alb;
            btnActualizar.Text = actu;
        }
        public void button1_Click(object sender, EventArgs e)
        {

            GlobalC1.NombrePelicula = txtNomCan.Text;
            GlobalC1.Art = txtArt.Text;
            GlobalC1.Colab = txtColab.Text;
            GlobalC1.Genero = txtGen.Text;
            GlobalC1.Album = txtAlbum.Text;
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void Form2_Load(object sender, EventArgs e)
        {
            f1.cambioIdioma();
        }
    }
}

