using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simulador
{
    public partial class Parámetros : Form
    {
        public static int t_sim;
        public static int t_pros;
        public static int tam_mem;
        public static int tam_max_pros;
        Thread th;

        public Parámetros()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_sim = Int32.Parse(textBox1.Text);
            t_pros = Int32.Parse(textBox2.Text);
            tam_mem = Int32.Parse(comboBox2.Text);
            tam_max_pros = Int32.Parse(textBox4.Text);
            if (tam_mem / tam_max_pros < 35)
            {
                this.Close();
                th = new Thread(abrirForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("El tamaño máximo por proceso es muy pequeño para visualizarse correctamente", "Cuidado",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void abrirForm(Object obj)
        {
            Application.Run(new Simulador());
        }
    }
}
