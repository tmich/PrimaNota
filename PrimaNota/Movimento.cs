using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaNota
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
        }

        public long Id { get; set; }
        public DateTime Data { get; set; }
        public string Descrizione { get; set; }
        public Risorsa Risorsa { get; set; }
        public TipoMovimento Tipo { get; set; }
        public decimal Importo { get; set; }
    }
}
