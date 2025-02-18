﻿namespace ProEventos.Application.DTO
{
    public class LoteDTO : DTOBase
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string? DataInicio { get; set; }
        public string? DataFim { get; set; }
        public int EventoId { get; set; }
    }
}
