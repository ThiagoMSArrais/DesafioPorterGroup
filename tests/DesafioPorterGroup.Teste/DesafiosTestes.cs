using DesafioPorterGroup.Console;

namespace DesafioPorterGroup.Teste
{
    public class DesafiosTestes
    {
        [Fact]
        public void ObterNumeroPorExtensoComSucesso()
        {
            // Arrange
            var numero = 123;

            // Act
            string numeroPorExtenso = Desafios.ObterNumeroPorExtenso(numero);

            // Assert
            Assert.Equal("cento e vinte e três", numeroPorExtenso);
        }

        [Fact]
        public void SomarValoresDeUmaArrayComSucesso()
        {
            // Arrange
            var numeros = new int[] { 1, 2, 3, 4 };

            // Act
            double resultado = Desafios.SomarValores(numeros);

            // Assert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void CalcularExpressaoMatematicaComSucesso()
        {
            // Arrange
            string expressaoNumerica = "2 + 3 * 5";

            // Act
            double resultado = Desafios.CalcularExpressaoMatematica(expressaoNumerica);

            // Assert
            Assert.Equal(17, resultado);
        }

        [Fact]
        public void RetornarObjetosDistintos()
        {
            // Arrange
            List<Carros> carrosDuplicados = new();
            carrosDuplicados.Add(new Carros() { Fabricante = "Volvo" });
            carrosDuplicados.Add(new Carros() { Fabricante = "Ferrari" });
            carrosDuplicados.Add(new Carros() { Fabricante = "Audi" });
            carrosDuplicados.Add(new Carros() { Fabricante = "Fiat" });
            carrosDuplicados.Add(new Carros() { Fabricante = "Renaut" });
            carrosDuplicados.Add(new Carros() { Fabricante = "Fiat" });

            // Act
            List<Carros> resultadoCarrosDistintos = Desafios.ObterListasDistintas(carrosDuplicados);

            // Assert
            Assert.True(resultadoCarrosDistintos.Count().Equals(5));
        }
    }
}