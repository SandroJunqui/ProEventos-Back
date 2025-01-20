namespace ProEventos.Application.DTO
{
    public class PalestranteDTO : DTOBase
    {
        public string? Nome { get; set; }
        public string? MiniCurriculo { get; set; }
        public string? ImagemURL { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public IEnumerable<RedeSocialDTO>? RedesSociais { get; set; }
        public IEnumerable<EventoDTO>? Eventos { get; set; }
    }
}
