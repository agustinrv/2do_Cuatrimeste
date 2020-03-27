﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
    public class Vehiculo
    {
        protected double _precio;


        public virtual void MostrarPrecio()
        {
            Console.WriteLine("Precio : {0}", this._precio);
        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
            



    }
}
