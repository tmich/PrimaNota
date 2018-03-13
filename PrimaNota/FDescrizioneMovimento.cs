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

namespace PrimaNota
{
    public partial class FDescrizioneMovimento : Form
    {
        public FDescrizioneMovimento()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public FDescrizioneMovimento(DescrizioneMovimento descmov)
            : this()
        {
            Descrizione = descmov;
        }

        public DescrizioneMovimento Descrizione { get; private set; }

        private void cmdSalva_Click(object sender, EventArgs e)
        {
            if (txtDescrizione.Text.Trim().Equals(string.Empty))
            {
                Utils.ShowWarning("Inserire una descrizione");
                txtDescrizione.Focus();
                return;
            }

            Descrizione.Valore = txtDescrizione.Text;
            Descrizione.Tipo = rbEntrata.Checked ? TipoMovimento.Entrata : TipoMovimento.Uscita;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
