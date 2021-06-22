using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULAHeranca3.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            MnPessoa.Click += MnPessoa_Click;
           
        }

        private void MnPessoa_Click(object sender, EventArgs e)
        {
            FrmPessoa ofrm = new FrmPessoa();
            ofrm.MdiParent = this;
            ofrm.Show();
        }
        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void MnFisica_Click_1(object sender, EventArgs e)
        {
            FrmFisica ofrm = new FrmFisica();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void MnJuridica_Click(object sender, EventArgs e)
        {
            FrmJuridica ofrm = new FrmJuridica();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void MnTime_Click(object sender, EventArgs e)
        {
            FrmTime ofrm = new FrmTime();
            ofrm.MdiParent = this;
            ofrm.Show();
        }
    }
}
