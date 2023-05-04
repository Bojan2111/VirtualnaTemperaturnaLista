using System;
using VirtualnaTemperaturnaLista.Models.TipoviParametra;

namespace VirtualnaTemperaturnaLista.Models.Sections
{
    public class VitalniParametar
    {
        public int Id { get; set; }
        public int TipVitalnogParametraId { get; set; }
        public TipVitalnogParametra TipVitalnogParametra { get; set; }
        public DateTime VremeUpisivanja { get; set; }
        public decimal Vrednost { get; set; }
    }
}
