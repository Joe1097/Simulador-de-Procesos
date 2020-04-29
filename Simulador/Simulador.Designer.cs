namespace Simulador
{
    partial class Simulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_memoria = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_procesos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_primer = new System.Windows.Forms.RadioButton();
            this.rb_mejor = new System.Windows.Forms.RadioButton();
            this.rb_peor = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_nseg = new System.Windows.Forms.Label();
            this.lbl_cap = new System.Windows.Forms.Label();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSimulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_est = new System.Windows.Forms.Label();
            this.pnl_espera = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_memoria
            // 
            this.pnl_memoria.BackColor = System.Drawing.Color.White;
            this.pnl_memoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_memoria.Location = new System.Drawing.Point(19, 62);
            this.pnl_memoria.Name = "pnl_memoria";
            this.pnl_memoria.Size = new System.Drawing.Size(100, 500);
            this.pnl_memoria.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar simulación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_procesos
            // 
            this.pnl_procesos.BackColor = System.Drawing.Color.White;
            this.pnl_procesos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_procesos.Location = new System.Drawing.Point(137, 62);
            this.pnl_procesos.Name = "pnl_procesos";
            this.pnl_procesos.Size = new System.Drawing.Size(100, 500);
            this.pnl_procesos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Memoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Procesos";
            // 
            // rb_primer
            // 
            this.rb_primer.AutoSize = true;
            this.rb_primer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_primer.Location = new System.Drawing.Point(41, 102);
            this.rb_primer.Name = "rb_primer";
            this.rb_primer.Size = new System.Drawing.Size(105, 20);
            this.rb_primer.TabIndex = 5;
            this.rb_primer.Text = "Primer Ajuste";
            this.rb_primer.UseVisualStyleBackColor = true;
            // 
            // rb_mejor
            // 
            this.rb_mejor.AutoSize = true;
            this.rb_mejor.Checked = true;
            this.rb_mejor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_mejor.Location = new System.Drawing.Point(41, 30);
            this.rb_mejor.Name = "rb_mejor";
            this.rb_mejor.Size = new System.Drawing.Size(100, 20);
            this.rb_mejor.TabIndex = 6;
            this.rb_mejor.TabStop = true;
            this.rb_mejor.Text = "Mejor Ajuste";
            this.rb_mejor.UseVisualStyleBackColor = true;
            // 
            // rb_peor
            // 
            this.rb_peor.AutoSize = true;
            this.rb_peor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_peor.Location = new System.Drawing.Point(41, 66);
            this.rb_peor.Name = "rb_peor";
            this.rb_peor.Size = new System.Drawing.Size(95, 20);
            this.rb_peor.TabIndex = 7;
            this.rb_peor.Text = "Peor Ajuste";
            this.rb_peor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de memoria: --";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_primer);
            this.groupBox1.Controls.Add(this.rb_mejor);
            this.groupBox1.Controls.Add(this.rb_peor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(281, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 144);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione tipo de asignación:";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_nseg
            // 
            this.lbl_nseg.AutoSize = true;
            this.lbl_nseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nseg.Location = new System.Drawing.Point(33, 28);
            this.lbl_nseg.Name = "lbl_nseg";
            this.lbl_nseg.Size = new System.Drawing.Size(115, 16);
            this.lbl_nseg.TabIndex = 12;
            this.lbl_nseg.Text = "Segmento actual: ";
            // 
            // lbl_cap
            // 
            this.lbl_cap.AutoSize = true;
            this.lbl_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cap.Location = new System.Drawing.Point(33, 59);
            this.lbl_cap.Name = "lbl_cap";
            this.lbl_cap.Size = new System.Drawing.Size(148, 16);
            this.lbl_cap.TabIndex = 13;
            this.lbl_cap.Text = "Número de segmentos:";
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pos.Location = new System.Drawing.Point(33, 94);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(112, 16);
            this.lbl_pos.TabIndex = 14;
            this.lbl_pos.Text = "Segmento actual:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSimulaciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // nuevaSimulaciónToolStripMenuItem
            // 
            this.nuevaSimulaciónToolStripMenuItem.Name = "nuevaSimulaciónToolStripMenuItem";
            this.nuevaSimulaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaSimulaciónToolStripMenuItem.Text = "Simulación";
            this.nuevaSimulaciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaSimulaciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "<-Estado de los procesos:";
            // 
            // lbl_est
            // 
            this.lbl_est.AutoSize = true;
            this.lbl_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_est.Location = new System.Drawing.Point(428, 364);
            this.lbl_est.Name = "lbl_est";
            this.lbl_est.Size = new System.Drawing.Size(18, 16);
            this.lbl_est.TabIndex = 18;
            this.lbl_est.Text = "--";
            // 
            // pnl_espera
            // 
            this.pnl_espera.BackColor = System.Drawing.Color.White;
            this.pnl_espera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_espera.Location = new System.Drawing.Point(441, 402);
            this.pnl_espera.Name = "pnl_espera";
            this.pnl_espera.Size = new System.Drawing.Size(100, 160);
            this.pnl_espera.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Proceso en espera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_pos);
            this.groupBox2.Controls.Add(this.lbl_nseg);
            this.groupBox2.Controls.Add(this.lbl_cap);
            this.groupBox2.Location = new System.Drawing.Point(281, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 129);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl_espera);
            this.Controls.Add(this.lbl_est);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_procesos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_memoria);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Simulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_memoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_procesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_primer;
        private System.Windows.Forms.RadioButton rb_mejor;
        private System.Windows.Forms.RadioButton rb_peor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_nseg;
        private System.Windows.Forms.Label lbl_cap;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSimulaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_est;
        private System.Windows.Forms.Panel pnl_espera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}