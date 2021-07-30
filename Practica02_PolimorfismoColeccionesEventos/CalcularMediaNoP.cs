using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public static class CalcularMediaNoP
    {
        /// <summary>
        /// Metodo que dada una lista de elementos calcula la media de los elementos no Perecederos
        /// </summary>
        /// <param name="listaElementos"></param>
        /// <returns> valor decimal de la media entre 0 y 100 </returns>
        public static decimal calcularMediaNoP(List<IElemento> listaElementos)
        {
            var contNP = 0.0m;

            var noPerecederos = from material 
                                in listaElementos 
                                where !(material is IPerecedero) && material is IElemento 
                                select material;
            foreach (var item in noPerecederos)
            {
                contNP++;
            }

            return (contNP / listaElementos.Count) * 100;
        }
    }
}
