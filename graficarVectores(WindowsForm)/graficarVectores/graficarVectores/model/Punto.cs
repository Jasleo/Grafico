using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficarVectores.model {
    class Punto {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public Punto() {
        }

        public Punto(int X1, int X2, int Y1, int Y2 ) {
            x1 = X1;
            x2 = X2;
            y1 = Y1;
            y2 = Y2;
        }

        public int X1 { get => x1; set => x1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int Y2 { get => y2; set => y2 = value; }
    }
}
