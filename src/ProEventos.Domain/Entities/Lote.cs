﻿namespace ProEventos.Domain.Entities
{
    public class Lote : EntityBase
    {
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int? Quantidade { get; set; }
        public int? EventoId { get; set; }
        public Evento? Evento { get; set; }
    }
}
