using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AULAHeranca3.Model;
namespace AULAHeranca3.View2
{
    public partial class FrmFisica : Form
    {
        public FrmFisica()
        {
            InitializeComponent();
        }
        private void AtualizarStatus()
        {
            LblTotalFisica.Text = "Total de cadastros:" + MyGlobal2.fisicas.Count().ToString();
        }

        private void FrmFisica_Load(object sender, EventArgs e)
        {
            AtualizarStatus();

        }

        private void BtncCriarClasse_Click(object sender, EventArgs e)
        {
            FISICA fISICA = new FISICA();
            fISICA.Nome = TxtNome.Text;
            fISICA.CPF = TxtCPF.Text;

            //FISICA fISICA1 = new FISICA(TxtNome.Text, TxtCPF.Text);

            MyGlobal2.fisicas.Add(fISICA);
        }

    }
}
