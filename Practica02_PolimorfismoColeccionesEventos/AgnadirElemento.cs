using Practica02_PolimorfismoColeccionesEventos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public static class AgnadirElemento
    {
        /// <summary>
        /// Metodo que dado el texto de un boton instancia un objeto u otro
        /// </summary>
        /// <param name="btnPulsado"></param>
        /// <returns> el objeto instanciado </returns>
        public static IElemento agnadirElemento(string btnPulsado)
        {
            
            switch (btnPulsado)
            {
                case "Acero":
                    return new Acero(2);
                case "Bronce":
                    return new Bronce(1.5m);
                case "Gominola":
                    return new Gominola(0.01m);
                case "Higo":
                    return new Higo(0.05m);
                case "Chip":
                    return new Chip(0.001m);
                case "Papel":
                    return new Papel(0.008m);
                case "Escoba":
                    return new Escoba(0.65m);
                default:
                    return null;
            }
        }
    }
}
