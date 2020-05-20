using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dllgraficador
{
    public partial class uc_grafica : UserControl
    {
        public uc_grafica()
        {
            InitializeComponent();
        }
        public void anadirDatos(string nombre, int duracion)
        {

            grafica.Series[0].Points.AddXY(nombre, duracion);

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void grafica_Click(object sender, EventArgs e)
        {

        }

        private void uc_grafica_Load(object sender, EventArgs e)
        {

        }

        private void hover(object sender, EventArgs e)
        {
            grafica.Legends.Add("duracion");
        }

        private void leave(object sender, EventArgs e)
        {
            grafica.Legends.Clear();
        }
    }
}
