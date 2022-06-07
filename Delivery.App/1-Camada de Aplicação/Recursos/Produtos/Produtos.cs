using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.App._1_Camada_de_Aplicação.Recursos.Produtos
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

   

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal form1 = new TelaPrincipal();
            form1.ShowDialog();
            this.Close();
        }
    }
        
}
