using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace btg_test
{
    // nomeMetodo_CondicaoCenario_ComportamentoEsperado():
    public class MedialdadesTest
    {
        [Fact]
        public void calculaIdade_MaiorDezoito_Verdadeiro()
        {
            //Arrange
            List<int> lista = new() {15, 20, 30};

            MediaIdades mediaIdades = new();

            //Act
            decimal resultado = mediaIdades.CalculaMedia(lista);

            //Assert
            Assert.Equal(25, resultado);
        }

        [Fact]
        public void calculaIdade_MaiorDezoito_Falso()
        {
            //Arrange
            List<int> lista = new() { 15, 10, 16};

            MediaIdades mediaIdades = new();

            //Act
            Action resultado = () => mediaIdades.CalculaMedia(lista);

            //Assert
            Assert.Throws<DivideByZeroException>(resultado);
        }
    }
}
