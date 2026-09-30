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
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }//fim do construtor

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void codigoTexto_TextChanged(object sender, EventArgs e)
        {

        }//Campo CPF

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(codigoTexto.Text);
                MessageBox.Show(bd.Excluir(cpf));
                //Limpar o campo
                codigoTexto.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do botão excluir
    }//fim da classe
}//fim do projeto
