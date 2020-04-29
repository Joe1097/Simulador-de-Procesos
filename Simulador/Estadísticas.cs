using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador
{
    public partial class Estadísticas : Form
    {
        public Estadísticas()
        {
            InitializeComponent();
            label5.Text = Simulador.segs+" Segundos";
            label8.Text = Simulador.tiemp + " Segundos";
            label6.Text = Simulador.nprosaux + " Procesos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
