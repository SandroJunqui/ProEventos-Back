namespace ProEventos.Application.DTO
{
    public class RedeSocialDTO : DTOBase
    {
        public string? Nome { get; set; }
        public string? URL { get; set; }
        public string? EventoId { get; set; }
        public int PalestranteId { get; set; }
    }
}
