using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Tarefas.models
{
    class Gerenciador
    {
        private List<string> tarefas = new List<string>();

        public Gerenciador()
        {

        }

        public void AdicionarTarefa(string data, string tarefa)
        {
            int numero = tarefas.Count + 1;
            tarefas.Add(numero + " ==> Dia: " + data + " - " + tarefa);
        }

        public List<string> ObterTarefas()
        {
            return tarefas;
        }

        public void ApagarTarefa(int numero)
        {
            if (numero >= 1 && numero <= tarefas.Count)
            {
                tarefas.RemoveAt(numero - 1);
                RenumerarTarefas();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada");
            }
        }

        private void RenumerarTarefas()
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                string tarefa = tarefas[i].Substring(tarefas[i].IndexOf(" ") + 1);
                tarefas[i] = $"{i + 1} {tarefa}";
            }
        }
    }
}
