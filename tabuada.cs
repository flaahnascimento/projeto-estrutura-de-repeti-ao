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
    public partial class tabuada : Form
    {
        public tabuada()
        {
            InitializeComponent();
        }

        private void btncalcule_Click(object sender, EventArgs e)
        {
            {
                //variaveis - inicio 0
                int i = 0, numero;

                //entradas - convertendo
                numero = int.Parse(txtnumero.Text);

                //processo - enquanto(condicao for true) execute o que tiver dentro da chave

                while (i <= 10)
                {
                    txtlist.Items.Add(numero + " X " + i + " = " + numero * i);
                    i++;

                }

            }
        }
    }
}
