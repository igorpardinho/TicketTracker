namespace TicketTracker.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;

        public List<Chamado> Chamados { get; set; } = [];
    }
}
