using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class RAIZ: UserControl
    {
        public RAIZ()
        {
            InitializeComponent();
        }
        public void cambiarText(string l, string c)
        {
            groupBox1.Text = l;
            btnCalcular.Text = c;
            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtA.Text != "")
                {
                    double A = double.Parse(txtA.Text);

                    double res = Math.Sqrt(A);
                    lblResultado.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("No debe dejar campos vacios!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar ingresar un dato");
            }
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
