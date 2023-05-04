using System;

namespace VirtualnaTemperaturnaLista.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojLicence { get; set; }
        public string Email { get; set; }
        public int PozicijaId { get; set; }
        public Pozicija Pozicija { get; set; }

    }
}
