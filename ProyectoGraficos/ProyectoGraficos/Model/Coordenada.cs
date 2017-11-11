using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGraficos.Model {
    public class Coordenada {
        private int id;
        private int x;
        private int y;

        public Coordenada() {
        }

        public Coordenada(int Id, int x1, int y1) {
            id = Id;
            x = x1;
            y = y1;
        }

        public int Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }

        public int X {
            get {
                return this.x;
            }
            set {
                this.x = value;
            }
        }

        public int Y {
            get {
                return this.y;
            }
            set {
                this.y = value;
            }
        }
    }
}