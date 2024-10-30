using cafezito.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafezito
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

      
        private void buttoncriar_Click_1(object sender, EventArgs e)
        {

            string senha = txbcadsenha.Text;
            string usuário = txbcaduser.Text;

            Cliente cli = new Cliente(senha, usuário);

            ClienteDAO clienteDAO = new ClienteDAO();

            clienteDAO.insert(cli);

            txbcadsenha.Clear();
            txbcaduser.Clear();

            MessageBox.Show("Usuário salvo com sucesso");


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
