namespace PrimaNota
{
    partial class FMovimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRisorsa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEntrata = new System.Windows.Forms.RadioButton();
            this.rbUscita = new System.Windows.Forms.RadioButton();
            this.cmbDescrizione = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFuoriCassa = new System.Windows.Forms.CheckBox();
            this.cmdAggiungiDescrizione = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbOperatore = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMovimento
            // 
            this.dtMovimento.Enabled = false;
            this.dtMovimento.Location = new System.Drawing.Point(128, 44);
            this.dtMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(329, 27);
            this.dtMovimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // cmbRisorsa
            // 
            this.cmbRisorsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRisorsa.FormattingEnabled = true;
            this.cmbRisorsa.Items.AddRange(new object[] {
            "Cassa",
            "Banca"});
            this.cmbRisorsa.Location = new System.Drawing.Point(128, 268);
            this.cmbRisorsa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRisorsa.Name = "cmbRisorsa";
            this.cmbRisorsa.Size = new System.Drawing.Size(202, 28);
            this.cmbRisorsa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Risorsa";
            // 
            // txtImporto
            // 
            this.txtImporto.DecimalPlaces = 2;
            this.txtImporto.Location = new System.Drawing.Point(128, 314);
            this.txtImporto.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtImporto.Name = "txtImporto";
            this.txtImporto.Size = new System.Drawing.Size(120, 27);
            this.txtImporto.TabIndex = 8;
            this.txtImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporto.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Importo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(469, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEntrata);
            this.panel1.Controls.Add(this.rbUscita);
            this.panel1.Location = new System.Drawing.Point(128, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 31);
            this.panel1.TabIndex = 13;
            // 
            // rbEntrata
            // 
            this.rbEntrata.AutoSize = true;
            this.rbEntrata.Checked = true;
            this.rbEntrata.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbEntrata.Location = new System.Drawing.Point(6, 3);
            this.rbEntrata.Name = "rbEntrata";
            this.rbEntrata.Size = new System.Drawing.Size(84, 24);
            this.rbEntrata.TabIndex = 14;
            this.rbEntrata.TabStop = true;
            this.rbEntrata.Text = "Entrata";
            this.rbEntrata.UseVisualStyleBackColor = true;
            // 
            // rbUscita
            // 
            this.rbUscita.AutoSize = true;
            this.rbUscita.ForeColor = System.Drawing.Color.DarkRed;
            this.rbUscita.Location = new System.Drawing.Point(102, 3);
            this.rbUscita.Name = "rbUscita";
            this.rbUscita.Size = new System.Drawing.Size(78, 24);
            this.rbUscita.TabIndex = 13;
            this.rbUscita.Text = "Uscita";
            this.rbUscita.UseVisualStyleBackColor = true;
            this.rbUscita.CheckedChanged += new System.EventHandler(this.rbUscita_CheckedChanged);
            // 
            // cmbDescrizione
            // 
            this.cmbDescrizione.DisplayMember = "Valore";
            this.cmbDescrizione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescrizione.FormattingEnabled = true;
            this.cmbDescrizione.Location = new System.Drawing.Point(128, 223);
            this.cmbDescrizione.Name = "cmbDescrizione";
            this.cmbDescrizione.Size = new System.Drawing.Size(329, 28);
            this.cmbDescrizione.TabIndex = 14;
            this.cmbDescrizione.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descrizione";
            // 
            // chkFuoriCassa
            // 
            this.chkFuoriCassa.AutoSize = true;
            this.chkFuoriCassa.Location = new System.Drawing.Point(338, 270);
            this.chkFuoriCassa.Name = "chkFuoriCassa";
            this.chkFuoriCassa.Size = new System.Drawing.Size(119, 24);
            this.chkFuoriCassa.TabIndex = 16;
            this.chkFuoriCassa.Text = "Fuori cassa";
            this.chkFuoriCassa.UseVisualStyleBackColor = true;
            // 
            // cmdAggiungiDescrizione
            // 
            this.cmdAggiungiDescrizione.BackColor = System.Drawing.Color.LightGreen;
            this.cmdAggiungiDescrizione.Location = new System.Drawing.Point(464, 223);
            this.cmdAggiungiDescrizione.Name = "cmdAggiungiDescrizione";
            this.cmdAggiungiDescrizione.Size = new System.Drawing.Size(38, 28);
            this.cmdAggiungiDescrizione.TabIndex = 17;
            this.cmdAggiungiDescrizione.Text = "+";
            this.cmdAggiungiDescrizione.UseVisualStyleBackColor = false;
            this.cmdAggiungiDescrizione.Click += new System.EventHandler(this.cmdAggiungiDescrizione_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DisplayMember = "Descrizione";
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(128, 88);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(329, 28);
            this.cmbTurno.TabIndex = 19;
            this.cmbTurno.ValueMember = "Id";
            // 
            // cmbOperatore
            // 
            this.cmbOperatore.DisplayMember = "Descrizione";
            this.cmbOperatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperatore.FormattingEnabled = true;
            this.cmbOperatore.Location = new System.Drawing.Point(128, 132);
            this.cmbOperatore.Name = "cmbOperatore";
            this.cmbOperatore.Size = new System.Drawing.Size(329, 28);
            this.cmbOperatore.TabIndex = 21;
            this.cmbOperatore.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Operatore";
            // 
            // FMovimento
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 496);
            this.Controls.Add(this.cmbOperatore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAggiungiDescrizione);
            this.Controls.Add(this.chkFuoriCassa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDescrizione);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImporto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRisorsa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMovimento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMovimento";
            this.Text = "Movimento";
            ((System.ComponentModel.ISupportInitialize)(this.txtImporto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMovimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRisorsa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtImporto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEntrata;
        private System.Windows.Forms.RadioButton rbUscita;
        private System.Windows.Forms.ComboBox cmbDescrizione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFuoriCassa;
        private System.Windows.Forms.Button cmdAggiungiDescrizione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbOperatore;
        private System.Windows.Forms.Label label6;
    }
}