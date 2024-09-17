using System;
using System.Windows.Forms;
using cafezito;


namespace coffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonentrar_Click(object sender, EventArgs e)
        {
         
            CafezitoView cafe = new CafezitoView();
            // Fecha o Form1
            this.Hide();

            // Exibe o Form2
            cafe.Show();
        }

        private void buttoncriar_Click(object sender, EventArgs e)
        {
            CafezitoView cafe = new CafezitoView();
            // Fecha o Form1
            this.Hide();

            // Exibe o Form2
            cafe.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Fecha o Form1
            this.Close();

            // Exibe o Form2
            form1.Show();
        }
    }
}
