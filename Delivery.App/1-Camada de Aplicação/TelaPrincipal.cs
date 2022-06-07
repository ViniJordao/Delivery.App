using Delivery.App._1_Camada_de_Aplicação.Recursos.Cliente;
using Delivery.App._1_Camada_de_Aplicação.Recursos.Estabelecimento;
using Delivery.App._1_Camada_de_Aplicação.Recursos.Funcionarios;
using Delivery.App._1_Camada_de_Aplicação.Recursos.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.App._1_Camada_de_Aplicação
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produtos produtos = new Produtos();
            produtos.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estabelecimento estabelecimento = new Estabelecimento();
            estabelecimento.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionario funcionario   = new Funcionario(); 
            funcionario.Show();
        }

       
    }
}
