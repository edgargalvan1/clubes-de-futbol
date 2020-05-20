using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace dllgraficador
{
    public class cs_Graficador
    {
        uc_grafica miPanel = new uc_grafica();
        
        public void IngresarValores(string nombre, int cantidad)
        {
            miPanel.anadirDatos(nombre, cantidad);
        }

    }
}
