using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;
using PrimaNota.Models;

namespace PrimaNota
{
    public partial class FMovimento : Form
    {
        public Movimento Movimento { get; private set; }

        public FMovimento()
        {
            InitializeComponent();

            AggiornaDescrizioni();
            AggiornaTurni();
        }

        private void AggiornaTurni()
        {
            cmbTurno.Items.AddRange(new List<object>()
            {
                new {Id=1, Descrizione=Turno.Mattina.ToString()},
                new {Id=2, Descrizione=Turno.Pomeriggio.ToString()},
                new {Id=3, Descrizione=Turno.Unico.ToString()}
            }.ToArray());
        }

        public FMovimento(Movimento mov) 
            : this()
        {
            Movimento = mov;
            dtMovimento.Value = Movimento.Data;
            cmbTurno.Text = mov.Turno.ToString();
            cmbRisorsa.SelectedIndex = Movimento.Risorsa == Risorsa.Cassa ? 0 : 1;
            rbEntrata.Checked = (Movimento.Tipo == TipoMovimento.Entrata);
            rbUscita.Checked = !rbEntrata.Checked;
            cmbDescrizione.Text = Movimento.Descrizione;
            txtImporto.Value = Movimento.Importo;

            DialogResult = DialogResult.Cancel;
        }

        private void AggiornaDescrizioni()
        {
            List<DescrizioneMovimento> descs;
            cmbDescrizione.Text = string.Empty;
            cmbDescrizione.SelectedItem = null;
            cmbDescrizione.Items.Clear();

            using (var ctx = new DAL.PrimaNotaContext())
            {
                if (rbUscita.Checked)
                {
                    descs = ctx.DescrizioniMovimento.Where(d => d.Tipo == TipoMovimento.Uscita).ToList();
                }
                else
                {
                    descs = ctx.DescrizioniMovimento.Where(d => d.Tipo == TipoMovimento.Entrata).ToList();
                }
            }

            cmbDescrizione.Items.AddRange(descs.ToArray());
        }
        
        private void rbUscita_CheckedChanged(object sender, EventArgs e)
        {
            AggiornaDescrizioni();
        }

        private void cmdAggiungiDescrizione_Click(object sender, EventArgs e)
        {
            DescrizioneMovimento desc = new DescrizioneMovimento();
            var f = new FDescrizioneMovimento(desc);

            if (f.ShowDialog(this) == DialogResult.OK)
            {
                //if(desc.Tipo == TipoMovimento.Uscita)
                //{
                //    desc.Id = counter1++;
                //    descUscita.Add(desc);
                //    rbUscita.Checked = true;
                //}
                //else
                //{
                //    desc.Id = counter2++;
                //    descEntrata.Add(desc);
                //    rbEntrata.Checked = true;
                //}

                using (var ctx = new DAL.PrimaNotaContext())
                {
                    ctx.DescrizioniMovimento.Add(desc);
                    ctx.SaveChanges();
                }

                AggiornaDescrizioni();
                cmbDescrizione.SelectedItem = desc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DescrizioneMovimento desc = cmbDescrizione.SelectedItem as DescrizioneMovimento;

            if (desc != null)
            {
                MessageBox.Show(string.Format("{0}: {1}", desc.Id,  desc.Valore));
            }
            else
            {
                MessageBox.Show(cmbDescrizione.Text);
            }

            //return;

            if(cmbDescrizione.Text.Trim().Equals(string.Empty))
            {
                Utils.ShowWarning("Inserire una descrizione");
                cmbDescrizione.Focus();
                return;
            }

            if(dtMovimento.Value > DateTime.Now)
            {
                Utils.ShowWarning("Impossible inserire una data futura");
                dtMovimento.Focus();
                return;
            }

            if (txtImporto.Value <= 0)
            {
                Utils.ShowWarning("Impossible inserire un importo negativo o uguale a zero");
                txtImporto.Focus();
                return;
            }

            Movimento.Data = dtMovimento.Value;
            Movimento.Descrizione = cmbDescrizione.Text;
            Movimento.Importo = txtImporto.Value;
            Movimento.Risorsa = cmbRisorsa.SelectedIndex == 0 ? Risorsa.Cassa : Risorsa.Banca;
            //Movimento.Tipo = cmbTipo.SelectedIndex == 0 ? TipoMovimento.Entrata : TipoMovimento.Uscita;
            Movimento.Tipo = rbEntrata.Checked ? TipoMovimento.Entrata : TipoMovimento.Uscita;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
