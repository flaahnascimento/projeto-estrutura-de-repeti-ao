using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lista_de__0_a_20 : Form
    {
        public lista_de__0_a_20()
        {
            InitializeComponent();
        }

        private void btNLISTE_Click(object sender, EventArgs e)
        {
            //variaveis - incrementador inicio 0

            int i = 0;

            //limpando para adicionar

            txtlist.Items.Clear();

            //processo - colocando condicao e adicionando incrementador

            while (i <= 20)
            {
                txtlist.Items.Add(i);
                i++;

            }
            //saida
            MessageBox.Show("fim da lista");


        }
    }
}
