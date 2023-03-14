using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbero
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agrBarbero_Click(object sender, EventArgs e)
        {
            servicio.AgregarBarbero(true);
        }

        private void agreCliente_Click(object sender, EventArgs e)
        {
        }

        private void borrarCliente_Click(object sender, EventArgs e)
        {
        }
    }
}
