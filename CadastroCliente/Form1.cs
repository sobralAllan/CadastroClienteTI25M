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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {

        }

        private void tituloPagina_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Mostrar a tela
        }//fim do método cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.ShowDialog();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }
    }
}
