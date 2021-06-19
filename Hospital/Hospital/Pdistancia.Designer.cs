
namespace Hospital
{
    partial class Pdistancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pdistancia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lsup = new System.Windows.Forms.TextBox();
            this.Linf = new System.Windows.Forms.TextBox();
            this.Lsuperior = new System.Windows.Forms.Label();
            this.limInf = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbn2 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.tbXo2 = new System.Windows.Forms.TextBox();
            this.tbC2 = new System.Windows.Forms.TextBox();
            this.tbA2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NSign = new System.Windows.Forms.Label();
            this.StartPF = new System.Windows.Forms.Button();
            this.CantNum = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.ContenedorP = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimIn = new System.Windows.Forms.Label();
            this.LimSup = new System.Windows.Forms.Label();
            this.AlphM = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.R3 = new System.Windows.Forms.Label();
            this.R2 = new System.Windows.Forms.Label();
            this.R1 = new System.Windows.Forms.Label();
            this.DistribuciónES = new System.Windows.Forms.Label();
            this.ValorTablas = new System.Windows.Forms.Label();
            this.ResultadoFrecuencia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ContenedorP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Lsup);
            this.panel1.Controls.Add(this.Linf);
            this.panel1.Controls.Add(this.Lsuperior);
            this.panel1.Controls.Add(this.limInf);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.nn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbn2);
            this.panel1.Controls.Add(this.tbM2);
            this.panel1.Controls.Add(this.tbXo2);
            this.panel1.Controls.Add(this.tbC2);
            this.panel1.Controls.Add(this.tbA2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NSign);
            this.panel1.Controls.Add(this.StartPF);
            this.panel1.Controls.Add(this.CantNum);
            this.panel1.Location = new System.Drawing.Point(11, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 375);
            this.panel1.TabIndex = 5;
            // 
            // Lsup
            // 
            this.Lsup.Location = new System.Drawing.Point(128, 190);
            this.Lsup.Name = "Lsup";
            this.Lsup.Size = new System.Drawing.Size(106, 20);
            this.Lsup.TabIndex = 28;
            this.Lsup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lsup_KeyPress);
            // 
            // Linf
            // 
            this.Linf.Location = new System.Drawing.Point(128, 151);
            this.Linf.Name = "Linf";
            this.Linf.Size = new System.Drawing.Size(106, 20);
            this.Linf.TabIndex = 27;
            this.Linf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Linf_KeyPress);
            // 
            // Lsuperior
            // 
            this.Lsuperior.AutoSize = true;
            this.Lsuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsuperior.Location = new System.Drawing.Point(18, 197);
            this.Lsuperior.Name = "Lsuperior";
            this.Lsuperior.Size = new System.Drawing.Size(92, 15);
            this.Lsuperior.TabIndex = 26;
            this.Lsuperior.Text = "Límite superior:";
            // 
            // limInf
            // 
            this.limInf.AutoSize = true;
            this.limInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limInf.Location = new System.Drawing.Point(18, 151);
            this.limInf.Name = "limInf";
            this.limInf.Size = new System.Drawing.Size(85, 15);
            this.limInf.TabIndex = 25;
            this.limInf.Text = "Límite inferior:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // nn
            // 
            this.nn.AutoSize = true;
            this.nn.Location = new System.Drawing.Point(189, 68);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(0, 13);
            this.nn.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "n:";
            this.label5.Visible = false;
            // 
            // tbn2
            // 
            this.tbn2.Location = new System.Drawing.Point(76, 252);
            this.tbn2.Name = "tbn2";
            this.tbn2.Size = new System.Drawing.Size(108, 20);
            this.tbn2.TabIndex = 19;
            this.tbn2.Visible = false;
            // 
            // tbM2
            // 
            this.tbM2.Location = new System.Drawing.Point(76, 226);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(108, 20);
            this.tbM2.TabIndex = 18;
            this.tbM2.Visible = false;
            // 
            // tbXo2
            // 
            this.tbXo2.Location = new System.Drawing.Point(76, 200);
            this.tbXo2.Name = "tbXo2";
            this.tbXo2.Size = new System.Drawing.Size(108, 20);
            this.tbXo2.TabIndex = 17;
            this.tbXo2.Visible = false;
            // 
            // tbC2
            // 
            this.tbC2.Location = new System.Drawing.Point(76, 174);
            this.tbC2.Name = "tbC2";
            this.tbC2.Size = new System.Drawing.Size(108, 20);
            this.tbC2.TabIndex = 16;
            this.tbC2.Visible = false;
            // 
            // tbA2
            // 
            this.tbA2.Location = new System.Drawing.Point(76, 148);
            this.tbA2.Name = "tbA2";
            this.tbA2.Size = new System.Drawing.Size(108, 20);
            this.tbA2.TabIndex = 15;
            this.tbA2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "M:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Xo:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "c:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "a:";
            this.label1.Visible = false;
            // 
            // NSign
            // 
            this.NSign.AutoSize = true;
            this.NSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSign.Location = new System.Drawing.Point(3, 108);
            this.NSign.Name = "NSign";
            this.NSign.Size = new System.Drawing.Size(125, 15);
            this.NSign.TabIndex = 5;
            this.NSign.Text = "Nivel de significancia:";
            // 
            // StartPF
            // 
            this.StartPF.BackColor = System.Drawing.Color.White;
            this.StartPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartPF.Location = new System.Drawing.Point(65, 325);
            this.StartPF.Name = "StartPF";
            this.StartPF.Size = new System.Drawing.Size(100, 36);
            this.StartPF.TabIndex = 4;
            this.StartPF.Text = "Comenzar prueba";
            this.StartPF.UseVisualStyleBackColor = false;
            this.StartPF.Click += new System.EventHandler(this.StartPF_Click);
            // 
            // CantNum
            // 
            this.CantNum.AutoSize = true;
            this.CantNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantNum.Location = new System.Drawing.Point(3, 68);
            this.CantNum.Name = "CantNum";
            this.CantNum.Size = new System.Drawing.Size(211, 15);
            this.CantNum.TabIndex = 1;
            this.CantNum.Text = "Cantidad Números pseudoaleatorios:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.ps});
            this.dataGridView3.Location = new System.Drawing.Point(535, 346);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(203, 124);
            this.dataGridView3.TabIndex = 23;
            this.dataGridView3.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            // 
            // ps
            // 
            this.ps.HeaderText = "ps";
            this.ps.Name = "ps";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(378, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(228, 26);
            this.title.TabIndex = 10;
            this.title.Text = "Prueba de distancia";
            // 
            // ContenedorP
            // 
            this.ContenedorP.BackColor = System.Drawing.Color.Transparent;
            this.ContenedorP.Controls.Add(this.dataGridView1);
            this.ContenedorP.Controls.Add(this.LimIn);
            this.ContenedorP.Controls.Add(this.LimSup);
            this.ContenedorP.Controls.Add(this.AlphM);
            this.ContenedorP.Controls.Add(this.pictureBox1);
            this.ContenedorP.Controls.Add(this.R3);
            this.ContenedorP.Controls.Add(this.R2);
            this.ContenedorP.Controls.Add(this.R1);
            this.ContenedorP.Controls.Add(this.DistribuciónES);
            this.ContenedorP.Controls.Add(this.ValorTablas);
            this.ContenedorP.Controls.Add(this.ResultadoFrecuencia);
            this.ContenedorP.Location = new System.Drawing.Point(267, 54);
            this.ContenedorP.Name = "ContenedorP";
            this.ContenedorP.Size = new System.Drawing.Size(628, 375);
            this.ContenedorP.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Distancia,
            this.FrecuenciaObservada,
            this.Pdist,
            this.FrecuenciaEsperada});
            this.dataGridView1.Location = new System.Drawing.Point(79, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // Distancia
            // 
            this.Distancia.HeaderText = "Distancia";
            this.Distancia.Name = "Distancia";
            // 
            // FrecuenciaObservada
            // 
            this.FrecuenciaObservada.HeaderText = "FO";
            this.FrecuenciaObservada.Name = "FrecuenciaObservada";
            // 
            // Pdist
            // 
            this.Pdist.HeaderText = "P(dist)";
            this.Pdist.Name = "Pdist";
            // 
            // FrecuenciaEsperada
            // 
            this.FrecuenciaEsperada.HeaderText = "FE";
            this.FrecuenciaEsperada.Name = "FrecuenciaEsperada";
            // 
            // LimIn
            // 
            this.LimIn.AutoSize = true;
            this.LimIn.BackColor = System.Drawing.Color.White;
            this.LimIn.Location = new System.Drawing.Point(35, 84);
            this.LimIn.Name = "LimIn";
            this.LimIn.Size = new System.Drawing.Size(18, 13);
            this.LimIn.TabIndex = 10;
            this.LimIn.Text = "-/-";
            // 
            // LimSup
            // 
            this.LimSup.AutoSize = true;
            this.LimSup.BackColor = System.Drawing.Color.White;
            this.LimSup.Location = new System.Drawing.Point(265, 84);
            this.LimSup.Name = "LimSup";
            this.LimSup.Size = new System.Drawing.Size(18, 13);
            this.LimSup.TabIndex = 9;
            this.LimSup.Text = "-/-";
            // 
            // AlphM
            // 
            this.AlphM.AutoSize = true;
            this.AlphM.BackColor = System.Drawing.Color.Transparent;
            this.AlphM.Location = new System.Drawing.Point(156, 139);
            this.AlphM.Name = "AlphM";
            this.AlphM.Size = new System.Drawing.Size(18, 13);
            this.AlphM.TabIndex = 8;
            this.AlphM.Text = "-/-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // R3
            // 
            this.R3.AutoSize = true;
            this.R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3.Location = new System.Drawing.Point(321, 105);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(18, 15);
            this.R3.TabIndex = 6;
            this.R3.Text = "-/-";
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(506, 12);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(18, 13);
            this.R2.TabIndex = 5;
            this.R2.Text = "-/-";
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(432, 36);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(18, 13);
            this.R1.TabIndex = 4;
            this.R1.Text = "-/-";
            // 
            // DistribuciónES
            // 
            this.DistribuciónES.AutoSize = true;
            this.DistribuciónES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistribuciónES.Location = new System.Drawing.Point(321, 72);
            this.DistribuciónES.Name = "DistribuciónES";
            this.DistribuciónES.Size = new System.Drawing.Size(306, 15);
            this.DistribuciónES.TabIndex = 3;
            this.DistribuciónES.Text = "A partir de los resultados se concluye que los números:";
            // 
            // ValorTablas
            // 
            this.ValorTablas.AutoSize = true;
            this.ValorTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTablas.Location = new System.Drawing.Point(321, 36);
            this.ValorTablas.Name = "ValorTablas";
            this.ValorTablas.Size = new System.Drawing.Size(119, 15);
            this.ValorTablas.TabIndex = 2;
            this.ValorTablas.Text = "El valor de tablas es:";
            // 
            // ResultadoFrecuencia
            // 
            this.ResultadoFrecuencia.AutoSize = true;
            this.ResultadoFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoFrecuencia.Location = new System.Drawing.Point(321, 12);
            this.ResultadoFrecuencia.Name = "ResultadoFrecuencia";
            this.ResultadoFrecuencia.Size = new System.Drawing.Size(204, 15);
            this.ResultadoFrecuencia.TabIndex = 1;
            this.ResultadoFrecuencia.Text = "El valor calculado de la distancia es:";
            // 
            // Pdistancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContenedorP);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pdistancia";
            this.Text = "Prueba Distancia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ContenedorP.ResumeLayout(false);
            this.ContenedorP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Lsup;
        private System.Windows.Forms.TextBox Linf;
        private System.Windows.Forms.Label Lsuperior;
        private System.Windows.Forms.Label limInf;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps;
        public System.Windows.Forms.Label nn;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbn2;
        public System.Windows.Forms.TextBox tbM2;
        public System.Windows.Forms.TextBox tbXo2;
        public System.Windows.Forms.TextBox tbC2;
        public System.Windows.Forms.TextBox tbA2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label NSign;
        private System.Windows.Forms.Button StartPF;
        private System.Windows.Forms.Label CantNum;
        private System.Windows.Forms.Panel ContenedorP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdist;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.Label LimIn;
        private System.Windows.Forms.Label LimSup;
        private System.Windows.Forms.Label AlphM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label R3;
        private System.Windows.Forms.Label R2;
        private System.Windows.Forms.Label R1;
        private System.Windows.Forms.Label DistribuciónES;
        private System.Windows.Forms.Label ValorTablas;
        private System.Windows.Forms.Label ResultadoFrecuencia;
    }
}