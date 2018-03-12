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
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRisorsa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEntrata = new System.Windows.Forms.RadioButton();
            this.rbUscita = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMovimento
            // 
            this.dtMovimento.Location = new System.Drawing.Point(128, 44);
            this.dtMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(329, 27);
            this.dtMovimento.TabIndex = 0;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(128, 87);
            this.txtDescrizione.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(329, 27);
            this.txtDescrizione.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrizione";
            // 
            // cmbRisorsa
            // 
            this.cmbRisorsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRisorsa.FormattingEnabled = true;
            this.cmbRisorsa.Items.AddRange(new object[] {
            "Cassa",
            "Banca"});
            this.cmbRisorsa.Location = new System.Drawing.Point(128, 130);
            this.cmbRisorsa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRisorsa.Name = "cmbRisorsa";
            this.cmbRisorsa.Size = new System.Drawing.Size(202, 28);
            this.cmbRisorsa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Risorsa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // txtImporto
            // 
            this.txtImporto.DecimalPlaces = 2;
            this.txtImporto.Location = new System.Drawing.Point(128, 218);
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
            this.label5.Location = new System.Drawing.Point(54, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Importo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 296);
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
            this.panel1.Location = new System.Drawing.Point(128, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 31);
            this.panel1.TabIndex = 13;
            // 
            // rbEntrata
            // 
            this.rbEntrata.AutoSize = true;
            this.rbEntrata.Checked = true;
            this.rbEntrata.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbEntrata.Location = new System.Drawing.Point(3, 3);
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
            this.rbUscita.Location = new System.Drawing.Point(121, 3);
            this.rbUscita.Name = "rbUscita";
            this.rbUscita.Size = new System.Drawing.Size(78, 24);
            this.rbUscita.TabIndex = 13;
            this.rbUscita.Text = "Uscita";
            this.rbUscita.UseVisualStyleBackColor = true;
            // 
            // FMovimento
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImporto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRisorsa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescrizione);
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
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRisorsa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtImporto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEntrata;
        private System.Windows.Forms.RadioButton rbUscita;
    }
}