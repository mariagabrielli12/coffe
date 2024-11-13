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
    public partial class CafezitoView : Form
    {
        private int Id = -1;
        public CafezitoView()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txbtiposdecafe.Clear();
            txbacompanhamentos.Clear();
            
        }

        private bool ValidateFields()
        {
            if (txbtiposdecafe.Text.Length == 0 || txbacompanhamentos.Text.Length == 0)
            {
                MessageBox.Show("Os campos Tipos de café e Acompanhamentos são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void UpdateListView()
        {
            ltvcomprar.Items.Clear();

            ComprarDAO comprarDAO = new ComprarDAO();
            List<Comprar> comprars = comprarDAO.ListAllBrokers();

            //This code part access all brokers received from database and iterate by them.
            foreach (Comprar comprar in comprars)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(ToString());
                item.SubItems.Add(comprar.Tiposdecafe);
                item.SubItems.Add(comprar.Acompanhamento);
                
                //Adding the fully line to the listview.
                ltvcomprar.Items.Add(item);
            }
        }

    
        private void cafezitoView_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
  
      
        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            ComprarDAO comprarDao = new ComprarDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    comprarDao.Delete(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }
        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new ComprarDAO().Update(new Comprar(
                    txbtiposdecafe.Text, txbacompanhamentos.Text));
                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void ltvcomprar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = ltvcomprar.FocusedItem.Index;
                Id = int.Parse(ltvcomprar.Items[index].SubItems[0].Text);
                txbtiposdecafe.Text = ltvcomprar.Items[index].SubItems[1].Text;
                txbacompanhamentos.Text = ltvcomprar.Items[index].SubItems[2].Text;


                btnexcluir.Visible = true;
                btneditar.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncomprar_Click_1(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    if (new ComprarDAO().Insert(new Comprar(
                        txbtiposdecafe.Text, txbacompanhamentos.Text)))
                        MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }
    }
}
