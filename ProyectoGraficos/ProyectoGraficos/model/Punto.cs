using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGraficos.model {
    public class Punto {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public int X1 {
            get {
                return this.x1;
            }
            set {
                this.x1 = value;
            }
        }

        public int Y1 {
            get {
                return this.y1;
            }
            set {
                this.y1 = value;
            }
        }

        public int X2 {
            get {
                return this.x2;
            }
            set {
                this.x2 = value;
            }
        }

        public int Y2 {
            get {
                return this.y2;
            }
            set {
                this.y2 = value;
            }
        }


    }
}