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
            
            Aggiorna();
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
                Descrizione = "Giochi",
                Tipo = TipoMovimento.Entrata,
                Risorsa = Risorsa.Cassa,
                Importo = 40.00M
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
            gridmov.DataSource = movimenti.Select(m => new
            {
                Data = m.Data.Date,
                Descrizione = m.Descrizione,
                Tipo = m.Tipo.ToString(),
                Risorsa = m.Risorsa.ToString(),
                Importo = m.Importo.ToString("0.00")
            }).ToList();

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
            var m = movimenti[e.RowIndex];
            FMovimento fm = new FMovimento(m);
            fm.ShowDialog();

            if (fm.DialogResult == DialogResult.OK)
            {
                movimenti[e.RowIndex] = m;
                //source.ResetBindings(true);
                Aggiorna();
            }
        }

        private void gridmov_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(gridmov.Columns[e.ColumnIndex].Name == "Importo")
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
    }
}
