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
    public partial class defina_um_intervalo : Form
    {
        public defina_um_intervalo()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            //variaveis
            int inicio = 0, fim;
            txtlist.Items.Clear();

            //entradas - convertendo
            inicio = int.Parse(txtinicio.Text);
            fim = int.Parse(txtfim.Text);


            //processo
            for (inicio = 0; inicio <= fim; inicio++)
            {
                //limpando e adicionando contador
              
                txtlist.Items.Add(inicio);
                
            }
            
            //adicionando caixa de mensagem
            MessageBox.Show(" fim da execucao for");
        }

        private void btnDwhile_Click(object sender, EventArgs e)
        {
           
            //variaveis
            int inicio = 0, fim;
            txtlist.Items.Clear();


            //entradas - convertendo
            inicio = int.Parse(txtinicio.Text);
            fim = int.Parse(txtfim.Text);
            

            //processo
            do
            {
                txtlist.Items.Add(inicio);
                inicio++;

            } while (inicio <= fim);
          

            //adicionando caixa de mensagem
            MessageBox.Show(" fim da execucao do-while");

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            //variaveis
            int inicio = 0, fim;
            txtlist.Items.Clear();

            //entradas - convertendo
            inicio = int.Parse(txtinicio.Text);
            fim = int.Parse(txtfim.Text);


            //processo
            while (inicio <= fim)
            {
                //se a condicao for true adiciona + 1 no contador ate for false e parar a execucao
                txtlist.Items.Add(inicio);
                inicio++;
            }
           
            //adicionando caixa de mensagem
            MessageBox.Show(" fim da execucao while");


        }
    }

}
