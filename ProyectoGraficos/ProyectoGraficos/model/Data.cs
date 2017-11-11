using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGraficos.model {

    public class Data {

        public float calcularDistancia(Punto p) {
            float distancia = 0;

            // rescato los puntos
            double x1 = p.X1;
            double y1 = p.Y1;
            double x2 = p.X2;
            double y2 = p.Y2;

            // hago la parte de restar el x2 con x1 
            double res1 = x2 - x1;
            // elevo al cuadrado
            res1 = Math.Pow(res1, 2);
            // hago la parte de restar el y2 con y1
            double res2 = y2 - y1;
            // elevo al cuadrado
            res2 = Math.Pow(res2, 2);
            // sumo los resultados anteriores
            double suma = res1 + res2;
            // si la suma es negativa la multiplico por -1 para que no arroje error
            if (suma < 0) {
                suma = suma * -1;
            }
            // calculo la raiz cuandrada
            distancia = (float)Math.Sqrt(suma);

            //redondeo a 2 decimales
            distancia = (float)redondear(distancia);

            // retorno la distancia
            return distancia;
        }

        // metodo que rendondea a 2 decimales
        public double redondear(double numero) {
            return Math.Round(numero, 2);
        }


        /*Metodo para identificar el tipo de triangulo*/
        public String identificarTipoTriangulo(float lado1, float lado2, float lado3) {
            String tipo = "";

            if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1) {
                return "Triangulo Equilatero";
            }

            if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1) {
                return "Triangulo Escaleno";
            }

            if (lado1 == lado2 && lado2 == lado3 || lado1 == lado3 && lado2 == lado3) {
                return "Triangulo Isoseles";
            }

            return tipo;
        }

        // metodo que entrega el real valor de x
        public int coord_x_real(int x, int ancho) {
            int real_x = x + ancho / 2;

            return (real_x);
        }

        // metodo que entrega el real valor de y
        public int coord_y_real(int y, int altura) {
            int real_y = -y + altura / 2;

            return (real_y);
        }
    }   
}