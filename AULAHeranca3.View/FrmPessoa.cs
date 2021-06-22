using AULAHeranca3.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace AULAHeranca3.View
{
    public partial class FrmPessoa : Form
    {
        public FrmPessoa()
        {
            InitializeComponent();
        }

        private void AtualizarStatus()
        {
            LblTotalPessoa.Text = "Total de cadastros: " + MyGlobal.pessoas.Count().ToString();
        }

        private void CarregarGrid()
        {
            GridPessoa.AutoGenerateColumns = false;
            GridPessoa.DataSource = (from p in MyGlobal.pessoas select p).ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarStatus();
            CarregarGrid();
        }
        private void LimpaControles()
        {
            txtId.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtCEP.Text = "";
        }


        private void btnCriarClasse_Click(object sender, EventArgs e)
        {
            //Model.PESSOA pESSOA = new Model.PESSOA();
            PESSOA pESSOA = new PESSOA();
            pESSOA.Id = Int32.Parse(txtId.Text);
            pESSOA.Logradouro = txtLogradouro.Text;
            pESSOA.Numero = txtNumero.Text;
            pESSOA.Cidade = txtCidade.Text;
            pESSOA.Bairro = txtBairro.Text;
            pESSOA.CEP = txtCEP.Text;



            //PESSOA pESSOA1 = new PESSOA(Int32.Parse(txtId.Text), txtLogradouro.Text, txtNumero.Text, txtCidade.Text, txtBairro.Text, txtCEP.Text);

            MyGlobal.pessoas.Add(pESSOA);
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

        private void BtnCriar100Obj_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                PESSOA pESSOA = new PESSOA();
                pESSOA.Id = Int32.Parse(i.ToString("0000"));
                pESSOA.Logradouro = "Logradouro: " + i.ToString("0000");
                pESSOA.Numero = "Número: " + i.ToString("00000");
                pESSOA.Cidade = "Cidade: " + i.ToString("0000");
                pESSOA.Bairro = "Bairro: " + i.ToString("0000");
                pESSOA.CEP = "CEP: " + i.ToString("00000");

                MyGlobal.pessoas.Add(pESSOA);
            }
            CarregarGrid();
            AtualizarStatus();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridPessoa.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GridPessoa.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente deletar a Pessoa? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PESSOA pESSOA = (PESSOA)GridPessoa.Rows[e.RowIndex].DataBoundItem;
                        MyGlobal.pessoas.Remove(pESSOA);
                        CarregarGrid();
                        AtualizarStatus();
                        MessageBox.Show("Pessoa excluida com sucesso!");
                    }
                }
            }
        }
    }
}