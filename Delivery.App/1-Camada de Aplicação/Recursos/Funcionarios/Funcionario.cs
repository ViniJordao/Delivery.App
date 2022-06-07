using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.App._1_Camada_de_Aplicação.Recursos.Funcionarios
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal form1 = new TelaPrincipal();
            form1.ShowDialog();
            this.Close();
        }
    }
}
