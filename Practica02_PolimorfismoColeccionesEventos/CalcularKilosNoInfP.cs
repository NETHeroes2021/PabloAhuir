using Practica02_PolimorfismoColeccionesEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public static class CalcularKilosNoInfP
    {
        /// <summary>
        /// Metodo que calcula los kilos de material no inflamable y perecedero de una coleccion
        /// filtrada con una sentencia linQ
        /// </summary>
        /// <param name="listaElementos"></param>
        /// <returns> valor decimal con el peso total </returns>
        public static decimal calcularKilosNoInfP(List<IElemento> listaElementos)
        {
            var kilos = 0.0m;

            var noInflamablesP = from material
                                in listaElementos
                                where (material is IPerecedero) && !(material is IFlamable)
                                select material;
            foreach (var item in noInflamablesP)
            {
                kilos += item.devolverPeso();
            }

            return kilos;
        }
    }
}
