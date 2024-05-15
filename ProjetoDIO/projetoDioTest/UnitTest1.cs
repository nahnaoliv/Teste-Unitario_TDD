using ProjetoDIO;
using System.Security.Cryptography.X509Certificates;

namespace projetoDioTest
{
    //obs: deixei erros propositais pra teste
    public class UnitTest1
    {
        [Theory]
        [InlineData(5,10,15)]
        [InlineData(1,2,3)]
        [InlineData(2,3,5)]
        public void ResuladoDeSomar (int valor1, int valor2, int resultado)
        {
            Calculadora cal = new Calculadora();

            int resultadoFinal = cal.Somar(valor1, valor2);
            Assert.Equal(resultado, resultadoFinal);
        }

        [Theory]
        [InlineData(5, 10, 5)]
        [InlineData(1, 2, 1)]
        [InlineData(2, 4, 2)]
        public void ResuladoDeSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora cal = new Calculadora();

            int resultadoFinal = cal.Subtrair(valor1, valor2);
            Assert.Equal(resultado, resultadoFinal);
        }

        [Theory]
        [InlineData(5, 10, 50)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 3, 6)]
        public void ResuladoDeMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora cal = new Calculadora();

            int resultadoFinal = cal.Multiplicar(valor1, valor2);
            Assert.Equal(resultado, resultadoFinal);
        }

        [Theory]
        [InlineData(5, 10, 5)]
        [InlineData(1, 2, 1)]
        [InlineData(2, 6, 3)]
        public void ResuladoDeDididir(int valor1, int valor2, int resultado)
        {
            Calculadora cal = new Calculadora();

            int resultadoFinal = cal.Divide(valor1, valor2);
            Assert.Equal(resultado, resultadoFinal);
        }
    }
}