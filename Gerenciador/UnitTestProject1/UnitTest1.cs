using System;
using System.Linq;
using Xunit;
using Gerenciador_Tarefas.Models;

namespace UnitTestProject1
{
    public class GerenciadorTestes
    {
        [Theory]
        [InlineData("2023-10-25", "Fazer compras", "1 ==> Dia: 2023-10-25 - Fazer compras")]
        [InlineData("2023-10-26", "Estudar C#", "2 ==> Dia: 2023-10-26 - Estudar C#")]
        [InlineData("2023-10-27", "Lavar o carro", "3 ==> Dia: 2023-10-27 - Lavar o carro")]
        public void TesteAdicionarTarefa(string data, string tarefa, string esperado)
        {

            var gerenciador = new Gerenciador();

            gerenciador.AdicionarTarefa(data, tarefa);
            var tarefas = gerenciador.ObterTarefas();

            Assert.Contains(esperado, tarefas);
        }
    }
}
