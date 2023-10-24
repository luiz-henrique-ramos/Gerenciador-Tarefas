using System;
using System.Linq;
using Xunit;
using Gerenciador_Tarefas.Models;
using System.Collections.Generic;

namespace Teste_do_Gerenciador
{
    public class GerenciadorTest
    {
        [Theory]
        [InlineData("2023-10-25", "Fazer compras", "1 ==> Dia: 2023-10-25 - Fazer compras")]
        [InlineData("2023-10-26", "Estudar C#", "1 ==> Dia: 2023-10-26 - Estudar C#")]
        [InlineData("2023-10-27", "Lavar o carro", "1 ==> Dia: 2023-10-27 - Lavar o carro")]
        public void TestAdicionarTarefa(string data, string tarefa, string esperado)
        {
            var gerenciador = new Gerenciador();

            gerenciador.AdicionarTarefa(data, tarefa);
            var tarefas = gerenciador.ObterTarefas();

            Assert.Contains(esperado, tarefas);
        }

        [Fact]
        public void TestApagarTarefa()
        {
            var gerenciador = new Gerenciador();

            gerenciador.AdicionarTarefa("2023-10-25", "Fazer compras");
            gerenciador.AdicionarTarefa("2023-10-26", "Estudar C#");
            gerenciador.AdicionarTarefa("2023-10-27", "Lavar o carro");

            gerenciador.ApagarTarefa(2);

            var tarefas = gerenciador.ObterTarefas();

            Assert.Equal(2, tarefas.Count);
            Assert.DoesNotContain("2 ==> Dia: 2023-10-26 - Estudar C#", tarefas);

        }
    }
}
