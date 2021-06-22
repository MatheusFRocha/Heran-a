using AULAHeranca3.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace AULAHeranca3.View
{
    public partial class FrmJuridica : Form
    {
        public FrmJuridica()
        {
            InitializeComponent();
        }

        private void AtualizarStatus()
        {
            LblTotalJuridica.Text = "Total de cadastros: " + MyGlobal.pessoas.Count().ToString();
        }

        private void CarregarGrid()
        {
            GridJuridica.AutoGenerateColumns = false;
            GridJuridica.DataSource = (from p in MyGlobal.pessoas select p).ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarStatus();
            CarregarGrid();
        }
        private void LimpaControles()
        {
            TxtCNPJ.Text = "";
            TxtNomeFantasma.Text = "";
            TxtRazaoSocial.Text = "";

        }


        private void BtnJuridica_Click(object sender, EventArgs e)
        {
            
            JURIDICA jURIDICA = new JURIDICA();
            jURIDICA.CNPJ = TxtCNPJ.Text;
            jURIDICA.NomeFantasma = TxtNomeFantasma.Text;
            jURIDICA.RazaoSocial = TxtRazaoSocial.Text;

            MyGlobal.juridicas.Add(jURIDICA);
            LimpaControles();
            AtualizarStatus();
            CarregarGrid();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }


        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}