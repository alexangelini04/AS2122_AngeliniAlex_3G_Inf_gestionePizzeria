using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_AngeliniAlex_3G_Inf_gestionePizzeria
{
    public partial class frmMain : Form
    {
        int margherita = 0, diavola = 0, quattroStagioni = 0;
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int quant = 0;


            if (txtQuantita.Text != "")
            {
                quant = Convert.ToInt32(txtQuantita.Text);
            }
            else
            {
                MessageBox.Show("Inserisci la quantità di pizze");
                return;
            }

            switch (cmbPizze.Text)
            {
                case "Margherita":
                    lblMargherita.Text = Convert.ToString(margherita += quant);
                    lstRiepilogo.Items.Add("Margherita: " + margherita);
                    break;

                case "Diavola":
                    lblDiavola.Text = Convert.ToString(diavola += quant);
                    lstRiepilogo.Items.Add("Diavola: " + diavola);
                    break;

                case "4 Stagioni":
                    lblStagioni.Text = Convert.ToString(quattroStagioni += quant);
                    lstRiepilogo.Items.Add("4 stagioni: " + quattroStagioni);
                    break;
            }
        }
    }
}
