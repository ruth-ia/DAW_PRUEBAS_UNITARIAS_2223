using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;

namespace GestionBancariaTest
{
    [TestClass]
    public class GestionBancariaTest
    {

        [TestMethod]
        public void ValidarIngresoCaso1() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoEsperado = 1100;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarIngreso(ingreso);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el ingreso, saldo" +
            "incorrecto.");
        }

        [TestMethod]
        public void ValidarIngresoCaso2() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            try
            {
                miApp.RealizarIngreso(ingreso);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

        [TestMethod]
        public void ValidarIngresoCaso3() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -100;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            try
            {
                miApp.RealizarIngreso(ingreso);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

        [TestMethod]
        public void ValidarIngresoCaso4() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 0;
            double ingreso = 1000;
            double saldoEsperado = 1000;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarIngreso(ingreso);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el ingreso, saldo" +
            "incorrecto.");

        }

        [TestMethod]
        public void ValidarReintegroCaso1() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el reintegro, saldo" +
            "incorrecto.");

        }

        [TestMethod]
        public void ValidarReintegroCaso2() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            try
            {
                miApp.RealizarReintegro(reintegro);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

        [TestMethod]
        public void ValidarReintegroCaso3() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 500;
            double reintegro = 1000;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            try
            {
                miApp.RealizarReintegro(reintegro);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

        public void ValidarReintegroCaso4() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 500;
            double reintegro = 500;
            double saldoEsperado = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el reintegro, saldo" +
            "incorrecto.");
        }

        [TestMethod]
        public void ValidarReintegroCaso5() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -1;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            try
            {
                miApp.RealizarReintegro(reintegro);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

        [TestMethod]
        public void ValidarReintegroCaso6() //ruth-ia
        {
            // preparación del caso de prueba
            double saldoInicial = 0;
            double reintegro = 500;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            try
            {
                miApp.RealizarReintegro(reintegro);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }
    }
}
