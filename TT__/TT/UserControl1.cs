using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT
{
    public partial class UserControl1 : UserControl
    {
        Class1 GlobalC1 = new Class1();

        
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(Class1 cl)
        {
            InitializeComponent();

            lblCancion.Text = cl.NombrePelicula;
            lblAlb.Text = cl.Art;
            GlobalC1 = cl;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(GlobalC1);
            
            f2.ShowDialog();
            lblCancion.Text = GlobalC1.NombrePelicula;
            lblAlb.Text = GlobalC1.Art;



        }
        public void cambiarTexto(string nombre, string arti, string cancion)
        {
            lblArtistaP.Text = arti;
            lblNombreP.Text = nombre;
            gbCanciones.Text = cancion;       
        

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNombreP_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void lblArt_Click(object sender, EventArgs e)
        {

        }
    }
}
