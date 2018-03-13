using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaNota.Models
{
    public enum Risorsa
    {
        Cassa,
        Banca
    }

    public enum TipoMovimento
    {
        Entrata,
        Uscita
    }
    
    public enum Turno
    {
        Mattina,
        Pomeriggio,
        Unico
    }

    public class DescrizioneMovimento
    {
        public int Id { get; set; }
        public string Valore { get; set; }
        public TipoMovimento Tipo { get; set; }

        public DescrizioneMovimento()
        {
            Id = 0;
            Valore = string.Empty;
            Tipo = TipoMovimento.Entrata;
        }
    }

    public class Movimento
    {
        public Movimento()
        {
            Id = 0;
            Data = DateTime.Now;
            Descrizione = string.Empty;
            Risorsa = Risorsa.Cassa;
            Tipo = TipoMovimento.Entrata;
            Importo = 0.00M;
            Operatore = string.Empty;
            Turno = Turno.Unico;
        }

        public long Id { get; set; }
        public DateTime Data { get; set; }
        public string Descrizione { get; set; }
        public Risorsa Risorsa { get; set; }
        public TipoMovimento Tipo { get; set; }
        public decimal Importo { get; set; }
        public string Operatore { get; set; }
        public Turno Turno { get; set; }
    }
}
