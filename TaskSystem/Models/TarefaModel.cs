using TaskSystem.Enums;

namespace TaskSystem.Models
{
    public class TarefaModel
    {
        //Entidade representando a tabela "Tarefas" do banco de dados

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
    }
}
