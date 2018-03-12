using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaNota
{
    public partial class Form1 : Form
    {
        List<Movimento> movimenti;
        decimal cassetta;
        //BindingSource source;
        
        public Form1()
        {
            InitializeComponent();
            cmbTurno.SelectedIndex = 0;
            CreaDati();
            //source = new BindingSource();
            //source.DataSource = movimenti.ToList();
            //gridmov.DataSource = movimenti.ToList();
        }

        private void CreaDati()
        {
            movimenti = new List<Movimento>();

            movimenti.Add(new Movimento
            {
                Id = 1,
                Data = DateTime.Now,
                Descrizione = "Tabacchi",
                Tipo = TipoMovimento.Entrata,
                Risorsa = Risorsa.Cassa,
                Importo = 250.00M
            });

            movimenti.Add(new Movimento
            {
                Id = 2,
                Data = DateTime.Now,
                Descrizione = "Giochi bambini",
                Tipo = TipoMovimento.Entrata,
                Risorsa = Risorsa.Cassa,
                Importo = 40.00M
            });

            movimenti.Add(new Movimento
            {
                Id = 3,
                Data = DateTime.Now,
                Descrizione = "Gratta e Vinci",
                Tipo = TipoMovimento.Entrata,
                Risorsa = Risorsa.Cassa,
                Importo = 240.00M
            });

            movimenti.Add(new Movimento
            {
                Id = 4,
                Data = DateTime.Now,
                Descrizione = "Vincite Gratta e Vinci",
                Tipo = TipoMovimento.Uscita,
                Risorsa = Risorsa.Cassa,
                Importo = 20.00M
            });

            movimenti.Add(new Movimento
            {
                Id = 5,
                Data = DateTime.Now,
                Descrizione = "Bar",
                Tipo = TipoMovimento.Entrata,
                Risorsa = Risorsa.Cassa,
                Importo = 350.00M
            });

            //txtCassetta.DataBindings.Add("Text", cassetta, "", false, DataSourceUpdateMode.OnValidation);
            //txtTotEntrCas.DataBindings.Add("Text", EntrateCassa, "", false, DataSourceUpdateMode.OnValidation);
            //txtTotUscCas.DataBindings.Add("Text", UsciteCassa, "", false, DataSourceUpdateMode.OnValidation);
            //txtTotEntrBan.DataBindings.Add("Text", EntrateBanca, "", false, DataSourceUpdateMode.OnValidation);
            //txtTotUscBan.DataBindings.Add("Text", UsciteBanca, "", false, DataSourceUpdateMode.OnValidation);

            //gridmov.DataBindings.Add("DataSource", movimenti.ToList(), "", false, DataSourceUpdateMode.OnPropertyChanged);

            cassetta = 250.00M;
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
                Descrizione = m.Descrizione,
                Tipo = m.Tipo.ToString(),
                Risorsa = m.Risorsa.ToString(),
                Importo = m.Importo.ToString("0.00")
            }).ToList();
            source.Sort((m1, m2) => DateTime.Compare(m1.Data.Date, m2.Data.Date));

            gridmov.DataSource = source;
            gridmov.ClearSelection();
            gridmov.Columns["Id"].Visible = false;
            gridmov.Columns["Descrizione"].Width = 400;

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
                movimenti.Add(m);
                //source.ResetBindings(true);
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
            fm.ShowDialog();

            if (fm.DialogResult == DialogResult.OK)
            {
                movimenti[e.RowIndex] = m;
                //source.ResetBindings(true);
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
