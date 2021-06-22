using AULAHeranca3.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace AULAHeranca3.View
{
    public partial class FrmFisica : Form
    {
        public FrmFisica()
        {
            InitializeComponent();
        }

        private void AtualizarStatus()
        {
            LblTotalFisica.Text = "Total de cadastros: " + MyGlobal.pessoas.Count().ToString();
        }

        private void CarregarGrid()
        {
            GridFisica.AutoGenerateColumns = false;
            GridFisica.DataSource = (from p in MyGlobal.pessoas select p).ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarStatus();
            CarregarGrid();
        }
        private void LimpaControles()
        {
            TxtNome1.Text = "";
            TxtCPF1.Text = "";
           
        }


        private void BtnFisica_Click(object sender, EventArgs e)
        {
            //Model.PESSOA pESSOA = new Model.PESSOA();
            FISICA fISICA = new FISICA();
            fISICA.Nome = TxtNome1.Text;
            fISICA.CPF = TxtCPF1.Text;

            MyGlobal.pessoas.Add(fISICA);
            LimpaControles();
            AtualizarStatus();
            CarregarGrid();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

   
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gridfisica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridFisica.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GridFisica.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente deletar a Pessoa? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FISICA fISICA = (FISICA)GridFisica.Rows[e.RowIndex].DataBoundItem;
                        MyGlobal.pessoas.Remove(fISICA);
                        CarregarGrid();
                        AtualizarStatus();
                        MessageBox.Show("Pessoa excluida com sucesso!");
                    }
                }
            }
        }

        
    }
}