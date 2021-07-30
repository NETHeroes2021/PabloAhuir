using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public class Higo : IPerecedero
    {
        private readonly decimal peso;

        public Higo(decimal peso)
        {
            this.peso = peso;
        }

        public decimal devolverPeso()
        {
            return peso;
        }
    }
}