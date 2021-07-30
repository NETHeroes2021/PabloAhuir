using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Practica02_PolimorfismoColeccionesEventos.Test
{
    [TestClass]
    public class UnitTestAgnadirElemento
    {
        [TestMethod]
        public void TestMethodAgnadirElementoAcero()
        {
            var sender = "Acero";
            var objeto = AgnadirElemento.agnadirElemento(sender);
            Assert.IsTrue(objeto is Acero);
        }
        [TestMethod]
        public void TestMethodAgnadirElementoBronce()
        {
            var sender = "Bronce";
            var objeto = AgnadirElemento.agnadirElemento(sender);
            Assert.IsTrue(objeto is Bronce);
        }
        [TestMethod]
        public void TestMethodAgnadirElementoHigo()
        {
            var sender = "Higo";
            var objeto = AgnadirElemento.agnadirElemento(sender);
            Assert.IsTrue(objeto is Higo);
        }
    }

    [TestClass]
    public class UnitTestCalcularElementos
    {
        [TestMethod]
        public void TestMethodCalcularElementos()
        {
            List<IElemento> listaElementos = new List<IElemento>();
            IElemento item1 = new Bronce(30);
            IElemento item2 = new Higo(20);
            IElemento item3 = new Acero(10);
            IElemento item4 = new Bronce(15);
            IElemento item5 = new Papel(80);
            IElemento item6 = new Chip(44);
            IElemento item7 = new Escoba(26);

            listaElementos.Add(item1);
            listaElementos.Add(item2);
            listaElementos.Add(item3);
            listaElementos.Add(item4);
            listaElementos.Add(item5);
            listaElementos.Add(item6);
            listaElementos.Add(item7);
            
            var cantidad = CalcularElementos.realizarCalculos(listaElementos);
            Assert.AreEqual(7, cantidad);
        }        
    }
    [TestClass]
    public class UnitTestCalcularKilosNoInfP
    {
        [TestMethod]
        public void TestMethodCalcularKilosNoInfP()
        {
            List<IElemento> listaElementos = new List<IElemento>();
            IElemento item1 = new Higo(30);
            IElemento item2 = new Higo(20);
            IElemento item3 = new Acero(10);
            IElemento item4 = new Higo(15);
            IElemento item5 = new Papel(80);
            IElemento item6 = new Chip(44);
            IElemento item7 = new Escoba(26);

            listaElementos.Add(item1);
            listaElementos.Add(item2);
            listaElementos.Add(item3);
            listaElementos.Add(item4);
            listaElementos.Add(item5);
            listaElementos.Add(item6);
            listaElementos.Add(item7);

            var cantidad = CalcularKilosNoInfP.calcularKilosNoInfP(listaElementos);
            Assert.AreEqual(65, cantidad);
        }
    }
    [TestClass]
    public class UnitTestCalcularMediaNoP
    {
        [TestMethod]
        public void TestMethodCalcularMediaNoP()
        {
            List<IElemento> listaElementos = new List<IElemento>();
            IElemento item1 = new Higo(30);
            IElemento item2 = new Higo(20);
            IElemento item3 = new Acero(10);
            IElemento item4 = new Higo(15);
            IElemento item5 = new Papel(80);
            IElemento item6 = new Chip(44);

            listaElementos.Add(item1);
            listaElementos.Add(item2);
            listaElementos.Add(item3);
            listaElementos.Add(item4);
            listaElementos.Add(item5);
            listaElementos.Add(item6);

            var cantidad = (double)CalcularMediaNoP.calcularMediaNoP(listaElementos);
            Assert.AreEqual(50, cantidad, 0.01);
        }
        [TestMethod]
        public void TestMethodCalcularMediaNoP2()
        {
            List<IElemento> listaElementos = new List<IElemento>();
            IElemento item1 = new Higo(30);
            IElemento item2 = new Acero(20);
            IElemento item3 = new Acero(10);
            IElemento item4 = new Acero(15);


            listaElementos.Add(item1);
            listaElementos.Add(item2);
            listaElementos.Add(item3);
            listaElementos.Add(item4);


            var cantidad = (double)CalcularMediaNoP.calcularMediaNoP(listaElementos);
            Assert.AreEqual(75, cantidad, 0.01);
        }
    }
}
