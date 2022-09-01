using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TustaDesafio.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Program_shouldReturnNotEqual()
        {
            string VALOR_MONETARIO_MOCK = "555,00";
            int NUMERO_PARCELAS_MOCK = 12;
            float VALOR_PARCELA_MOCK = 50;

            Assert.AreNotEqual(VALOR_PARCELA_MOCK, Program.CalculaParcelas(float.Parse(VALOR_MONETARIO_MOCK), NUMERO_PARCELAS_MOCK));
        }

        [TestMethod()]
        public void Program_shouldReturnEqual()
        {
            string VALOR_MONETARIO_MOCK = "720,00";
            int NUMERO_PARCELAS_MOCK = 12;
            float VALOR_PARCELA_MOCK = 60;

            Assert.AreEqual(VALOR_PARCELA_MOCK, Program.CalculaParcelas(float.Parse(VALOR_MONETARIO_MOCK), NUMERO_PARCELAS_MOCK));
        }
    }
}