using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public class Bronce : IElemento
    {
        private readonly decimal peso;

        public Bronce(decimal peso)
        {
            this.peso = peso;
        }

        public decimal devolverPeso()
        {
            return peso;
        }
    }
}