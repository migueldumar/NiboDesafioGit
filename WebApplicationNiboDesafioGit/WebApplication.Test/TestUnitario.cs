using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplicationNiboDesafioGit;

namespace WebApplication.Test
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void TestIniciaComMaiusculo()
        {
            string[] palavras = { "Cachorro", "Gato", "Tartaruga", "Coelho" };
            foreach (var palavra in palavras)
            {
                bool resultado = palavra.PrimeiraLetraMaiuscula();
                Assert.IsTrue(resultado,
                    string.Format("Espedao para '{0}:True; Atual:{1}",
                                    palavra, resultado));
            }
        }
        [TestMethod]
        public void TestIniciaComMinusculo()
        {
            string[] palavras = { "cachorro", "gato", "tartaruga", "coelho" };
            foreach (var palavra in palavras)
            {
                bool resultado = palavra.PrimeiraLetraMaiuscula();
                Assert.IsFalse(resultado,
                    string.Format("Espedao para '{0}:True; Atual:{1}",
                                    palavra, resultado));
            }
        }
    }
}
