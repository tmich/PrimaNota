namespace PrimaNota
{
    partial class FDescrizioneMovimento
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
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEntrata = new System.Windows.Forms.RadioButton();
            this.rbUscita = new System.Windows.Forms.RadioButton();
            this.cmdSalva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(117, 59);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(383, 27);
            this.txtDescrizione.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrizione";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEntrata);
            this.panel1.Controls.Add(this.rbUscita);
            this.panel1.Location = new System.Drawing.Point(117, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 31);
            this.panel1.TabIndex = 14;
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
            this.rbUscita.Location = new System.Drawing.Point(102, 3);
            this.rbUscita.Name = "rbUscita";
            this.rbUscita.Size = new System.Drawing.Size(78, 24);
            this.rbUscita.TabIndex = 13;
            this.rbUscita.Text = "Uscita";
            this.rbUscita.UseVisualStyleBackColor = true;
            // 
            // cmdSalva
            // 
            this.cmdSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalva.Location = new System.Drawing.Point(405, 155);
            this.cmdSalva.Name = "cmdSalva";
            this.cmdSalva.Size = new System.Drawing.Size(95, 33);
            this.cmdSalva.TabIndex = 16;
            this.cmdSalva.Text = "Salva";
            this.cmdSalva.UseVisualStyleBackColor = true;
            this.cmdSalva.Click += new System.EventHandler(this.cmdSalva_Click);
            // 
            // FDescrizioneMovimento
            // 
            this.AcceptButton = this.cmdSalva;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 200);
            this.Controls.Add(this.cmdSalva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescrizione);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FDescrizioneMovimento";
            this.Text = "Descrizione Movimento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEntrata;
        private System.Windows.Forms.RadioButton rbUscita;
        private System.Windows.Forms.Button cmdSalva;
    }
}