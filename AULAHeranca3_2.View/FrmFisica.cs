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

namespace AULAHeranca3_2.View
{
    public partial class FrmFisica : Form
    {
        public FrmFisica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Model.FISICA fISICA = new Model.FISICA();
            FISICA fISICA = new FISICA();
            fISICA.Nome = TxtNome1.Text;
            fISICA.CPF = TxtCPF1.Text;

            FISICA fISICA1 = new FISICA(TxtNome1.Text, TxtCPF1.Text);
        }
    }
}
