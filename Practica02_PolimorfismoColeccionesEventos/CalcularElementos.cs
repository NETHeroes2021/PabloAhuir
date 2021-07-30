using System;
using System.Collections.Generic;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public static class CalcularElementos
    {
        /// <summary>
        /// Metodo que devuelve la cantidad de elementos de una lista
        /// </summary>
        /// <param name="listaElementos"></param>
        /// <returns>cantidad total de elementos de una lista</returns>
        public static int realizarCalculos(List<IElemento> listaElementos)
        {
            return listaElementos.Count;
        }
    }
}
