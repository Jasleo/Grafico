namespace graficarVectores {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.rbCuatroPuntos = new System.Windows.Forms.RadioButton();
            this.rbTresPuntos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.txtPuntoD = new System.Windows.Forms.TextBox();
            this.txtPuntoB = new System.Windows.Forms.TextBox();
            this.txtPuntoC = new System.Windows.Forms.TextBox();
            this.txtPuntoA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMostrarPerimetro = new System.Windows.Forms.Label();
            this.lblMostrarArea = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTranslacion = new System.Windows.Forms.Button();
            this.txtVectorTranslacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMostrarNpC = new System.Windows.Forms.Label();
            this.lblMostrarNpD = new System.Windows.Forms.Label();
            this.lblMostrarNpA = new System.Windows.Forms.Label();
            this.lblMostrarNpB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblContTrapez = new System.Windows.Forms.Label();
            this.lblContTrapecio = new System.Windows.Forms.Label();
            this.lblContRomboi = new System.Windows.Forms.Label();
            this.lblContRombo = new System.Windows.Forms.Label();
            this.lblContRect = new System.Windows.Forms.Label();
            this.lblContCuadra = new System.Windows.Forms.Label();
            this.lblContEsca = new System.Windows.Forms.Label();
            this.lblContIsose = new System.Windows.Forms.Label();
            this.lblContEquila = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnIngresarOtroPunto = new System.Windows.Forms.Button();
            this.xpinchar = new System.Windows.Forms.Label();
            this.ypinchar = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrafico.Location = new System.Drawing.Point(13, 13);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(700, 525);
            this.pnlGrafico.TabIndex = 0;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            this.pnlGrafico.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGrafico_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Controls.Add(this.rbCuatroPuntos);
            this.groupBox1.Controls.Add(this.rbTresPuntos);
            this.groupBox1.Location = new System.Drawing.Point(731, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cant Puntos";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(60, 66);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // rbCuatroPuntos
            // 
            this.rbCuatroPuntos.AutoSize = true;
            this.rbCuatroPuntos.Location = new System.Drawing.Point(102, 33);
            this.rbCuatroPuntos.Name = "rbCuatroPuntos";
            this.rbCuatroPuntos.Size = new System.Drawing.Size(92, 17);
            this.rbCuatroPuntos.TabIndex = 1;
            this.rbCuatroPuntos.TabStop = true;
            this.rbCuatroPuntos.Text = "Cuatro Puntos";
            this.rbCuatroPuntos.UseVisualStyleBackColor = true;
            // 
            // rbTresPuntos
            // 
            this.rbTresPuntos.AutoSize = true;
            this.rbTresPuntos.Checked = true;
            this.rbTresPuntos.Location = new System.Drawing.Point(17, 33);
            this.rbTresPuntos.Name = "rbTresPuntos";
            this.rbTresPuntos.Size = new System.Drawing.Size(82, 17);
            this.rbTresPuntos.TabIndex = 0;
            this.rbTresPuntos.TabStop = true;
            this.rbTresPuntos.Text = "Tres Puntos";
            this.rbTresPuntos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGraficar);
            this.groupBox2.Controls.Add(this.txtPuntoD);
            this.groupBox2.Controls.Add(this.txtPuntoB);
            this.groupBox2.Controls.Add(this.txtPuntoC);
            this.groupBox2.Controls.Add(this.txtPuntoA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(731, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puntos";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(60, 92);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // txtPuntoD
            // 
            this.txtPuntoD.Location = new System.Drawing.Point(119, 56);
            this.txtPuntoD.Name = "txtPuntoD";
            this.txtPuntoD.Size = new System.Drawing.Size(53, 20);
            this.txtPuntoD.TabIndex = 4;
            this.txtPuntoD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoD_KeyPress);
            // 
            // txtPuntoB
            // 
            this.txtPuntoB.Location = new System.Drawing.Point(119, 27);
            this.txtPuntoB.Name = "txtPuntoB";
            this.txtPuntoB.Size = new System.Drawing.Size(53, 20);
            this.txtPuntoB.TabIndex = 4;
            this.txtPuntoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoB_KeyPress);
            // 
            // txtPuntoC
            // 
            this.txtPuntoC.Location = new System.Drawing.Point(31, 56);
            this.txtPuntoC.Name = "txtPuntoC";
            this.txtPuntoC.Size = new System.Drawing.Size(53, 20);
            this.txtPuntoC.TabIndex = 4;
            this.txtPuntoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoC_KeyPress);
            // 
            // txtPuntoA
            // 
            this.txtPuntoA.Location = new System.Drawing.Point(31, 27);
            this.txtPuntoA.Name = "txtPuntoA";
            this.txtPuntoA.Size = new System.Drawing.Size(53, 20);
            this.txtPuntoA.TabIndex = 4;
            this.txtPuntoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblMostrarPerimetro);
            this.groupBox3.Controls.Add(this.lblMostrarArea);
            this.groupBox3.Controls.Add(this.lblMostrarNombre);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(731, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 181);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Figura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Perimetro :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Area : ";
            // 
            // lblMostrarPerimetro
            // 
            this.lblMostrarPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarPerimetro.Location = new System.Drawing.Point(90, 112);
            this.lblMostrarPerimetro.Name = "lblMostrarPerimetro";
            this.lblMostrarPerimetro.Size = new System.Drawing.Size(92, 20);
            this.lblMostrarPerimetro.TabIndex = 0;
            // 
            // lblMostrarArea
            // 
            this.lblMostrarArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarArea.Location = new System.Drawing.Point(90, 80);
            this.lblMostrarArea.Name = "lblMostrarArea";
            this.lblMostrarArea.Size = new System.Drawing.Size(92, 20);
            this.lblMostrarArea.TabIndex = 0;
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarNombre.Location = new System.Drawing.Point(90, 30);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(92, 34);
            this.lblMostrarNombre.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTranslacion);
            this.groupBox4.Controls.Add(this.txtVectorTranslacion);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblMostrarNpC);
            this.groupBox4.Controls.Add(this.lblMostrarNpD);
            this.groupBox4.Controls.Add(this.lblMostrarNpA);
            this.groupBox4.Controls.Add(this.lblMostrarNpB);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(966, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector Traslacion";
            // 
            // btnTranslacion
            // 
            this.btnTranslacion.Location = new System.Drawing.Point(54, 157);
            this.btnTranslacion.Name = "btnTranslacion";
            this.btnTranslacion.Size = new System.Drawing.Size(98, 23);
            this.btnTranslacion.TabIndex = 5;
            this.btnTranslacion.Text = "Ingresar Vector";
            this.btnTranslacion.UseVisualStyleBackColor = true;
            this.btnTranslacion.Click += new System.EventHandler(this.btnTranslacion_Click);
            // 
            // txtVectorTranslacion
            // 
            this.txtVectorTranslacion.Location = new System.Drawing.Point(77, 33);
            this.txtVectorTranslacion.Name = "txtVectorTranslacion";
            this.txtVectorTranslacion.Size = new System.Drawing.Size(100, 20);
            this.txtVectorTranslacion.TabIndex = 4;
            this.txtVectorTranslacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVectorTranslacion_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "D";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vector :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "A";
            // 
            // lblMostrarNpC
            // 
            this.lblMostrarNpC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarNpC.Location = new System.Drawing.Point(43, 107);
            this.lblMostrarNpC.Name = "lblMostrarNpC";
            this.lblMostrarNpC.Size = new System.Drawing.Size(49, 20);
            this.lblMostrarNpC.TabIndex = 0;
            // 
            // lblMostrarNpD
            // 
            this.lblMostrarNpD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarNpD.Location = new System.Drawing.Point(132, 107);
            this.lblMostrarNpD.Name = "lblMostrarNpD";
            this.lblMostrarNpD.Size = new System.Drawing.Size(49, 20);
            this.lblMostrarNpD.TabIndex = 0;
            // 
            // lblMostrarNpA
            // 
            this.lblMostrarNpA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarNpA.Location = new System.Drawing.Point(43, 76);
            this.lblMostrarNpA.Name = "lblMostrarNpA";
            this.lblMostrarNpA.Size = new System.Drawing.Size(49, 20);
            this.lblMostrarNpA.TabIndex = 0;
            // 
            // lblMostrarNpB
            // 
            this.lblMostrarNpB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarNpB.Location = new System.Drawing.Point(132, 76);
            this.lblMostrarNpB.Name = "lblMostrarNpB";
            this.lblMostrarNpB.Size = new System.Drawing.Size(49, 20);
            this.lblMostrarNpB.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "C";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.lblContTrapez);
            this.groupBox5.Controls.Add(this.lblContTrapecio);
            this.groupBox5.Controls.Add(this.lblContRomboi);
            this.groupBox5.Controls.Add(this.lblContRombo);
            this.groupBox5.Controls.Add(this.lblContRect);
            this.groupBox5.Controls.Add(this.lblContCuadra);
            this.groupBox5.Controls.Add(this.lblContEsca);
            this.groupBox5.Controls.Add(this.lblContIsose);
            this.groupBox5.Controls.Add(this.lblContEquila);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(966, 238);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 251);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estadisticas";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 216);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Trapezoide";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Rombo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "T. Escaleno";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Romboide";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Trapecio";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(96, 219);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(10, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = ":";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(96, 193);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(10, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = ":";
            // 
            // lblContTrapez
            // 
            this.lblContTrapez.AutoSize = true;
            this.lblContTrapez.Location = new System.Drawing.Point(139, 219);
            this.lblContTrapez.Name = "lblContTrapez";
            this.lblContTrapez.Size = new System.Drawing.Size(13, 13);
            this.lblContTrapez.TabIndex = 1;
            this.lblContTrapez.Text = "0";
            // 
            // lblContTrapecio
            // 
            this.lblContTrapecio.AutoSize = true;
            this.lblContTrapecio.Location = new System.Drawing.Point(139, 193);
            this.lblContTrapecio.Name = "lblContTrapecio";
            this.lblContTrapecio.Size = new System.Drawing.Size(13, 13);
            this.lblContTrapecio.TabIndex = 1;
            this.lblContTrapecio.Text = "0";
            // 
            // lblContRomboi
            // 
            this.lblContRomboi.AutoSize = true;
            this.lblContRomboi.Location = new System.Drawing.Point(139, 168);
            this.lblContRomboi.Name = "lblContRomboi";
            this.lblContRomboi.Size = new System.Drawing.Size(13, 13);
            this.lblContRomboi.TabIndex = 1;
            this.lblContRomboi.Text = "0";
            // 
            // lblContRombo
            // 
            this.lblContRombo.AutoSize = true;
            this.lblContRombo.Location = new System.Drawing.Point(139, 145);
            this.lblContRombo.Name = "lblContRombo";
            this.lblContRombo.Size = new System.Drawing.Size(13, 13);
            this.lblContRombo.TabIndex = 1;
            this.lblContRombo.Text = "0";
            // 
            // lblContRect
            // 
            this.lblContRect.AutoSize = true;
            this.lblContRect.Location = new System.Drawing.Point(139, 122);
            this.lblContRect.Name = "lblContRect";
            this.lblContRect.Size = new System.Drawing.Size(13, 13);
            this.lblContRect.TabIndex = 1;
            this.lblContRect.Text = "0";
            // 
            // lblContCuadra
            // 
            this.lblContCuadra.AutoSize = true;
            this.lblContCuadra.Location = new System.Drawing.Point(139, 100);
            this.lblContCuadra.Name = "lblContCuadra";
            this.lblContCuadra.Size = new System.Drawing.Size(13, 13);
            this.lblContCuadra.TabIndex = 1;
            this.lblContCuadra.Text = "0";
            // 
            // lblContEsca
            // 
            this.lblContEsca.AutoSize = true;
            this.lblContEsca.Location = new System.Drawing.Point(139, 78);
            this.lblContEsca.Name = "lblContEsca";
            this.lblContEsca.Size = new System.Drawing.Size(13, 13);
            this.lblContEsca.TabIndex = 1;
            this.lblContEsca.Text = "0";
            // 
            // lblContIsose
            // 
            this.lblContIsose.AutoSize = true;
            this.lblContIsose.Location = new System.Drawing.Point(139, 56);
            this.lblContIsose.Name = "lblContIsose";
            this.lblContIsose.Size = new System.Drawing.Size(13, 13);
            this.lblContIsose.TabIndex = 1;
            this.lblContIsose.Text = "0";
            // 
            // lblContEquila
            // 
            this.lblContEquila.AutoSize = true;
            this.lblContEquila.Location = new System.Drawing.Point(139, 34);
            this.lblContEquila.Name = "lblContEquila";
            this.lblContEquila.Size = new System.Drawing.Size(13, 13);
            this.lblContEquila.TabIndex = 1;
            this.lblContEquila.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(96, 168);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = ":";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(96, 145);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(10, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = ":";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(96, 122);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(10, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(96, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = ":";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(96, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(10, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(96, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(96, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Cuadrado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Rectangulo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "T. Equilatero ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "T. Isoseles";
            // 
            // btnIngresarOtroPunto
            // 
            this.btnIngresarOtroPunto.Location = new System.Drawing.Point(1009, 495);
            this.btnIngresarOtroPunto.Name = "btnIngresarOtroPunto";
            this.btnIngresarOtroPunto.Size = new System.Drawing.Size(126, 23);
            this.btnIngresarOtroPunto.TabIndex = 6;
            this.btnIngresarOtroPunto.Text = "Ingresar Otro Punto";
            this.btnIngresarOtroPunto.UseVisualStyleBackColor = true;
            this.btnIngresarOtroPunto.Click += new System.EventHandler(this.btnIngresarOtroPunto_Click);
            // 
            // xpinchar
            // 
            this.xpinchar.AutoSize = true;
            this.xpinchar.Location = new System.Drawing.Point(738, 505);
            this.xpinchar.Name = "xpinchar";
            this.xpinchar.Size = new System.Drawing.Size(53, 13);
            this.xpinchar.TabIndex = 0;
            this.xpinchar.Text = "Nombre : ";
            // 
            // ypinchar
            // 
            this.ypinchar.AutoSize = true;
            this.ypinchar.Location = new System.Drawing.Point(818, 505);
            this.ypinchar.Name = "ypinchar";
            this.ypinchar.Size = new System.Drawing.Size(38, 13);
            this.ypinchar.TabIndex = 0;
            this.ypinchar.Text = "Area : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(887, 505);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Area : ";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(846, 308);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 0);
            this.label32.TabIndex = 0;
            this.label32.Text = "Area : ";
            this.label32.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 551);
            this.Controls.Add(this.btnIngresarOtroPunto);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.ypinchar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.xpinchar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlGrafico);
            this.Name = "Form1";
            this.Text = "El Graficador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.RadioButton rbCuatroPuntos;
        private System.Windows.Forms.RadioButton rbTresPuntos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPuntoA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.TextBox txtPuntoD;
        private System.Windows.Forms.TextBox txtPuntoB;
        private System.Windows.Forms.TextBox txtPuntoC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMostrarPerimetro;
        private System.Windows.Forms.Label lblMostrarArea;
        private System.Windows.Forms.Label lblMostrarNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVectorTranslacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMostrarNpC;
        private System.Windows.Forms.Label lblMostrarNpD;
        private System.Windows.Forms.Label lblMostrarNpA;
        private System.Windows.Forms.Label lblMostrarNpB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTranslacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblContTrapez;
        private System.Windows.Forms.Label lblContTrapecio;
        private System.Windows.Forms.Label lblContRomboi;
        private System.Windows.Forms.Label lblContRombo;
        private System.Windows.Forms.Label lblContRect;
        private System.Windows.Forms.Label lblContCuadra;
        private System.Windows.Forms.Label lblContEsca;
        private System.Windows.Forms.Label lblContIsose;
        private System.Windows.Forms.Label lblContEquila;
        private System.Windows.Forms.Button btnIngresarOtroPunto;
        private System.Windows.Forms.Label xpinchar;
        private System.Windows.Forms.Label ypinchar;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
    }
}

