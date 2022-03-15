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
                    lstRiepilogo.Items.Add("Margherita: " + quant);
                    lblMargherita.Text = Convert.ToString(quant);
                    break;

                case "Diavola":
                    lstRiepilogo.Items.Add("Diavola: " + quant);
                    lblDiavola.Text = Convert.ToString(quant);
                    break;

                case "4 Stagioni":
                    lstRiepilogo.Items.Add("4 stagioni: " + quant);
                    lblStagioni.Text = Convert.ToString(quant);
                    break;
            }



        }
    }
}
