using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimaNota.Models;

namespace PrimaNota.DAL
{
    public class PrimaNotaDBInitializer : DropCreateDatabaseAlways<PrimaNotaContext>
    {

        protected override void Seed(PrimaNotaContext context)
        {
            IList<Movimento> movimenti = new List<Movimento>();

            movimenti.Add(new Movimento { Data = DateTime.Now, Descrizione = "Tabacchi", Tipo = TipoMovimento.Entrata, Risorsa = Risorsa.Cassa, Importo = 250.00M, Operatore = "LILIANA", Turno = Turno.Mattina });
            movimenti.Add(new Movimento { Data = DateTime.Now, Descrizione = "Giochi bambini", Tipo = TipoMovimento.Entrata, Risorsa = Risorsa.Cassa, Importo = 40.00M, Operatore = "LILIANA", Turno = Turno.Mattina });
            movimenti.Add(new Movimento { Data = DateTime.Now, Descrizione = "Gratta e Vinci", Tipo = TipoMovimento.Entrata, Risorsa = Risorsa.Cassa, Importo = 240.00M, Operatore = "GIAMBATTISTA", Turno = Turno.Pomeriggio });
            movimenti.Add(new Movimento { Data = DateTime.Now, Descrizione = "Vincite Gratta e Vinci", Tipo = TipoMovimento.Uscita, Risorsa = Risorsa.Cassa, Importo = 20.00M, Operatore = "GRAZIA", Turno = Turno.Unico });
            movimenti.Add(new Movimento { Data = DateTime.Now, Descrizione = "Bar", Tipo = TipoMovimento.Entrata, Risorsa = Risorsa.Cassa, Importo = 350.00M, Operatore = "IEZZI", Turno = Turno.Unico });

            context.Movimenti.AddRange(movimenti);

            IList<DescrizioneMovimento> descrizioni = new List<DescrizioneMovimento>();
            descrizioni.Add(new DescrizioneMovimento { Valore = "Pagamento Fornitore", Tipo = TipoMovimento.Uscita });
            descrizioni.Add(new DescrizioneMovimento { Valore = "Versamento Banca", Tipo = TipoMovimento.Uscita });
            descrizioni.Add(new DescrizioneMovimento { Valore = "Gratta&Vinci Uscite", Tipo = TipoMovimento.Uscita });
            descrizioni.Add(new DescrizioneMovimento { Valore = "POS/Carte", Tipo = TipoMovimento.Entrata });
            descrizioni.Add(new DescrizioneMovimento { Valore = "Valori Bollati", Tipo = TipoMovimento.Entrata });
            descrizioni.Add(new DescrizioneMovimento { Valore = "Gratta&Vinci Incasso", Tipo = TipoMovimento.Entrata });
            descrizioni.Add(new DescrizioneMovimento { Valore = "Tabacchi Incasso", Tipo = TipoMovimento.Entrata });
            descrizioni.Add(new DescrizioneMovimento { Valore = "Buoni Pasto", Tipo = TipoMovimento.Entrata });

            context.DescrizioniMovimento.AddRange(descrizioni);

            base.Seed(context);
        }
    }
}
