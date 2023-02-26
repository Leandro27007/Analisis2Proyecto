using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis2Proyecto
{
    public partial class frmInicioUIBienvenida : Form
    {
        public frmInicioUIBienvenida()
        {
            InitializeComponent();
        }

        private void btn_bienvenida_Click(object sender, EventArgs e)
        {

            frmListaDeModelos formulario = new frmListaDeModelos();
            frmCaja formulario2 = new frmCaja();
            frmCajaHerramientas formulario3 = new frmCajaHerramientas();

            // Mostrar el formulario
            formulario.Show();
            formulario2.Show();
            formulario3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
