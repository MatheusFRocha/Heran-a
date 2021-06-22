using AULAHeranca3.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace AULAHeranca3.View
{
    public partial class FrmTime : Form
    {
        public FrmTime()
        {
            InitializeComponent();
        }

        private void AtualizarStatus()
        {
            LblTotalTimes.Text = "Total de times: " + MyGlobal.pessoas.Count().ToString();
        }

        private void CarregarGrid()
        {
            GridTime.AutoGenerateColumns = false;
            GridTime.DataSource = (from p in MyGlobal.pessoas select p).ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarStatus();
            CarregarGrid();
        }
        private void LimpaControles()
        {
            TxtNomeTime.Text = "";
            TxtTime.Text = "";

        }


        private void BtnCriarTime_Click(object sender, EventArgs e)
        {
            //Model.PESSOA pESSOA = new Model.PESSOA();
            TIME tIME = new TIME();
            tIME.Nome = TxtNomeTime.Text;
            tIME.Time = TxtTime.Text;

            MyGlobal.pessoas.Add(tIME);
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