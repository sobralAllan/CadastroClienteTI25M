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
    public partial class Atualizar : Form
    {
        DAO bd;
        Cadastrar cad;
        public Atualizar()
        {
            InitializeComponent();
            bd  = new DAO();
            cad = new Cadastrar();
        }//fim do construtor

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Campo CPF

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Campo Campo

        private void enderecoTexto_TextChanged(object sender, EventArgs e)
        {

        }//Campo novoDado

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                long cpf = Convert.ToInt64(cad.RemoverFormatacaoCPF(maskedTextBox1.Text));
                string campo = textBox1.Text;
                string novoDado = enderecoTexto.Text;
                //Atualizar
                MessageBox.Show(bd.Atualizar(cpf, campo, novoDado));
                //Limpar Tela
                maskedTextBox1.Text = "";
                textBox1.Text = "";
                enderecoTexto.Text = "";
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro);
            }
        }//fim do botão atualizar
    }//fim da classe
}//fim do projeto
