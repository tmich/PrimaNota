namespace PrimaNota
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotUscCas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungiMovimento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotEntrCas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotEntrBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotUscBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridmov = new System.Windows.Forms.DataGridView();
            this.txtCassetta = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassetta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movimenti del";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mattina",
            "Pomeriggio",
            "Turno Unico"});
            this.cmbTurno.Location = new System.Drawing.Point(137, 48);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(200, 24);
            this.cmbTurno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turno";
            // 
            // txtTotUscCas
            // 
            this.txtTotUscCas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotUscCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotUscCas.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTotUscCas.Location = new System.Drawing.Point(869, 677);
            this.txtTotUscCas.Name = "txtTotUscCas";
            this.txtTotUscCas.ReadOnly = true;
            this.txtTotUscCas.Size = new System.Drawing.Size(129, 28);
            this.txtTotUscCas.TabIndex = 5;
            this.txtTotUscCas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 685);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Totale uscite";
            // 
            // btnAggiungiMovimento
            // 
            this.btnAggiungiMovimento.Location = new System.Drawing.Point(3, 7);
            this.btnAggiungiMovimento.Name = "btnAggiungiMovimento";
            this.btnAggiungiMovimento.Size = new System.Drawing.Size(94, 36);
            this.btnAggiungiMovimento.TabIndex = 7;
            this.btnAggiungiMovimento.Text = "Nuovo";
            this.btnAggiungiMovimento.UseVisualStyleBackColor = true;
            this.btnAggiungiMovimento.Click += new System.EventHandler(this.btnAggiungiMovimento_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 651);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Totale entrate";
            // 
            // txtTotEntrCas
            // 
            this.txtTotEntrCas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotEntrCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotEntrCas.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotEntrCas.Location = new System.Drawing.Point(869, 643);
            this.txtTotEntrCas.Name = "txtTotEntrCas";
            this.txtTotEntrCas.ReadOnly = true;
            this.txtTotEntrCas.Size = new System.Drawing.Size(129, 28);
            this.txtTotEntrCas.TabIndex = 8;
            this.txtTotEntrCas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 651);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Totale entrate";
            // 
            // txtTotEntrBan
            // 
            this.txtTotEntrBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotEntrBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotEntrBan.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotEntrBan.Location = new System.Drawing.Point(609, 643);
            this.txtTotEntrBan.Name = "txtTotEntrBan";
            this.txtTotEntrBan.ReadOnly = true;
            this.txtTotEntrBan.Size = new System.Drawing.Size(129, 28);
            this.txtTotEntrBan.TabIndex = 12;
            this.txtTotEntrBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Totale uscite";
            // 
            // txtTotUscBan
            // 
            this.txtTotUscBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotUscBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotUscBan.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTotUscBan.Location = new System.Drawing.Point(609, 677);
            this.txtTotUscBan.Name = "txtTotUscBan";
            this.txtTotUscBan.ReadOnly = true;
            this.txtTotUscBan.Size = new System.Drawing.Size(129, 28);
            this.txtTotUscBan.TabIndex = 10;
            this.txtTotUscBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(895, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Totali Cassa";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(635, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Totali Banca";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Importo Cassetta";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gridmov);
            this.panel1.Controls.Add(this.btnAggiungiMovimento);
            this.panel1.Location = new System.Drawing.Point(15, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 500);
            this.panel1.TabIndex = 18;
            // 
            // gridmov
            // 
            this.gridmov.AllowUserToAddRows = false;
            this.gridmov.AllowUserToDeleteRows = false;
            this.gridmov.AllowUserToOrderColumns = true;
            this.gridmov.AllowUserToResizeRows = false;
            this.gridmov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridmov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmov.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridmov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridmov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmov.Location = new System.Drawing.Point(3, 49);
            this.gridmov.MultiSelect = false;
            this.gridmov.Name = "gridmov";
            this.gridmov.ReadOnly = true;
            this.gridmov.RowTemplate.Height = 24;
            this.gridmov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmov.Size = new System.Drawing.Size(977, 448);
            this.gridmov.TabIndex = 1;
            this.gridmov.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmov_CellDoubleClick);
            this.gridmov.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridmov_CellFormatting);
            // 
            // txtCassetta
            // 
            this.txtCassetta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCassetta.DecimalPlaces = 2;
            this.txtCassetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCassetta.Location = new System.Drawing.Point(18, 640);
            this.txtCassetta.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtCassetta.Name = "txtCassetta";
            this.txtCassetta.Size = new System.Drawing.Size(120, 28);
            this.txtCassetta.TabIndex = 8;
            this.txtCassetta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCassetta.ThousandsSeparator = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stampa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(344, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "mese? settimana?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrimaNota.Properties.Resources.caffe_elite;
            this.pictureBox1.Location = new System.Drawing.Point(914, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCassetta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotEntrBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotUscBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotEntrCas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotUscCas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Prima Nota - Palmi srl";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassetta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotUscCas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungiMovimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotEntrCas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotEntrBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotUscBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridmov;
        private System.Windows.Forms.NumericUpDown txtCassetta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

