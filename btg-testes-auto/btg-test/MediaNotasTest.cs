using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btg_testes_auto;

namespace btg_test
{
    public class MediaNotasTest
    {
        [Fact]
        public void calculaMedia_MenorQueSete_Reprovado()
        {
            //Arrange
            MediaNotas media = new();

            List<decimal> listaNotas = new() { 0, 10, 2 };

            //Act
            string resultado = media.CalculaMedia(listaNotas, 5);

            //Assert
            Assert.Contains("não", resultado);
        }

        [Fact]
        public void calculaMedia_MenorQueSete_Aprovado()
        {
            //Arrange
            MediaNotas media = new();

            List<decimal> listaNotas = new() { 8, 10, 2 };

            //Act
            string resultado = media.CalculaMedia(listaNotas, 8);

            //Assert
            Assert.Contains("Parabéns", resultado);
        }

        [Fact]
        public void calculaMedia_MaiorQueSete_Aprovado()
        {
            //Arrange
            MediaNotas media = new();

            List<decimal> listaNotas = new() { 8, 10, 4 };

            //Act
            string resultado = media.CalculaMedia(listaNotas, 0);

            //Assert
            Assert.Contains("Parabéns", resultado);
        }
    }
}
