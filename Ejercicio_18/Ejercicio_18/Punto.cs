﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Punto
    {
        private int x;
        private int y;
        Punto (int x , int y)
        {
            this.x = x;
            this.y = y;

        }

        public int GetX ()
        {
            return x;

        }
        public int GetY()
        {
            return y;

        }
    }
}
