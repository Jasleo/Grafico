using graficarVectores.model;
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

namespace graficarVectores {
    public partial class Form1 : Form {
        Data data;
        int cantCoordenadas;

        // contadores de las figuras para las estadisticas
        int contClick = 1;
        List<Coordenada> listaClick;
        int contEqui = 0;
        int contEsca = 0;
        int contIsose = 0;
        int contCuad = 0;
        int contRect = 0;
        int contRombo = 0;
        int contRomboi = 0;
        int contTrapecio = 0;
        int contTrapezoide = 0;
        int x1 = 0, x2 = 0, x3 = 0, x4 = 0;
        int y1 = 0, y2 = 0, y3 = 0, y4 = 0;

        int ancho = 700;
        int alto = 525;


        public Form1() {
            InitializeComponent();
            init();
            data = new Data();
            listaClick = new List<Coordenada>();
        }

        private void graficarPunto(Graphics g, int x1, int y1) {
            g.DrawEllipse(Pens.Blue, coord_x(x1), coord_y(y1), 2, 2);
        }

        private void graficarPuntoPinchar(Graphics g, int x1, int y1) {
            g.DrawEllipse(Pens.Gold, coord_x(x1), coord_y(y1), 5, 5);
        }

        public void graficarVector(Graphics g, int x1, int y1, int x2, int y2) {
            g.DrawLine(Pens.Blue, coord_x(x1), coord_y(y1), coord_x(x2), coord_y(y2));
        }

        public void graficarVectorPinchar(Graphics g, int x1, int y1, int x2, int y2) {
            g.DrawLine(Pens.Gold, coord_x(x1), coord_y(y1), coord_x(x2), coord_y(y2));
        }

        public void graficarVectorTranslacion(Graphics g, int x1, int y1, int x2, int y2) {
            g.DrawLine(Pens.Red, coord_x(x1), coord_y(y1), coord_x(x2), coord_y(y2));
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnTranslacion_Click(object sender, EventArgs e) {
            Graphics g = pnlGrafico.CreateGraphics();

            String[] cortar;
            String vector = txtVectorTranslacion.Text;
            cortar = vector.Split(',');

            int nX1 = 0, nX2 = 0, nX3 = 0, nX4 = 0;
            int nY1 = 0, nY2 = 0, nY3 = 0, nY4 = 0;

            int x = int.Parse(cortar[0]);
            int y = int.Parse(cortar[1]);

            // a(punto original) + v(vectorTranslacion) = nuevo punto
            if (cantCoordenadas == 3) {
                nX1 = (x1 + (x));
                nY1 = (y1 + (y));
                lblMostrarNpA.Text = "(" + nX1 + "," + nY1 + ")";
                graficarPunto(g, nX1, nY1); // grafico el nuevo punto del vector

                nX2 = (x2 + (x));
                nY2 = (y2 + (y));
                lblMostrarNpB.Text = "(" + nX2 + "," + nY2 + ")";
                graficarPunto(g, nX2, nY2); // grafico el nuevo punto del vector

                nX3 = (x3 + (x));
                nY3 = (y3 + (y));
                lblMostrarNpC.Text = "(" + nX3 + "," + nY3 + ")";
                graficarPunto(g, nX3, nY3); // grafico el nuevo punto del vector

                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX1,/*y1*/ nY1,/*x2*/ nX2,/*y2*/ nY2);
                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX2,/*y1*/ nY2,/*x2*/ nX3,/*y2*/ nY3);
                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX1,/*y1*/ nY1,/*x2*/ nX3,/*y2*/ nY3);

                txtVectorTranslacion.Enabled = false;
                txtVectorTranslacion.Text = null;
                btnTranslacion.Enabled = false;

                btnIngresarOtroPunto.Enabled = true;
            } else if (cantCoordenadas == 4) {
                nX1 = (x1 + (x));
                nY1 = (y1 + (y));
                lblMostrarNpA.Text = "(" + nX1 + "," + nY1 + ")";
                graficarPunto(g, nX1, nY1); // grafico el nuevo punto del vector

                nX2 = (x2 + (x));
                nY2 = (y2 + (y));
                lblMostrarNpB.Text = "(" + nX2 + "," + nY2 + ")";
                graficarPunto(g, nX2, nY2); // grafico el nuevo punto del vector

                nX3 = (x3 + (x));
                nY3 = (y3 + (y));
                lblMostrarNpC.Text = "(" + nX3 + "," + nY3 + ")";
                graficarPunto(g, nX3, nY3); // grafico el nuevo punto del vector

                nX4 = (x4 + (x));
                nY4 = (y4 + (y));
                lblMostrarNpD.Text = "(" + nX4 + "," + nY4 + ")";
                graficarPunto(g, nX4, nY4); // grafico el nuevo punto del vector

                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX1,/*y1*/ nY1,/*x2*/ nX2,/*y2*/ nY2);
                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX2,/*y1*/ nY2,/*x2*/ nX3,/*y2*/ nY3);
                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX3,/*y1*/ nY3,/*x2*/ nX4,/*y2*/ nY4);
                graficarVectorTranslacion(pnlGrafico.CreateGraphics(),/*x*/ nX1,/*y1*/ nY1,/*x2*/ nX4,/*y2*/ nY4);

                txtVectorTranslacion.Enabled = false;
                txtVectorTranslacion.Text = null;
                btnTranslacion.Enabled = false;

                btnIngresarOtroPunto.Enabled = true;
            }
        }

        private int coord_x(int x) {
            int real_x = x + (ancho / 2);
            return real_x;
        }

        private void txtPuntoB_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuntoA_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuntoC_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuntoD_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtVectorTranslacion_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private int coord_x_pinchar(int x) {
            int real_x = -x - (ancho / 2);
            return (real_x);
        }

        private int coord_y_pinchar(int y) {
            int real_y = y + (alto / 2);

            return (real_y);
        }

        private void pnlGrafico_MouseDown(object sender, MouseEventArgs e) {
            if (cantCoordenadas != 0 && contClick <= cantCoordenadas) {
                int xp = e.X;
                xpinchar.Text = coord_x_pinchar(-xp).ToString();
                int yp = e.Y;
                ypinchar.Text = coord_y_pinchar(-yp).ToString();

                if (contClick == 1) {
                    txtPuntoA.Text = coord_x_pinchar(-xp) + "," + coord_y_pinchar(-yp);
                    graficarPuntoPinchar(pnlGrafico.CreateGraphics(), coord_x_pinchar(-xp), coord_y_pinchar(-yp));
                    txtPuntoA.Enabled = false;
                }
                if (contClick == 2) {
                    txtPuntoB.Text = coord_x_pinchar(-xp) + "," + coord_y_pinchar(-yp);
                    graficarPuntoPinchar(pnlGrafico.CreateGraphics(), coord_x_pinchar(-xp), coord_y_pinchar(-yp));
                    txtPuntoB.Enabled = false;
                }
                if (contClick == 3) {
                    txtPuntoC.Text = coord_x_pinchar(-xp) + "," + coord_y_pinchar(-yp);
                    graficarPuntoPinchar(pnlGrafico.CreateGraphics(), coord_x_pinchar(-xp), coord_y_pinchar(-yp));
                    txtPuntoC.Enabled = false;
                }
                if (contClick == 4) {
                    txtPuntoD.Text = coord_x_pinchar(-xp) + "," + coord_y_pinchar(-yp);
                    graficarPuntoPinchar(pnlGrafico.CreateGraphics(), coord_x_pinchar(-xp), coord_y_pinchar(-yp));
                    txtPuntoD.Enabled = false;
                }
                //graficarPuntoPinchar(pnlGrafico.CreateGraphics(), coord_x_pinchar(-xp), coord_y_pinchar(-yp));

                contClick = contClick + 1;
            }
            label31.Text = "Click " + contClick;
            label32.Text = "true";

        }

        private void btnIngresarOtroPunto_Click(object sender, EventArgs e) {
            Graphics g = pnlGrafico.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(Pens.Black, 0, alto / 2, ancho, alto / 2);
            g.DrawLine(Pens.Black, ancho / 2, 0, ancho / 2, alto);

            lblMostrarNombre.Text = null;
            lblMostrarArea.Text = null;
            lblMostrarPerimetro.Text = null;

            contClick = 1;

            lblMostrarNpA.Text = null;
            lblMostrarNpB.Text = null;
            lblMostrarNpC.Text = null;
            lblMostrarNpD.Text = null;

            btnContinuar.Enabled = true;
        }

        private int coord_y(int y) {
            int real_y = -y + (alto / 2);

            return (real_y);
        }

        private void actualizarEstadisticas(String nombreFigura) {
            if (nombreFigura.Equals("Triangulo Equilatero")) {
                contEqui = contEqui + 1;
                lblContEquila.Text = contEqui.ToString();
            }

            if (nombreFigura.Equals("Triangulo Escaleno")) {
                contEsca = contEsca + 1;
                lblContEsca.Text = contEsca.ToString();
            }

            if (nombreFigura.Equals("Triangulo Isoseles")) {
                contIsose = contIsose + 1;
                lblContIsose.Text = contIsose.ToString();
            }

            if (nombreFigura.Equals("Cuadrado")) {
                contCuad = contCuad + 1;
                lblContCuadra.Text = contCuad.ToString();
            }

            if (nombreFigura.Equals("Rectangulo")) {
                contRect = contRect + 1;
                lblContRect.Text = contRect.ToString();
            }

            if (nombreFigura.Equals("Rombo")) {
                contRombo = contRombo + 1;
                lblContRombo.Text = contRombo.ToString();
            }

            if (nombreFigura.Equals("Romboide")) {
                contRomboi = contRomboi + 1;
                lblContRomboi.Text = contRomboi.ToString();
            }

            if (nombreFigura.Equals("Trapecio")) {
                contTrapecio = contTrapecio + 1;
                lblContTrapecio.Text = contTrapecio.ToString();
            }

            if (nombreFigura.Equals("Trapezoide")) {
                contTrapezoide = contTrapezoide + 1;
                lblContTrapez.Text = contTrapezoide.ToString();
            }
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e) {
            Graphics g = pnlGrafico.CreateGraphics();

            g.DrawLine(Pens.Black, 0, alto / 2, ancho, alto / 2);
            g.DrawLine(Pens.Black, ancho / 2, 0, ancho / 2, alto);
        }

        private void btnGraficar_Click(object sender, EventArgs e) {
            Coordenada coor = new Coordenada();
            Punto punto = new Punto();
            List<Coordenada> listCoordenadas = new List<Coordenada>();
            String variable = label32.Text;

            String[] cortar;
            if (cantCoordenadas == 3) {
                // rescato el punto
                String pA = txtPuntoA.Text;
                // obtengo x e y 
                cortar = pA.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(1, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                String pB = txtPuntoB.Text;
                // obtengo x e y 
                cortar = pB.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(2, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                String pC = txtPuntoC.Text;
                // obtengo x e y 
                cortar = pC.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(3, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                foreach (Coordenada coordenada in listCoordenadas) {
                    if (variable.Equals("true")) {
                    }
                    else{
                        graficarPunto(pnlGrafico.CreateGraphics(), coordenada.X, coordenada.Y);
                    }
                }

                foreach (Coordenada coordenada in listCoordenadas) {
                    if (coordenada.Id == 1) {
                        x1 = coordenada.X;
                        y1 = coordenada.Y;
                    }
                    if (coordenada.Id == 2) {
                        x2 = coordenada.X;
                        y2 = coordenada.Y;
                    }
                    if (coordenada.Id == 3) {
                        x3 = coordenada.X;
                        y3 = coordenada.Y;
                    }
                }

                // une los puntos para generar la figura
                if (variable.Equals("true")) {
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x2,/*y2*/ y2);
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x2,/*y1*/ y2,/*x2*/ x3,/*y2*/ y3);
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x3,/*y2*/ y3);
                }
                else{
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x2,/*y2*/ y2);
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x2,/*y1*/ y2,/*x2*/ x3,/*y2*/ y3);
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x3,/*y2*/ y3);
                }

                //            
                punto = new Punto(x1, x2, y1, y2);
                float distAB = data.calcularDistancia(punto);

                punto = new Punto(x2, x3, y2, y3);
                float distBC = data.calcularDistancia(punto);

                punto = new Punto(x1, x3, y1, y3);
                float distAC = data.calcularDistancia(punto);

                String tipo = data.identificarTipoTriangulo(distAB, distBC, distAC);
                lblMostrarNombre.Text = tipo.ToString();
                float perimetro = data.getPerimetroTriangulo(distAB, distBC, distAC);
                lblMostrarPerimetro.Text = perimetro.ToString();
                float area = data.getAreaTringulo(tipo, perimetro, distAB, distBC, distAC);
                lblMostrarArea.Text = area.ToString();

                txtPuntoA.Text = null;
                txtPuntoB.Text = null;
                txtPuntoC.Text = null;

                txtPuntoA.Enabled = false;
                txtPuntoB.Enabled = false;
                txtPuntoC.Enabled = false;

                btnGraficar.Enabled = false;

                txtVectorTranslacion.Enabled = true;
                btnTranslacion.Enabled = true;

                actualizarEstadisticas(tipo);

                // si la cantidad de coordenadas es igual a 4
                // rescatamos los datos correspondientes    
            } else if (cantCoordenadas == 4) {
                // rescato el punto
                String pA = txtPuntoA.Text;
                // obtengo x e y 
                cortar = pA.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(1, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                // rescato el punto
                String pB = txtPuntoB.Text;
                // obtengo x e y 
                cortar = pB.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(2, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                // rescato el punto
                String pC = txtPuntoC.Text;
                // obtengo x e y 
                cortar = pC.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(3, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                // rescato el punto
                String pD = txtPuntoD.Text;
                // obtengo x e y 
                cortar = pD.Split(',');
                // construyo una nueva coordenada
                coor = new Coordenada(4, int.Parse(cortar[0]), int.Parse(cortar[1]));
                // agrego a la lista de coordenadas
                listCoordenadas.Add(coor);

                foreach (Coordenada coordenada in listCoordenadas) {
                    if (variable.Equals("true")) {
                    } else {
                        graficarPunto(pnlGrafico.CreateGraphics(), coordenada.X, coordenada.Y);
                    }
                }

                foreach (Coordenada coordenada in listCoordenadas) {
                    if (coordenada.Id == 1) {
                        x1 = coordenada.X;
                        y1 = coordenada.Y;
                    }
                    if (coordenada.Id == 2) {
                        x2 = coordenada.X;
                        y2 = coordenada.Y;
                    }
                    if (coordenada.Id == 3) {
                        x3 = coordenada.X;
                        y3 = coordenada.Y;
                    }
                    if (coordenada.Id == 4) {
                        x4 = coordenada.X;
                        y4 = coordenada.Y;
                    }
                }

                // une los puntos para generar la figura
                if (variable.Equals("true")) {
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x2,/*y2*/ y2);
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x2,/*y1*/ y2,/*x2*/ x3,/*y2*/ y3);
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x3,/*y1*/ y3,/*x2*/ x4,/*y2*/ y4);
                    graficarVectorPinchar(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x4,/*y2*/ y4);
                }
                else{
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x2,/*y2*/ y2);
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x2,/*y1*/ y2,/*x2*/ x3,/*y2*/ y3);
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x3,/*y1*/ y3,/*x2*/ x4,/*y2*/ y4);
                    graficarVector(pnlGrafico.CreateGraphics(),/*x*/ x1,/*y1*/ y1,/*x2*/ x4,/*y2*/ y4);
                }

                punto = new Punto(x1, x2, y1, y2);
                float distAB = data.calcularDistancia(punto);

                punto = new Punto(x2, x3, y2, y3);
                float distBC = data.calcularDistancia(punto);

                punto = new Punto(x3, x4, y3, y4);
                float distCD = data.calcularDistancia(punto);

                punto = new Punto(x1, x4, y1, y4);
                float distAD = data.calcularDistancia(punto);

                Coordenada coo1 = new Coordenada(x1, y1);
                Coordenada coo2 = new Coordenada(x2, y2);
                Coordenada coo3 = new Coordenada(x3, y3);
                Coordenada coo4 = new Coordenada(x4, y4);

                String tipo = data.identificarTipoPoligono(distAB, distBC, distCD, distAD, coo1, coo2, coo3, coo4);
                lblMostrarNombre.Text = tipo;

                float perimetro = data.getPerimetroPoligono(distAB, distBC, distCD, distAD);
                lblMostrarPerimetro.Text = perimetro + "Cm";

                float area = data.getAreaPoligono(tipo, distAB, distBC, distCD, distAD, coo1, coo2, coo3, coo4);
                lblMostrarArea.Text = area + " Cm2";

                txtPuntoA.Text = null;
                txtPuntoB.Text = null;
                txtPuntoC.Text = null;
                txtPuntoD.Text = null;

                txtPuntoA.Enabled = false;
                txtPuntoB.Enabled = false;
                txtPuntoC.Enabled = false;
                txtPuntoD.Enabled = false;

                btnGraficar.Enabled = false;

                txtVectorTranslacion.Enabled = true;
                btnTranslacion.Enabled = true;

                actualizarEstadisticas(tipo);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e) {
            if (rbTresPuntos.Checked) {
                cantCoordenadas = 3;
            } else if (rbCuatroPuntos.Checked) {
                cantCoordenadas = 4;
            }

            if (cantCoordenadas == 3) {
                txtPuntoA.Enabled = true;
                txtPuntoB.Enabled = true;
                txtPuntoC.Enabled = true;

                btnGraficar.Enabled = true;

                btnContinuar.Enabled = false;
            } else {
                txtPuntoA.Enabled = true;
                txtPuntoB.Enabled = true;
                txtPuntoC.Enabled = true;
                txtPuntoD.Enabled = true;

                btnGraficar.Enabled = true;
                btnContinuar.Enabled = false;
            }
        }

        private void init() {
            this.Location = new Point(100, 100);
            // desactivo algunas cosas        
            txtPuntoA.Enabled = false;
            txtPuntoB.Enabled = false;
            txtPuntoC.Enabled = false;
            txtPuntoD.Enabled = false;

            btnGraficar.Enabled = false;

            txtVectorTranslacion.Enabled = false;

            btnTranslacion.Enabled = false;
            btnIngresarOtroPunto.Enabled = false;

            label31.Text = "Click " + contClick;
        }



    }
}
