using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public class Acero : IElemento
    {
        private readonly decimal peso;

        public Acero(decimal peso)
        {
            this.peso = peso;
        }

        public decimal devolverPeso()
        {
            return peso;
        }
    }
}