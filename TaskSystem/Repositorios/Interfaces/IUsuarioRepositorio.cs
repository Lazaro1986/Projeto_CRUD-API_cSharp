using System.Collections.Generic;
using System.Threading.Tasks;
using TaskSystem.Models;

namespace TaskSystem.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        // Adicionar/Buscar/Remover usuário...
        Task<List<UsuarioModel>> BuscarTodosUsuarios(); // Metodo que busca uma lista de usuários
        Task<UsuarioModel> BuscarPorId(int id);   // Metodo que busca um usuário específico pelo Id
        Task<UsuarioModel> Adicionar(UsuarioModel usuario); // Metodo que adiciona um usuário
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id); // Metodo que atualiza o registro de um usuário
        Task<bool> Apagar(int id);  // Metodo que apaga o registro de um usuário
    }
}
