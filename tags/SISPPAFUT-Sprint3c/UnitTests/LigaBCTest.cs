﻿using UPC.Proyecto.SISPPAFUT.BL.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.Proyecto.SISPPAFUT.BL.BE;
using System.Collections.Generic;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LigaBCTest and is intended
    ///to contain all LigaBCTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LigaBCTest
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
        ///A test for LigaBC Constructor
        ///</summary>
        [TestMethod()]
        public void LigaBCConstructorTest()
        {
            LigaBC target = new LigaBC();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for insertarLiga
        ///</summary>
        [TestMethod()]
        public void insertarLigaTest()
        {
            LigaBC target = new LigaBC();
            string pais = "España";
            string competicion = "La liga";
            LigaBE objLigaBE = new LigaBE();
            
            List<LigaEquipoBE> lstEquipos = new List<LigaEquipoBE>();
            LigaEquipoBE objLigaEquipoBE = new LigaEquipoBE();
            objLigaEquipoBE.CodigoLiga = 3;
            objLigaEquipoBE.CodigoEquipo = 21;
            lstEquipos.Add(objLigaEquipoBE);

            objLigaBE.TemporadaLiga = "2011/2012";
            objLigaBE.NombreLiga = "La Liga BBVA 2011/2012";
            objLigaBE.CantidadEquipos = 20;

            int expected = 0;
            int actual;
            actual = target.insertarLiga(pais, competicion, objLigaBE, lstEquipos);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for listaLigasPorCompeticion
        ///</summary>
        [TestMethod()]
        public void listaLigasPorCompeticionTest()
        {
            LigaBC target = new LigaBC();
            int codigoCompeticion = 1;
            List<LigaBE> expected = new List<LigaBE>();

            LigaBE liga = new LigaBE();
            liga.CodigoLiga = 3; liga.CodigoCompeticion = 1; liga.NombreLiga = "La Liga BBVA 2011/2012";
            liga.TemporadaLiga = "2011/2012"; liga.CantidadEquipos = 20; expected.Add(liga);

            List<LigaBE> actual;
            actual = target.listaLigasPorCompeticion(codigoCompeticion);
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].CodigoLiga, actual[i].CodigoLiga);
                Assert.AreEqual(expected[i].CodigoCompeticion, actual[i].CodigoCompeticion);
                Assert.AreEqual(expected[i].NombreLiga, actual[i].NombreLiga);
                Assert.AreEqual(expected[i].TemporadaLiga, actual[i].TemporadaLiga);
                Assert.AreEqual(expected[i].CantidadEquipos, actual[i].CantidadEquipos);
            }
        }

        /// <summary>
        ///A test for listarLigas
        ///</summary>
        [TestMethod()]
        public void listarLigasTest()
        {
            LigaBC target = new LigaBC();
            List<LigaBE> expected = new List<LigaBE>();

            LigaBE liga = new LigaBE();
            liga.CodigoLiga = 3; liga.CodigoCompeticion = 1; liga.NombreLiga = "La Liga BBVA 2011/2012";
            liga.TemporadaLiga = "2011/2012"; liga.CantidadEquipos = 20; expected.Add(liga);

            List<LigaBE> actual;
            actual = target.listarLigas();
            Assert.AreEqual(expected, actual);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].CodigoLiga, actual[i].CodigoLiga);
                Assert.AreEqual(expected[i].CodigoCompeticion, actual[i].CodigoCompeticion);
                Assert.AreEqual(expected[i].NombreLiga, actual[i].NombreLiga);
                Assert.AreEqual(expected[i].TemporadaLiga, actual[i].TemporadaLiga);
                Assert.AreEqual(expected[i].CantidadEquipos, actual[i].CantidadEquipos);
            }
        }
    }
}