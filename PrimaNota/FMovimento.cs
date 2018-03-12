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
    public partial class FMovimento : Form
    {
        public Movimento Movimento { get; private set; }

        public FMovimento(Movimento mov)
        {
            InitializeComponent();

            Movimento = mov;
            dtMovimento.Value = Movimento.Data;
            cmbRisorsa.SelectedIndex = Movimento.Risorsa == Risorsa.Cassa ? 0 : 1;
            cmbTipo.SelectedIndex = Movimento.Tipo == TipoMovimento.Entrata ? 0 : 1;
            txtDescrizione.Text = Movimento.Descrizione;
            txtImporto.Value = Movimento.Importo;

            DialogResult = DialogResult.Cancel;
        }

        private void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDescrizione.Text.Trim().Equals(string.Empty))
            {
                ShowWarning("Inserire una descrizione");
                txtDescrizione.Focus();
                return;
            }

            if(dtMovimento.Value > DateTime.Now)
            {
                ShowWarning("Impossible inserire una data futura");
                dtMovimento.Focus();
                return;
            }

            if (txtImporto.Value <= 0)
            {
                ShowWarning("Impossible inserire un importo negativo o uguale a zero");
                txtImporto.Focus();
                return;
            }

            Movimento.Data = dtMovimento.Value;
            Movimento.Descrizione = txtDescrizione.Text;
            Movimento.Importo = txtImporto.Value;
            Movimento.Risorsa = cmbRisorsa.SelectedIndex == 0 ? Risorsa.Cassa : Risorsa.Banca;
            Movimento.Tipo = cmbTipo.SelectedIndex == 0 ? TipoMovimento.Entrata : TipoMovimento.Uscita;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
