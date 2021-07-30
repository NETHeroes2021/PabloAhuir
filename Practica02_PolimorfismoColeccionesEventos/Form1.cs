using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practica02_PolimorfismoColeccionesEventos
{
    public partial class Form1 : Form
    {
        List<IElemento> listaElementos = new List<IElemento>(100);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comprueba que botón ha sido pulsado y crea un objeto en funcion de su Texto.
        /// Actualiza los labels para que muestren datos correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agnadirObjeto_Click(object sender, EventArgs e)
        {
            listaElementos.Add(AgnadirElemento.agnadirElemento((sender as Button).Text));

            labelTotalMateriales.Text = "Cantidad total de materiales: " + CalcularElementos.realizarCalculos(listaElementos);
            labelMediaNoPerecederos.Text = CalcularMediaNoP.calcularMediaNoP(listaElementos).ToString();
            labelKg.Text = "Kilos de material perecedero no inflamable: " + CalcularKilosNoInfP.calcularKilosNoInfP(listaElementos) + " Kg";
        }
    }
}
