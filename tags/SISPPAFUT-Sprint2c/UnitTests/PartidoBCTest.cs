﻿using UPC.Proyecto.SISPPAFUT.BL.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.Proyecto.SISPPAFUT.BL.BE;
using System.Collections.Generic;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for PartidoBCTest and is intended
    ///to contain all PartidoBCTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PartidoBCTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for insertar_Partido
        ///</summary>
        [TestMethod()]
        public void insertar_PartidoTest()
        {
            PartidoBC target = new PartidoBC(); 
            PartidoBE objPartidoBE = new PartidoBE();

            objPartidoBE.Codigo_liga = 3;
            objPartidoBE.Codigo_equipo_local = 1;
            objPartidoBE.Codigo_equipo_visitante = 3;
            objPartidoBE.Codigo_estadio = 2;
            objPartidoBE.Goles_local = 0;
            objPartidoBE.Goles_visita = 0;
            objPartidoBE.Fecha_partido = Convert.ToDateTime("2012-04-24");

            int expected = 0;
            int actual;
            
            actual = target.insertar_Partido(objPartidoBE);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for PartidoBC Constructor
        ///</summary>
        [TestMethod()]
        public void PartidoBCConstructorTest()
        {
            PartidoBC target = new PartidoBC();
        }

        /// <summary>
        ///A test for obtener_Partido
        ///</summary>
        [TestMethod()]
        public void obtener_PartidoTest()
        {
            PartidoBE expected = new PartidoBE();
            expected.Codigo_partido = 2;
            expected.Codigo_liga = 3;
            expected.Codigo_equipo_local = 1;
            expected.Codigo_equipo_visitante = 12;
            expected.Codigo_estadio = 2;
            expected.Fecha_partido = Convert.ToDateTime("2012-04-28");

            PartidoBC target = new PartidoBC(); 
            int codigo_partido = 2;

            PartidoBE actual;
            actual = target.obtener_Partido(codigo_partido);

            Assert.AreEqual(expected.Codigo_partido, actual.Codigo_partido);
            Assert.AreEqual(expected.Codigo_liga, actual.Codigo_liga);
            Assert.AreEqual(expected.Codigo_equipo_local, actual.Codigo_equipo_local);
            Assert.AreEqual(expected.Codigo_equipo_visitante, actual.Codigo_equipo_visitante);
            Assert.AreEqual(expected.Codigo_estadio, actual.Codigo_estadio);
            Assert.AreEqual(expected.Fecha_partido, actual.Fecha_partido);
        }

        /// <summary>
        ///A test for lista_partidos_sinjugar
        ///</summary>
        [TestMethod()]
        public void lista_partidos_sinjugarTest()
        {
            List<PartidoSinJugarBE> expected = new List<PartidoSinJugarBE>();

            PartidoSinJugarBE obj = new PartidoSinJugarBE();
            obj.Codigo_partido = 6;
            obj.Equipo_local = "Real Madrid";
            obj.Equipo_visitante = "FC Barcelona";
            obj.Liga = "La Liga BBVA 2011/2012";
            obj.Pais = "España";
            obj.Fecha = Convert.ToDateTime("2012-06-02");
            expected.Add(obj);

            PartidoBC target = new PartidoBC();
            List<PartidoSinJugarBE> actual = new List<PartidoSinJugarBE>();
            actual = target.lista_partidos_sinjugar();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Codigo_partido, actual[i].Codigo_partido);
                Assert.AreEqual(expected[i].Equipo_local, actual[i].Equipo_local);
                Assert.AreEqual(expected[i].Equipo_visitante, actual[i].Equipo_visitante);
                Assert.AreEqual(expected[i].Liga, actual[i].Liga);
                Assert.AreEqual(expected[i].Pais, actual[i].Pais);
                Assert.AreEqual(expected[i].Fecha, actual[i].Fecha);
            }
        }
    }
}