using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficarVectores.model {
    class Coordenada {
        private int id;
        private int x;
        private int y;

        public Coordenada() {
        }

        public Coordenada(int X, int Y) {
            x = X;
            y = Y;
        }

        public Coordenada(int ID, int X, int Y) {
            id = ID;
            x = X;
            y = Y;
        }

        public int Id { get => id; set => id = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
