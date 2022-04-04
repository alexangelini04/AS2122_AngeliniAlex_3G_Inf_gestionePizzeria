
namespace AS2122_AngeliniAlex_3G_Inf_gestionePizzeria
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMargherita = new System.Windows.Forms.Label();
            this.lblDiavola = new System.Windows.Forms.Label();
            this.lblStagioni = new System.Windows.Forms.Label();
            this.cmbPizze = new System.Windows.Forms.ComboBox();
            this.lstRiepilogo = new System.Windows.Forms.ListBox();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(184, 59);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipi di pizze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantità:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Totale Margherite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Totale Diavola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Totale 4 Stagioni:";
            // 
            // lblMargherita
            // 
            this.lblMargherita.AutoSize = true;
            this.lblMargherita.Location = new System.Drawing.Point(131, 194);
            this.lblMargherita.Name = "lblMargherita";
            this.lblMargherita.Size = new System.Drawing.Size(10, 13);
            this.lblMargherita.TabIndex = 6;
            this.lblMargherita.Text = ".";
            // 
            // lblDiavola
            // 
            this.lblDiavola.AutoSize = true;
            this.lblDiavola.Location = new System.Drawing.Point(131, 225);
            this.lblDiavola.Name = "lblDiavola";
            this.lblDiavola.Size = new System.Drawing.Size(10, 13);
            this.lblDiavola.TabIndex = 7;
            this.lblDiavola.Text = ".";
            // 
            // lblStagioni
            // 
            this.lblStagioni.AutoSize = true;
            this.lblStagioni.Location = new System.Drawing.Point(131, 263);
            this.lblStagioni.Name = "lblStagioni";
            this.lblStagioni.Size = new System.Drawing.Size(10, 13);
            this.lblStagioni.TabIndex = 8;
            this.lblStagioni.Text = ".";
            // 
            // cmbPizze
            // 
            this.cmbPizze.FormattingEnabled = true;
            this.cmbPizze.Items.AddRange(new object[] {
            "Margherita",
            "Diavola",
            "4 Stagioni"});
            this.cmbPizze.Location = new System.Drawing.Point(33, 61);
            this.cmbPizze.Name = "cmbPizze";
            this.cmbPizze.Size = new System.Drawing.Size(145, 21);
            this.cmbPizze.TabIndex = 9;
            // 
            // lstRiepilogo
            // 
            this.lstRiepilogo.FormattingEnabled = true;
            this.lstRiepilogo.Location = new System.Drawing.Point(290, 61);
            this.lstRiepilogo.Name = "lstRiepilogo";
            this.lstRiepilogo.Size = new System.Drawing.Size(142, 277);
            this.lstRiepilogo.TabIndex = 10;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(30, 118);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(50, 20);
            this.txtQuantita.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Riepilogo:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 372);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.lstRiepilogo);
            this.Controls.Add(this.cmbPizze);
            this.Controls.Add(this.lblStagioni);
            this.Controls.Add(this.lblDiavola);
            this.Controls.Add(this.lblMargherita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggiungi);
            this.Name = "frmMain";
            this.Text = "AS2122-AngeliniAlex_3G_Inf_getsionePizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMargherita;
        private System.Windows.Forms.Label lblDiavola;
        private System.Windows.Forms.Label lblStagioni;
        private System.Windows.Forms.ComboBox cmbPizze;
        private System.Windows.Forms.ListBox lstRiepilogo;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Label label6;
    }
}

