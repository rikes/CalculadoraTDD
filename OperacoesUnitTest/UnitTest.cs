using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplicationCalculadora;


namespace OperacoesUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void testSoma()
        {
            int a = 0;
            int b = 1;
            int esperado = 1;
            int atual = 0;
            Operacoes objetivo = new Operacoes();
            atual = objetivo.soma(a,b);
            Assert.AreEqual(esperado, atual);
        }
        [TestMethod]
        public void testDivisao()
        {
            int a = 3;
            int b = 1;
            int esperado = 3;
            int atual = 0;
            Operacoes objetivo = new Operacoes();
            atual = objetivo.divisao(a, b);
            Assert.AreEqual(esperado, atual);
        }
        [TestMethod]
        public void testSubtracao()
        {
            int a = 5;
            int b = 1;
            int esperado = 3;
            int atual = 0;
            Operacoes objetivo = new Operacoes();
            atual = objetivo.subtracao(a, b);
            Assert.AreEqual(esperado, atual);
        }
        [TestMethod]
        public void testSubtracao()
        {
            int a = 5;
            int b = 1;
            int esperado = 3;
            int atual = 0;
            Operacoes objetivo = new Operacoes();
            atual = objetivo.multiplicao(a, b);
            Assert.AreEqual(esperado, atual);
        }
    }
}
