using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();
            //Configurar o GRID
            ConfigurarGrid();
            NomeColunas();
            bd.PreencherVetor();//Método de consulta da DAO
            AdicionarLinhas();//Colocar os dados no GRID
        }//fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botão voltar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGridView

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "CPF";
            dataGridView1.Columns[2].Name = "Nome";
            dataGridView1.Columns[3].Name = "Telefone";
            dataGridView1.Columns[4].Name = "Endereço";
        }//fim do nomeDados

        public void AdicionarLinhas()
        {
            for(int i=0; i< bd.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.codigo[i], bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereco[i]);
            }//fim do for
        }//fim do adicionar

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Usuário não pode adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Usuário não pode apagar linhas
            dataGridView1.AllowUserToResizeRows = false;//Usuário não pode redimensionar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Usuário não pode redimensionar colunas
            dataGridView1.ColumnCount = 5;//Quantidade de colunas
        }//fim do configurar
    }//fim da classe
}//fim do projeto
