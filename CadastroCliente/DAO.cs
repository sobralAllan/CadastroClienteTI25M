using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;//Importar os elementos do MySQL

namespace CadastroCliente
{
    class DAO
    {
        public MySqlConnection conexao;//Armazenar os parâmetros de configuração com o BD
        public int[] codigo;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;

        public DAO() 
        {
            this.conexao = new MySqlConnection("server=localhost;Database=cadastroCliente;Uid=root;password=");
            try
            {
                this.conexao.Open();//Abrir a conexao com o Banco
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do construtor

        public string Cadastrar(long cpf, string nome, string telefone, string endereco)
        {
            string inserir = $"insert into cliente(codigo, cpf, nome, telefone, endereco) values" +
                             $"('','{cpf}','{nome}','{telefone}','{endereco}')";

            //Começar a executar ele no banco
            MySqlCommand sql = new MySqlCommand(inserir, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Cadastrado!";
            return resultado;
        }//fim do método cadastrar

        public void PreencherVetor()
        {
            string consultar = "select * from cliente";

            //Instanciar
            this.codigo   = new int[100];
            this.cpf      = new long[100];
            this.nome     = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //Comando de relação com o banco
            MySqlCommand sql = new MySqlCommand(consultar, this.conexao);
            //Leitura do Banco
            MySqlDataReader leitura = sql.ExecuteReader();

            this.i = 0; //Organizar o preenchimento por posição
            this.contador = 0;//Quantidade de dados efetivamente no vetor

            //Preencher
            while (leitura.Read())
            {
                this.codigo[i]   = Convert.ToInt32(leitura["codigo"]);
                this.cpf[i]      = Convert.ToInt64(leitura["cpf"]);
                this.nome[i]     = leitura["nome"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                this.endereco[i] = leitura["endereco"] + "";
                this.i++;//Percorre o vetor
                this.contador++;//Conta quantos dados estão no vetor
            }//fim do while

            //Encerrar o comando DAO
            leitura.Close();
        }//fim do preencherVetor

        //Método que mostra a quantidade de dados
        public int QuantidadeDeDados()
        {
            return this.contador;
        }//fim do método

        public string Atualizar(long CPF, string nomeCampo, string novoDado)
        {
            string query     = $"update cliente set {nomeCampo} = '{novoDado}' where cpf = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//fim do atualizar

        public string Excluir(long CPF)
        {
            string query = $"delete from cliente where cpf = {CPF}";
            MySqlCommand sql = new MySqlCommand(query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluído!";
            return resultado;
        }//fim do excluir
    }//fim da classe
}//fim do projeto
