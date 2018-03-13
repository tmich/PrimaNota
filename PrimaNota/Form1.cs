using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaNota.Models;
using System.Diagnostics;
using System.Data.Entity;

namespace PrimaNota
{
    public partial class Form1 : Form
    {
        List<Movimento> movimenti;
        decimal cassetta;
        static int counter;
        //BindingSource source;
        
        public Form1()
        {
            InitializeComponent();
            counter = 1;
            
            using (var ctx = new DAL.PrimaNotaContext())
            {
                movimenti = ctx.Movimenti
                    .Where(m => DbFunctions.TruncateTime(m.Data) == Giornata)
                    .ToList();
            }
            cassetta = 250.00M;
        }
        
        private DateTime Giornata
        {
            get
            {
                return dateTimePicker1.Value.Date;
            }
        }

        private decimal EntrateCassa
        {
            get
            {
                return movimenti.Where(m => m.Risorsa == Risorsa.Cassa).Where(m => m.Tipo == TipoMovimento.Entrata).Sum(m => m.Importo);
            }
        }

        private decimal UsciteCassa
        {
            get
            {
                return movimenti.Where(m => m.Risorsa == Risorsa.Cassa).Where(m => m.Tipo == TipoMovimento.Uscita).Sum(m => m.Importo);
            }
        }

        private decimal EntrateBanca
        {
            get
            {
                return movimenti.Where(m => m.Risorsa == Risorsa.Banca).Where(m => m.Tipo == TipoMovimento.Entrata).Sum(m => m.Importo);
            }
        }

        private decimal UsciteBanca
        {
            get
            {
                return movimenti.Where(m => m.Risorsa == Risorsa.Banca).Where(m => m.Tipo == TipoMovimento.Uscita).Sum(m => m.Importo);
            }
        }

        private void Aggiorna()
        {
            gridmov.DataSource = null;
            var source = movimenti.Select(m => new
            {
                Id = m.Id,
                Data = m.Data.Date,
                Turno = m.Turno.ToString()[0],
                Operatore = m.Operatore,
                Descrizione = m.Descrizione,
                Tipo = m.Tipo.ToString(),
                Risorsa = m.Risorsa.ToString(),
                Importo = m.Importo.ToString("0.00")
            }).ToList();
            source.Sort((m1, m2) => DateTime.Compare(m1.Data.Date, m2.Data.Date));

            gridmov.DataSource = source;
            gridmov.ClearSelection();
            gridmov.Columns["Id"].Visible = false;
            gridmov.Columns["Turno"].Width = 20;
            gridmov.Columns["Descrizione"].Width = 200;

            txtCassetta.Text = cassetta.ToString("0.00");
            txtTotEntrCas.Text = EntrateCassa.ToString("0.00");
            txtTotUscCas.Text = UsciteCassa.ToString("0.00");
            txtTotEntrBan.Text = EntrateBanca.ToString("0.00");
            txtTotUscBan.Text = UsciteBanca.ToString("0.00");
        }

        private void btnAggiungiMovimento_Click(object sender, EventArgs e)
        {
            Movimento m = new Movimento();
            FMovimento fm = new FMovimento(m);
            fm.ShowDialog();

            if (fm.DialogResult == DialogResult.OK)
            {
                m.Id = counter++;
                movimenti.Add(m);
                Aggiorna();
            }
        }

        private void gridmov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            long id = (long)gridmov["Id", e.RowIndex].Value;
            var m = movimenti.First(mv => mv.Id == id);
            FMovimento fm = new FMovimento(m);
            fm.ShowDialog(this);

            if (fm.DialogResult == DialogResult.OK)
            {
                movimenti[e.RowIndex] = m;
                Aggiorna();
            }

            gridmov.ClearSelection();
        }

        private void gridmov_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;
            
            if (gridmov.Columns[e.ColumnIndex].Name == "Importo")
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

                if (gridmov["Tipo", e.RowIndex].Value.Equals("Entrata"))
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Aggiorna();
        }
    }
}
