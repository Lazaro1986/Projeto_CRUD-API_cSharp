using System.Collections.Generic;
using System.Threading.Tasks;
using TaskSystem.Models;

namespace TaskSystem.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        // Adicionar/Buscar/Remover tarefas...
        Task<List<TarefaModel>> BuscarTodasTarefas(); // Metodo que busca uma lista de tarefas
        Task<TarefaModel> BuscarPorId(int id);   // Metodo que busca uma tarefa específica pelo Id
        Task<TarefaModel> Adicionar(TarefaModel tarefa); // Metodo que adiciona uma tarefa
        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id); // Metodo que atualiza o registro de uma tarefa
        Task<bool> Apagar(int id);  // Metodo que apaga o registro de um usuário
    }
}
