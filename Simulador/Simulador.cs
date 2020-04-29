using System;
using System.Collections;
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
    public partial class Simulador : Form
    {
        Thread th;
        List<Panel> segmentos = new List<Panel>();
        List<int> posiciones = new List<int>();
        List<int> tamaños = new List<int>();
        Panel current_p;
        int num=0;
        double min = 10000;
        int pdifmenor = 0;
        double max = 0;
        int pdifmayor = 0;
        Boolean ejecutando = false;
        int c = 0;
        int npros = 0;
        public static int nprosaux = 0;
        public static float maxporcmem=0;
        float maxporcmemaux = 0;
        public static double segs = 0;
        public static int tiemp =  Parámetros.t_pros; // Tiempo de procesamiento asignado a cada proceso
        public int tiems = Parámetros.t_sim; // Tiempo de simulación
        public int tamm = Parámetros.tam_mem; // Tamaño de la memoria;
        public int tammp = Parámetros.tam_max_pros;
        public Simulador()          
        {
            InitializeComponent();
            generarMemoria(tamm,tammp);
            generarProceso(tamm, tamaños.Max());
            lbl_cap.Text = "Segmentos de memoria: " + segmentos.Count;
            lbl_pos.Text = "Numero de posiciones: " +posiciones.Count;
        }

        private void generarProceso(int tam_memoria, int tam_max_pros)
        {
            Random r = new Random();
            int prop = tam_memoria / 500;
            int kbs = r.Next(15 * prop, tam_max_pros*prop + 1);
            var newPanel = new Panel();
            newPanel.Width = 100;
            newPanel.Height = kbs/prop;
            newPanel.BackColor = System.Drawing.Color.LightGreen;
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Top = 0;
            newPanel.Left=0;
            pnl_procesos.Controls.Add(newPanel);
            nprosaux++;
            newPanel.BringToFront();
            var newLabel = new Label();
            newLabel.Text = kbs + " Kb";
            newPanel.Controls.Add(newLabel);
            current_p = newPanel;
        }

        private void generarMemoria(int tam_memoria, int tam_max_pros)
        {
            Random r = new Random();
            Boolean lleno = false;
            int kbs;
            int bot = 0;
            float prop = tam_memoria / 500;
            while (lleno == false) {
                int kbsdprop=0;
                int botpprop = 0;
                kbs = r.Next((int)Math.Round(15 * prop), (int)Math.Round(tam_max_pros*prop) + 1);                
                if (bot + kbs < tam_memoria){                 
                    var newPanel = new Panel();
                    newPanel.Width = 100;
                    kbsdprop = (int)Math.Round(kbs / prop);
                    newPanel.Height = kbsdprop;
                    tamaños.Add(newPanel.Height);
                    newPanel.BackColor = System.Drawing.Color.LightBlue;
                    newPanel.BorderStyle = BorderStyle.FixedSingle;
                    newPanel.Left = 0;
                    botpprop = (int)Math.Round(bot / prop);
                    newPanel.Top = botpprop;
                    posiciones.Add(newPanel.Top);
                    bot += kbs;
                    pnl_memoria.Controls.Add(newPanel);
                    segmentos.Add(newPanel);
                    var newLabel = new Label();
                    newLabel.Text = kbs + " Kb";
                    newPanel.Controls.Add(newLabel);                    
                }
                else { 
                    var newPanel = new Panel();
                    newPanel.Width = 100;
                    newPanel.Height = (int)Math.Round((tam_memoria - bot) / prop);
                    tamaños.Add(newPanel.Height);
                    newPanel.BackColor = System.Drawing.Color.LightBlue;
                    newPanel.BorderStyle = BorderStyle.FixedSingle;
                    newPanel.Left = 0;
                    newPanel.Top = (int)Math.Round(bot / prop);
                    posiciones.Add(newPanel.Top);
                    bot += (int)Math.Round(newPanel.Height*prop);
                    pnl_memoria.Controls.Add(newPanel);
                    segmentos.Add(newPanel);
                    if (newPanel.Height > 15){
                        var newLabel = new Label();
                        newLabel.Text = (int)Math.Round(newPanel.Height * prop) + " Kb";
                        newPanel.Controls.Add(newLabel);
                        label5.Text = "Total de memoria: " + bot + " kb";
                        label4.Text = "";
                    }
                    else{
                        label5.Text = (int)Math.Round(newPanel.Height * prop) + " Kb";
                        label4.Text = "Total de memoria: " + bot + " kb";
                    }
                    lleno = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ejecutando == false)
            {
                current_p.Top = posiciones[num];
                current_p.BringToFront();
                if (rb_mejor.Checked) // mejor ajuste
                {
                    if (Math.Sqrt(segmentos[num].Height - current_p.Height) < min && segmentos[num].BackColor != System.Drawing.Color.LightGray) // si la diferencia de alturas del panel actual y el comparado es menor a la diferencia que está como más pequeña y que ademásno esté pintada
                    {
                        min = Math.Sqrt(segmentos[num].Height - current_p.Height);
                        pdifmenor = num;
                    }
                    else if (num + 1 == segmentos.Count)
                    {                      
                        if (segmentos[pdifmenor].BackColor == System.Drawing.Color.LightGray||current_p.Height > segmentos[pdifmenor].Height) // si el panel donde está la diferencia menor ya está pintado o si la altura del actual panel es mas grande del panel donde había encontrado mayor diferencia
                        {
                            Panel p = current_p;
                            p.Top=0;
                            p.Left = 0;
                            pnl_espera.Controls.Add(p);
                            pnl_procesos.Controls.Clear();                          
                            ejecutando = true;
                        }
                        else
                        {
                            current_p.Top = segmentos[pdifmenor].Top;
                            segmentos[pdifmenor].BackColor = System.Drawing.Color.LightGray;
                            generarProceso(tamm, tammp);
                            min = 10000;
                            pdifmenor = 0;
                        }                      
                    }
                }
                else if (rb_peor.Checked) // peor ajuste
                {
                    if (Math.Sqrt(segmentos[num].Height - current_p.Height) > max && segmentos[num].BackColor != System.Drawing.Color.LightGray)
                    {
                        max = Math.Sqrt(segmentos[num].Height - current_p.Height);
                        pdifmayor = num;
                    }
                    else if (num + 1 == segmentos.Count)
                    {
                        if (segmentos[pdifmayor].BackColor == System.Drawing.Color.LightGray|| current_p.Height > segmentos[pdifmayor].Height)
                        {
                            Panel p = current_p;
                            p.Top = 0;
                            p.Left = 0;
                            pnl_espera.Controls.Add(p);
                            pnl_procesos.Controls.Clear();
                            ejecutando = true;
                        }
                        else
                        {
                            current_p.Top = segmentos[pdifmayor].Top;
                            segmentos[pdifmayor].BackColor = System.Drawing.Color.LightGray;
                            generarProceso(tamm, tammp);
                            max = 0;
                            pdifmayor = 0;
                        }                
                    }
                }
                else if (rb_primer.Checked) // primer ajuste
                {
                    if (current_p.Height <= segmentos[num].Height && segmentos[num].BackColor != System.Drawing.Color.LightGray)
                    {
                        segmentos[num].BackColor = System.Drawing.Color.LightGray;
                        generarProceso(tamm, tammp);              
                    }
                    else if(num + 1 == segmentos.Count)
                    {
                        Panel p = current_p;
                        p.Top = 0;
                        p.Left = 0;
                        pnl_espera.Controls.Add(p);
                        pnl_procesos.Controls.Clear();
                        ejecutando = true;
                    }
                }

                if (num + 1 == segmentos.Count)
                {
                    num = 0;
                }
                else
                {
                    num++;
                }
                lbl_nseg.Text = "Segmento actual: " + num;
            }
            else{ // ejecutando procesos            
                if (c == tiemp)
                {
                    c = 0;                  
                    lbl_est.Text = "Esperando procesos...";
                    pnl_procesos.Controls.Add(current_p);
                    nprosaux--;
                    int totmemusada = 0;
                    for(int i = 0; i < segmentos.Count; i++)
                    {
                        if (segmentos[i].BackColor == System.Drawing.Color.LightGray)
                        {
                            totmemusada += segmentos[i].Height;
                            segmentos[i].BackColor = System.Drawing.Color.LightBlue;
                        }                       
                    }
                    maxporcmemaux = totmemusada / 500 * 100;
                    if (maxporcmemaux > maxporcmem)
                    {
                        maxporcmem = maxporcmemaux;
                    }
                    pnl_espera.Controls.Clear();
                    npros += nprosaux;
                    min = 10000;
                    pdifmenor = 0;
                    max = 0;
                    pdifmayor = 0;
                    ejecutando = false;
                }
                else
                {
                    if (c < 5)
                    {
                        lbl_est.Text = "Ejecutando";
                    }
                    else if (c >= 5 && c < 10)
                    {
                        lbl_est.Text = "Ejecutando.";
                    }
                    else if (c >= 10 && c < 15)
                    {
                        lbl_est.Text = "Ejecutando..";
                    }
                    else if (c >= 15 && c < 20) 
                    {
                        lbl_est.Text = "Ejecutando...";
                    }
                    c++;
                }
            }      
            segs+=0.25;
            if (segs == tiems)
            {
                estadisticas();
            }

        }

        private void estadisticas()
        {
            timer1.Enabled = false;
            Estadísticas est = new Estadísticas();
            est.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estadisticas();
        }

        private void nuevaSimulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirForm()
        {
            Application.Run(new Parámetros());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
