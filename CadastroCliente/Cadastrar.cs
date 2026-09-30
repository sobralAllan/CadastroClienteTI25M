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
    public partial class Cadastrar : Form
    {
        DAO bd;//Chamando a classe DAO
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();//Instanciando a variável BD e Abrindo a conexão com o banco
        }//fim do construtor

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Colentando os dados da tela para enviar ao banco de dados
                long cpf        = Convert.ToInt64(RemoverFormatacaoCPF(maskedTextBox1.Text));
                string nome     = nomeTexto.Text;
                string telefone = maskedTextBox2.Text;
                string endereco = enderecoTexto.Text;

                //Cadastro no banco
                MessageBox.Show(bd.Cadastrar(cpf, nome, telefone, endereco));

                //Limpar a tela
                LimparTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }//fim do catch
        }//fim do botão cadastrar

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do remover

        public void LimparTela()
        {
            maskedTextBox1.Text = "";
            nomeTexto.Text = "";
            maskedTextBox2.Text = "";
            enderecoTexto.Text = "";
        }//fim do método

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo CPF

        private void nomeTexto_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo nome

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo telefone

        private void enderecoTexto_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo endereço
    }//fim da classe
}//fim do projeto
