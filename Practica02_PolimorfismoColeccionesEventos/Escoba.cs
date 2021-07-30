using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public class Escoba : IFlamable
    {
        private readonly decimal peso;

        public Escoba(decimal peso)
        {
            this.peso = peso;
        }

        public decimal devolverPeso()
        {
            return peso;
        }
    }
}