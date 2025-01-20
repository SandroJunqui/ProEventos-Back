namespace ProEventos.Application.DTO
{
    public class EventoDTO : DTOBase
    {
        public string? Local { get; set; }
        public string? DataEvento { get; set; }
        public string? Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string? ImagemURL { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public IEnumerable<LoteDTO>? Lotes { get; set; }
        public IEnumerable<RedeSocialDTO>? RedesSociais { get; set; }
        public IEnumerable<PalestranteDTO>? Palestrantes { get; set; }
    }
}
