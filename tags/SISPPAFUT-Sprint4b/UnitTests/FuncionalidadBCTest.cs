﻿using UPC.Seguridad.BL.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para FuncionalidadBCTest y se pretende que
    ///contenga todas las pruebas unitarias FuncionalidadBCTest.
    ///</summary>
    [TestClass()]
    public class FuncionalidadBCTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
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

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Constructor FuncionalidadBC
        ///</summary>
        [TestMethod()]
        public void FuncionalidadBCConstructorTest()
        {
            FuncionalidadBC target = new FuncionalidadBC();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de Insertar_Funcionalidad
        ///</summary>
        [TestMethod()]
        public void Insertar_FuncionalidadTest()
        {
            FuncionalidadBC target = new FuncionalidadBC();
            string NombreFuncionalidad = "Gestión de Ligas";
            string DescripcionFuncionalidad = "Mediante esta funcionalidad se pueden administrar las ligas en el sistema";
            int expected = -1; 
            int actual;
            actual = target.Insertar_Funcionalidad(NombreFuncionalidad, DescripcionFuncionalidad);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Verificar_ExisteFuncionalidad
        ///</summary>
        [TestMethod()]
        public void Verificar_ExisteFuncionalidadTest()
        {
            FuncionalidadBC target = new FuncionalidadBC();
            string NombreFuncionalidad = "Gestión de Ligas";
            int expected = 1;
            int actual;
            actual = target.Verificar_ExisteFuncionalidad(NombreFuncionalidad);
            Assert.AreEqual(expected, actual);
        }
    }
}
